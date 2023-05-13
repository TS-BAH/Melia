﻿using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using Newtonsoft.Json.Linq;
using Yggdrasil.Util;

namespace Melia.Shared.Network2
{
	public class Packet
	{
		private const int DefaultSize = 1024;

		private BufferReaderWriter _buffer;
		private int _bodyStart;

		/// <summary>
		/// Returns the length of the packet's buffer.
		/// </summary>
		public int Length => _buffer.Length;

		/// <summary>
		/// Packet's op.
		/// </summary>
		public int Op { get; protected set; }

		/// <summary>
		/// Creates packet from buffer coming from client.
		/// </summary>
		/// <param name="buffer"></param>
		public Packet(byte[] buffer)
		{
			_buffer = new BufferReaderWriter(buffer);
			_buffer.Endianness = Endianness.LittleEndian;

			this.Op = this.GetShort();
			var index = this.GetInt();
			var checksum = this.GetInt();

			// [i339427]
			// Unknown values that appeared in the header of
			// all client packets at some point.
			var extra = this.GetBin(12);

			_bodyStart = _buffer.Index;
		}

		/// <summary>
		/// Creates new packet with given op.
		/// </summary>
		/// <param name="op"></param>
		public Packet(int op)
		{
			this.Op = op;

			_buffer = new BufferReaderWriter();
			_buffer.Endianness = Endianness.LittleEndian;

			_bodyStart = 0;
		}

		/// <summary>
		/// Sets the reading and writing pointer back to the start of
		/// the packet.
		/// </summary>
		public void Rewind()
		{
			_buffer.Seek(_bodyStart, SeekOrigin.Begin);
		}

		/// <summary>
		/// Reads byte from buffer.
		/// </summary>
		/// <returns></returns>
		public byte GetByte()
			=> _buffer.ReadByte();

		/// <summary>
		/// Reads byte from buffer and returns it as bool (true != 0).
		/// </summary>
		/// <returns></returns>
		public bool GetBool()
			=> this.GetByte() != 0;

		/// <summary>
		/// Reads short from buffer.
		/// </summary>
		/// <returns></returns>
		public short GetShort()
			=> _buffer.ReadInt16();

		/// <summary>
		/// Reads int from buffer.
		/// </summary>
		/// <returns></returns>
		public int GetInt()
			=> _buffer.ReadInt32();

		/// <summary>
		/// Reads long from buffer.
		/// </summary>
		/// <returns></returns>
		public long GetLong()
			=> _buffer.ReadInt64();

		/// <summary>
		/// Reads float from buffer.
		/// </summary>
		/// <returns></returns>
		public float GetFloat()
			=> _buffer.ReadFloat();

		/// <summary>
		/// Reads given number of bytes from buffer and returns them as
		/// UTF8 string. Stops reading at the first null-byte.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString(int length)
		{
			var bytes = _buffer.Read(length);
			var val = Encoding.UTF8.GetString(bytes);

			// Relatively fast way to get rid of null bytes.
			var nullIndex = val.IndexOf((char)0);
			if (nullIndex != -1)
				val = val.Substring(0, nullIndex);

			return val;
		}

		/// <summary>
		/// Reads length-prefixed string from buffer and returns it as
		/// UTF8 string.
		/// </summary>
		/// <returns></returns>
		public string GetLpString()
		{
			var length = this.GetShort();
			return this.GetString(length);
		}

		/// <summary>
		/// Reads null-terminated string from buffer and returns it as UTF8.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetString()
		{
			var index = _buffer.IndexOf(0);
			if (index == -1)
				throw new Exception("String not null-terminated.");

			var len = index - _buffer.Index;
			var val = this.GetString(len);

			// Skip null-terminator
			_buffer.Seek(1, SeekOrigin.Current);

			return val;
		}

		/// <summary>
		/// Reads FileTime from buffer, 8 byte representation.
		/// </summary>
		/// <returns>DateTime</returns>
		public DateTime GetDate()
			=> DateTime.FromFileTime(this.GetLong());

		/// <summary>
		/// Reads struct from buffer.
		/// </summary>
		/// <typeparam name="TStruct"></typeparam>
		/// <returns></returns>
		//public TStruct GetStruct<TStruct>() where TStruct : new()
		//{
		//	var type = typeof(TStruct);
		//	if (!type.IsValueType || type.IsPrimitive)
		//		throw new Exception("GetObj can only marshal to structs.");

		//	var size = Marshal.SizeOf(typeof(TStruct));
		//	var buffer = this.GetBin(size);

		//	var intPtr = Marshal.AllocHGlobal(buffer.Length);
		//	Marshal.Copy(buffer, 0, intPtr, buffer.Length);
		//	var val = Marshal.PtrToStructure(intPtr, typeof(TStruct));
		//	Marshal.FreeHGlobal(intPtr);

		//	return (TStruct)val;
		//}

		/// <summary>
		/// Reads given amount of bytes from buffer.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetBin(int length)
			=> _buffer.Read(length);

		/// <summary>
		/// Reads given amount of bytes from buffer and returns them as hex string.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public string GetBinAsHex(int length)
			=> Hex.ToString(this.GetBin(length), HexStringOptions.None);

		/// <summary>
		/// Reads a binary value from packet, decompresses it, and returns it.
		/// </summary>
		/// <param name="length"></param>
		/// <returns></returns>
		public byte[] GetCompressedBin(int length)
		{
			var buffer = this.GetBin(length);

			using (var msIn = new MemoryStream(buffer))
			using (var msOut = new MemoryStream())
			{
				using (var ds = new DeflateStream(msIn, CompressionMode.Decompress))
					ds.CopyTo(msOut);

				return msOut.ToArray();
			}
		}

		/// <summary>
		/// Writes byte to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(byte val)
			=> _buffer.WriteByte(val);

		/// <summary>
		/// Writes value as byte (0|1) to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutByte(bool val)
			=> this.PutByte(val ? (byte)1 : (byte)0);

		/// <summary>
		/// Writes short to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutShort(int val)
			=> _buffer.WriteInt16((short)val);

		/// <summary>
		/// Writes int to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutInt(int val)
			=> _buffer.WriteInt32(val);

		/// <summary>
		/// Writes uint to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutUInt(uint val)
			=> this.PutInt((int)val);

		/// <summary>
		/// Writes long to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutLong(long val)
			=> _buffer.WriteInt64(val);

		/// <summary>
		/// Writes float to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutFloat(float val)
			=> _buffer.WriteFloat(val);

		/// <summary>
		/// Writes string of given length to buffer.
		/// </summary>
		/// <remarks>
		/// If length is greater than string's length it's filled with null bytes.
		/// </remarks>
		/// <param name="val"></param>
		/// <param name="length"></param>
		public void PutString(string val, int length)
		{
			var bytes = Encoding.UTF8.GetBytes(val ?? "");
			var writeLength = Math.Min(bytes.Length, length - 1);
			var remain = length - writeLength;

			_buffer.Write(bytes, 0, writeLength);

			for (var i = 0; i < remain; ++i)
				_buffer.WriteByte(0);
		}

		/// <summary>
		/// Writes null-terminated string to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutString(string val)
		{
			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[val.Length - 1] != '\0'))
				val += '\0';

			var bytes = Encoding.UTF8.GetBytes(val);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes string to buffer, incl. null terminator, and prefixed
		/// with a short describing its length.
		/// </summary>
		/// <param name="val"></param>
		public void PutLpString(string val)
		{
			if (val == null)
				val = "";

			// Append terminator
			if (val == "" || (val.Length > 0 && val[val.Length - 1] != '\0'))
				val += '\0';

			var bytes = Encoding.UTF8.GetBytes(val);
			this.PutShort(bytes.Length);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes bytes to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(params byte[] val)
			=> _buffer.Write(val);

		/// <summary>
		/// Writes bytes parsed from given hex string to buffer.
		/// </summary>
		/// <param name="hex"></param>
		public void PutBinFromHex(string hex)
		{
			if (hex == null)
				throw new ArgumentNullException("hex");

			var bytes = Hex.ToByteArray(hex);
			this.PutBin(bytes);
		}

		/// <summary>
		/// Writes the given amount of bytes to the buffer.
		/// </summary>
		/// <param name="amount"></param>
		public void PutEmptyBin(int amount)
		{
			if (amount <= 0)
				return;

			this.PutBin(new byte[amount]);
		}

		/// <summary>
		/// Writes struct to buffer.
		/// </summary>
		/// <param name="val"></param>
		public void PutBin(object val)
		{
			var type = val.GetType();
			if (!type.IsValueType || type.IsPrimitive)
				throw new Exception("PutBin only takes byte[] and structs.");

			var size = Marshal.SizeOf(val);
			var arr = new byte[size];
			var ptr = Marshal.AllocHGlobal(size);

			Marshal.StructureToPtr(val, ptr, true);
			Marshal.Copy(ptr, arr, 0, size);
			Marshal.FreeHGlobal(ptr);

			this.PutBin(arr);
		}

		/// <summary>
		/// Writes DateTime to buffer as a long.
		/// </summary>
		/// <param name="val"></param>
		public void PutDate(DateTime val)
			=> this.PutLong(val.ToFileTime());

		/// <summary>
		/// Compresses value and write it to packet, prefixed with its
		/// length as an int.
		/// </summary>
		/// <param name="value">Byte array to put into packet.</param>
		/// <param name="length">Number of bytes to use from the array.</param>
		public void PutCompressedBin(byte[] value, int length)
		{
			using (var ms = new MemoryStream())
			{
				using (var ds = new DeflateStream(ms, CompressionMode.Compress))
					ds.Write(value, 0, length);

				var compressed = ms.ToArray();

				this.PutInt(compressed.Length);
				this.PutBin(compressed);
			}
		}

		/// <summary>
		/// Provides a packet to write values to with a callback function,
		/// which is afterwards (optionally) compressed and written
		/// to this packet as a binary value, prefixed with a length
		/// and a header.
		/// </summary>
		/// <param name="compress"></param>
		/// <param name="zlibPacketFunc"></param>
		public void Zlib(bool compress, Action<Packet> zlibPacketFunc)
		{
			// If uncompressed, empty zlib header, followed by the raw data.
			if (compress == false)
			{
				this.PutShort(0);
				zlibPacketFunc(this);
			}
			// If compressed, write data into a new, temporary packet,
			// and then write the data from that packet into this one,
			// after compressing it.
			else
			{
				var zlibPacket = new Packet(this.Op);
				zlibPacketFunc(zlibPacket);

				var buffer = zlibPacket._buffer.Copy();
				var len = zlibPacket.Length;

				this.PutShort(0xFA8D); // zlib header
				this.PutCompressedBin(buffer, len);
			}
		}

		/// <summary>
		/// Copies packet's body to given buffer at offset.
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		public void Build(ref byte[] buffer, int offset)
			=> _buffer.CopyTo(buffer, offset);

		/// <summary>
		/// Returns buffer as formatted hex string.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			var buffer = _buffer.Copy();
			var length = this.Length;
			var tableSize = Network.Op.GetSize(this.Op);
			var opName = Network.Op.GetName(this.Op);
			var spacer = "".PadLeft(78, '-');

			sb.AppendLine(spacer);
			sb.AppendFormat("Op: {0:X4} {1}, Size: {2}", this.Op, opName, length);
			if (tableSize != 0)
				sb.AppendFormat(" (Table: {0}, Garbage: {1})", tableSize, length - tableSize);
			sb.AppendLine();
			sb.AppendLine(spacer);

			sb.AppendLine(Hex.ToString(buffer, HexStringOptions.HexEditor));

			sb.AppendLine(spacer);

			return sb.ToString().Trim();
		}
	}
}
