//--- Melia Script -----------------------------------------------------------
// Spring Light Woods Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_siauliai_46_1'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai461MobScript : GeneralScript
{
	protected override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Infro_Blud, Properties("MHP", 252801, "MINPATK", 3752, "MAXPATK", 4513, "MINMATK", 3752, "MAXMATK", 4513, "DEF", 13582, "MDEF", 13582));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Shardstatue, Properties("MHP", 254850, "MINPATK", 3778, "MAXPATK", 4545, "MINMATK", 3778, "MAXMATK", 4545, "DEF", 13855, "MDEF", 13855));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Siaulav, Properties("MHP", 256939, "MINPATK", 3805, "MAXPATK", 4578, "MINMATK", 3805, "MAXMATK", 4578, "DEF", 14134, "MDEF", 14134));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Boss_Chafer_Q3, Properties("MHP", 1321242, "MINPATK", 9198, "MAXPATK", 11068, "MINMATK", 9198, "MAXMATK", 11068, "DEF", 34605, "MDEF", 34605));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Npc_Dazz_KRV, Properties("MHP", 261233, "MINPATK", 3861, "MAXPATK", 4646, "MINMATK", 3861, "MAXMATK", 4646, "DEF", 14708, "MDEF", 14708));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Npc_Dazz_SCT, Properties("MHP", 263437, "MINPATK", 3889, "MAXPATK", 4681, "MINMATK", 3889, "MAXMATK", 4681, "DEF", 15003, "MDEF", 15003));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Npc_Dazz_ROD, Properties("MHP", 265678, "MINPATK", 3918, "MAXPATK", 4716, "MINMATK", 3918, "MAXMATK", 4716, "DEF", 15302, "MDEF", 15302));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Npc_Dazz_MNK, Properties("MHP", 267956, "MINPATK", 3947, "MAXPATK", 4752, "MINMATK", 3947, "MAXMATK", 4752, "DEF", 15606, "MDEF", 15606));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Npc_Dazz_BAR, Properties("MHP", 270269, "MINPATK", 3977, "MAXPATK", 4789, "MINMATK", 3977, "MAXMATK", 4789, "DEF", 15915, "MDEF", 15915));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Boss_Manticen_Q1, Properties("MHP", 2276360, "MINPATK", 12622, "MAXPATK", 15202, "MINMATK", 12622, "MAXMATK", 15202, "DEF", 51121, "MDEF", 51121));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_46_1.Id1", MonsterId.Infro_Blud, min: 23, max: 30);
		AddSpawner("f_siauliai_46_1.Id2", MonsterId.Shardstatue, min: 9, max: 12);
		AddSpawner("f_siauliai_46_1.Id3", MonsterId.Shardstatue, min: 23, max: 30);
		AddSpawner("f_siauliai_46_1.Id4", MonsterId.Siaulav, min: 23, max: 30);
		AddSpawner("f_siauliai_46_1.Id5", MonsterId.Rootcrystal_01, min: 10, max: 13, respawn: Seconds(30));

		// Monster Spawn Points -----------------------------

		// 'Infro_Blud' GenType 18 Spawn Points
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-618, -1133, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-715, -163, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-572, -851, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-441, -448, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-744, -525, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-845, 518, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-602, 507, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-199, 88, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-84, 556, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(138, 613, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-257, 371, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-579, -1342, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-439, -1305, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-412, -1423, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-282, -1331, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-76, -914, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-202, -873, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-691, 545, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-607, 588, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-577, 602, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-638, 647, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-707, 677, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-759, 681, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-790, 625, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-870, 616, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-902, 564, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-906, 494, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-818, 580, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-766, 540, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-736, 601, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-674, 466, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-668, 561, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-578, 538, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-733, 479, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-689, 624, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-702, 421, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-737, 364, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-779, 334, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-834, 378, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-798, 430, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-753, 431, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-895, 432, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-806, 493, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-894, 331, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-855, 264, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-807, 231, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-840, 325, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-705, -225, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-668, -183, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-623, -254, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-678, -322, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-665, -277, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-613, -311, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-566, -307, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-505, -357, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-493, -399, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-415, -399, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-365, -464, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-485, -526, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-339, -402, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-515, -443, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-567, -390, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-546, -365, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-590, -503, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-632, -383, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-690, -475, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-715, -397, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-641, -458, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-619, -574, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-689, -576, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-660, -531, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-651, -653, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-590, -643, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-564, -590, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-523, -585, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-535, -666, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-609, -716, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-569, -732, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-552, -792, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-599, -794, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-670, -697, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-551, -491, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-62, 88, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-95, 151, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-159, 204, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-188, 242, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-227, 189, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-257, 161, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-283, 38, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-322, 122, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-254, 73, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-159, 12, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-135, 70, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-175, 145, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-96, 197, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-245, 225, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-265, 306, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-187, 304, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-221, 285, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-190, 343, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-214, 421, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-308, 398, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-301, 153, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-210, 20, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-58, 601, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-65, 640, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-25, 676, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-92, 614, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(13, 703, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(62, 716, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(112, 710, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(144, 675, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(99, 645, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(49, 670, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(17, 612, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(102, 567, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(64, 617, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-5, 567, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(53, 545, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(139, 534, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(195, 567, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(21, 533, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-559, -1163, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-512, -1180, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-499, -1232, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-513, -1285, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-570, -1270, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-613, -1219, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-607, -1175, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-546, -1219, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-545, -1331, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-513, -1412, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-516, -1471, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-451, -1444, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-491, -1379, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-586, -1446, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-411, -1346, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-335, -1406, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-353, -1325, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-242, -1367, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-216, -1317, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-302, -1378, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-375, -1376, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-374, -1445, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-446, -1352, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-443, -1387, 25));
		AddSpawnPoint("f_siauliai_46_1.Id1", "f_siauliai_46_1", Rectangle(-479, -1279, 25));

		// 'Shardstatue' GenType 19 Spawn Points
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(770, -59, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(528, 452, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(823, -253, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(1088, 546, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(850, 586, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(630, 726, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(950, 360, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(1035, -235, 9999));
		AddSpawnPoint("f_siauliai_46_1.Id2", "f_siauliai_46_1", Rectangle(774, 414, 9999));

		// 'Shardstatue' GenType 20 Spawn Points
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(-77, 48, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(610, 680, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(646, 657, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(649, 587, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(579, 595, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(495, 595, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(568, 537, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(615, 545, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(533, 634, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(503, 491, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(595, 417, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(450, 525, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(493, 416, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(633, 440, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(700, 496, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(722, 561, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(758, 598, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(822, 509, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(906, 538, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(890, 632, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(837, 656, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(953, 645, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1020, 601, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1071, 624, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1035, 531, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1144, 558, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1192, 558, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1242, 547, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1305, 555, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1217, 642, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1141, 644, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1275, 660, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1353, 626, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1375, 569, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1334, 602, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1024, 681, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(978, 552, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1001, 447, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1009, 375, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(885, 340, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(862, 421, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(936, 428, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(943, 489, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(881, 479, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(800, 572, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(763, 497, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(720, 385, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(772, 357, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(826, 368, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(658, 505, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(508, 553, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(846, -83, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(868, -68, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(812, -70, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1053, -173, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1115, -243, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1091, -327, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(994, -310, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(950, -241, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(882, -255, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(909, -286, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(920, -204, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(991, -197, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1008, -167, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(999, -264, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1038, -288, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1027, -373, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1076, -384, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1026, -418, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1055, -318, 20));
		AddSpawnPoint("f_siauliai_46_1.Id3", "f_siauliai_46_1", Rectangle(1078, -230, 20));

		// 'Siaulav' GenType 21 Spawn Points
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(206, 47, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(220, 305, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(304, -369, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(484, -261, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(346, -813, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(685, -861, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(356, -1040, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(482, -884, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(418, -653, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(575, -745, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(197, -899, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-60, -990, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-200, -994, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(292, 333, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(256, 373, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(320, 358, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(367, 306, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(391, 244, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(413, 168, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(385, 77, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(369, 51, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(270, 76, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(270, 201, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(341, 215, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(369, 113, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(320, 106, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(315, 160, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(176, 139, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(118, 246, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(94, 296, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(161, 260, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(145, 180, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(222, 228, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(312, 271, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(268, 274, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(231, 138, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(191, 94, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(186, 198, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(449, -313, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(409, -230, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(446, -227, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(411, -295, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(380, -338, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(337, -287, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(369, -231, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(373, -272, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(318, -214, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(268, -271, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(268, -335, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(294, -304, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(224, -301, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(245, -397, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(275, -458, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(332, -419, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(367, -386, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(375, -460, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(314, -481, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(278, -403, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(470, -683, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(524, -703, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(528, -779, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(622, -741, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(675, -775, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(728, -804, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(746, -871, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(664, -924, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(606, -860, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(587, -951, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(557, -887, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(464, -805, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(399, -720, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(334, -718, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(294, -763, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(515, -990, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(381, -899, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(398, -968, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(461, -953, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(415, -1045, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(287, -1024, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(306, -921, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(337, -974, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(277, -860, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(217, -979, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(231, -823, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(317, -878, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(164, -971, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(257, -948, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(241, -1031, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-109, -1022, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-169, -959, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-163, -1040, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-117, -954, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-24, -923, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-72, -859, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-124, -825, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-129, -893, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-238, -933, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-258, -851, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-199, -915, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-175, -821, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-3, -993, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-69, -1034, 20));
		AddSpawnPoint("f_siauliai_46_1.Id4", "f_siauliai_46_1", Rectangle(-166, -906, 20));

		// 'Rootcrystal_01' GenType 22 Spawn Points
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(-417, -1358, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(-1823, 195, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(-571, -453, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(-766, 541, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(-233, 361, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(81, 618, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(286, 180, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(307, -365, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(437, -866, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(1024, -273, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(588, 497, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(756, 1104, 150));
		AddSpawnPoint("f_siauliai_46_1.Id5", "f_siauliai_46_1", Rectangle(1037, 511, 150));
	}
}
