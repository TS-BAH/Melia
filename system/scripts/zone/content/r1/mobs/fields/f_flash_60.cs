//--- Melia Script -----------------------------------------------------------
// Roxona Market Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_60'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash60MobScript : GeneralScript
{
	protected override void Load()
	{
		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_60.Id1", MonsterId.Moya, min: 15, max: 20);
		AddSpawner("f_flash_60.Id2", MonsterId.Bavon, min: 15, max: 20);
		AddSpawner("f_flash_60.Id3", MonsterId.Moya, min: 30, max: 40);
		AddSpawner("f_flash_60.Id4", MonsterId.Bavon, min: 27, max: 35);
		AddSpawner("f_flash_60.Id5", MonsterId.Saltisdaughter_Mage, min: 8, max: 10);
		AddSpawner("f_flash_60.Id6", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: Seconds(20));
		AddSpawner("f_flash_60.Id7", MonsterId.Saltisdaughter_Mage, min: 6, max: 8);

		// Monster Spawn Points -----------------------------

		// 'Moya' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_60.Id1", "f_flash_60", Rectangle(465, 6, 9999));

		// 'Bavon' GenType 17 Spawn Points
		AddSpawnPoint("f_flash_60.Id2", "f_flash_60", Rectangle(288, -27, 9999));

		// 'Moya' GenType 25 Spawn Points
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-609, -958, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-327, -1097, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-235, -948, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(327, -1034, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(475, -1078, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(453, -922, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1265, -1083, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1190, -805, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1305, -938, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-614, -822, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-391, -950, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-136, -1110, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(312, -916, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(182, -772, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(108, -302, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(328, -249, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(353, -27, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(217, -143, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(379, 99, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(218, 440, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(65, 522, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(144, 680, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1193, -307, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1275, -402, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1177, -498, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-669, -85, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-826, 438, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-697, 43, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-728, -253, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1337, -1072, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1362, -979, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1267, -975, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1210, -903, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1156, -835, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1129, -769, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1221, -851, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1184, -933, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1242, -1024, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1217, -1042, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1198, -1080, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1152, -1100, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1197, -1139, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1233, -1113, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1272, -1138, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1343, -1126, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1404, -1154, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1297, -1104, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1362, -1023, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1358, -924, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1435, -1136, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1382, -1113, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1370, -1169, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1403, -981, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1334, -941, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1137, -281, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1206, -274, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1105, -322, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1157, -339, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1086, -398, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1115, -435, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1162, -426, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1212, -373, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1186, -393, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1239, -428, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1219, -477, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1196, -444, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1220, -528, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1130, -535, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1103, -570, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-683, -912, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-571, -877, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-539, -940, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-473, -914, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-398, -1007, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-291, -987, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-317, -962, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-192, -894, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-142, -963, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-208, -1011, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-187, -959, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-251, -1100, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-262, -1053, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-316, -1166, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-276, -1158, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-365, -1142, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-397, -1105, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-429, -1061, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-350, -1020, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-484, -1029, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-740, -880, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-784, -935, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-745, -1032, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-668, -1054, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-663, -968, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(248, -1097, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256, -1037, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(300, -1081, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(409, -1101, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(471, -1128, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(502, -1051, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(444, -1043, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(439, -984, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(527, -995, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(508, -1113, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(391, -945, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(517, -869, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(452, -845, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(372, -880, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(307, -851, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(342, -805, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(261, -788, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(199, -822, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(282, -817, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(231, -890, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(279, -888, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256, -968, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(354, -969, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(302, -999, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(351, -929, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(143, -810, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(220, -773, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(122, -756, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(154, -766, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(116, -804, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(110, -723, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(504, -184, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(416, -211, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(526, -215, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(447, -176, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(524, -18, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(405, -80, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(433, 8, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(286, -67, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(243, -110, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(297, -171, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(333, -192, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(383, -241, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(388, -333, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(259, -279, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(176, -278, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(144, -246, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(206, -393, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(185, -345, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256, -328, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(298, -283, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(62, -336, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(69, -303, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(156, -313, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(395, -375, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(419, -409, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-669, -465, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-641, -463, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-663, -423, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-691, -412, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-654, -377, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-604, -314, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-623, -282, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-671, -290, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-601, -206, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-577, -269, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-641, -153, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-679, -167, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-616, -183, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-610, -248, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-695, -253, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-666, -45, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-656, -1, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-709, -48, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-656, 39, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-676, 4, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-826, 394, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-802, 469, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-843, 537, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-797, 590, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-762, 661, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-813, 625, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-735, 592, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-765, 525, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-772, 559, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-677, 603, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-601, 601, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-619, 515, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-648, 557, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-703, 517, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-700, 562, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-642, 489, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-543, 484, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-514, 429, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-622, 396, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-585, 457, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-710, 436, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-736, 468, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-769, 392, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-722, 387, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-825, 321, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-818, 354, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-673, 324, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-643, 370, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-575, 303, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-512, 384, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-288, 449, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-275, 482, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-318, 409, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-316, 447, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-338, 442, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-238, 58, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-292, -7, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-271, 38, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-326, -48, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-290, -117, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-246, -167, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-206, -103, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-125, -77, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-141, -121, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-61, -77, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-33, -25, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-19, 48, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(31, 90, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-36, 88, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-125, 32, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-127, 68, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-179, 73, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-61, 56, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-75, -46, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-38, -106, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-156, -39, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-196, -51, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-239, -105, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-228, -29, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-94, -110, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-12, -168, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-20, -128, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-87, -167, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-62, -131, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-187, -151, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(111, 645, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(153, 533, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(179, 590, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(206, 507, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(169, 454, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(161, 486, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(99, 517, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(10, 472, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(26, 519, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(38, 430, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(28, 380, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(7, 423, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(75, 427, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(95, 362, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(79, 393, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(124, 440, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(145, 372, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(131, 405, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(221, 386, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(255, 486, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(150, 574, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(182, 413, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(276, 449, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(249, 407, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(309, 418, 25));

		// 'Bavon' GenType 26 Spawn Points
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(399, 11, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-316, -1097, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-723, -981, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-691, -850, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-90, 0, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(71, 472, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(213, 1193, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(251, 1453, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(713, 1509, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(879, 1406, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-480, -966, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-261, -77, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(141, 604, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-194, 478, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(125, 1313, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(112, 1057, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(904, 1563, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(494, 1480, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-241, -959, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-497, 337, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(164, -206, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-480, -1105, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(358, -1066, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(443, -905, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(236, -842, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(305, -930, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(190, -1162, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(298, -335, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-671, -515, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-679, -107, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1247, -332, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1178, -497, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1329, -1009, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1211, -773, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1097, -1037, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(171, 1059, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(128, 1015, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(223, 1080, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(306, 1060, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(236, 1156, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(154, 1107, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(104, 1163, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(89, 1215, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(204, 1237, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(263, 1295, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(271, 1352, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(232, 1325, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(144, 1270, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(153, 1366, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(114, 1442, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(174, 1487, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(137, 1407, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(254, 1504, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(307, 1510, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(259, 1418, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(201, 1456, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(218, 1533, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(358, 1559, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(344, 1599, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(107, 1485, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(660, 1582, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(558, 1499, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(597, 1527, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(598, 1438, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(604, 1476, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(593, 1386, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(627, 1297, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(661, 1305, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(638, 1380, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(696, 1403, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(664, 1440, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(731, 1456, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(791, 1556, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(846, 1587, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(818, 1474, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(751, 1401, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(829, 1428, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(901, 1453, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(850, 1522, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(958, 1590, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(985, 1546, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(921, 1516, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(975, 1494, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(950, 1438, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(998, 1338, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(960, 1280, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(986, 1242, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(922, 1192, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(984, 1201, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(958, 1301, 25));

		// 'Saltisdaughter_Mage' GenType 27 Spawn Points
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(144, 695, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(280, 316, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(331, -385, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(149, 1156, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(267, 1566, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(182, 1314, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(263, -24, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-273, -38, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(0, -311, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(443, -42, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(657, 1497, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(911, 1312, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-659, -219, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(907, 1599, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(240, -180, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-360, -1073, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-630, -921, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1297, -1041, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1195, -728, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1134, -380, 40));

		// 'Rootcrystal_01' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(881, -383, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(314, -263, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(175, 497, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-148, -37, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1184, 1279, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1013, 1124, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-795, 558, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-670, 400, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1261, 440, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-622, -159, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-735, -944, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-359, -1026, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-177, -966, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1256, -1073, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1179, -778, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1202, -370, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(192, 1120, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(246, 1329, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(218, 1562, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(635, 1506, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(859, 1454, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(377, -1130, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(434, -925, 100));

		// 'Saltisdaughter_Mage' GenType 1002 Spawn Points
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-467, -1087, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(177, -224, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(323, 1311, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(588, 1342, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-697, -984, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-271, -908, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(338, -448, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(482, -41, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(98, 1124, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(151, 1536, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(601, 1595, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(952, 1367, 40));
	}
}
