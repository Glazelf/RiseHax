namespace RiseHax.Hunter
{
    public static class DataOffsets
    {
        /// <summary>
        /// Pointers
        /// </summary>
        //////////////////////////// Updated pointers (10.0.3):
        
        //////////////////////////// Outdated pointers:
        // General
        public const string PointerZeni = "[heap+001DEE5428]"; // Notes: Max 999.999.999?
        public const string PointerPoints = "[heap+1DEDB390]"; // Notes: Max 999.999.999?
        // Still need to add code for these
        public const string PointerDangoTickets = "[heap+1D95BC94]"; // Notes: Max 9999?
        //// Quest
        // Max HP at +0x
        public const string PointerHunterHP = "[[[[[main+D5F9DF0]+448]+140]+A0]+118]+10";
        // Coords directly follow eachother
        public const string PointerHunterCoordX = "[[[[main+CDBBF88]+A0]+18]+30";
        // SHOULD work for all quests with 3 monsters but not widely tested
        public const string PointerMonsters3HP = "[[[main+CD776B0]+50]+280]+170";
        // Doubles as Village Quest pointer
        public const string PointerActivityLog = "[[main+D96F848]+70]+80";
        public const string PointerPouchItem1 = "[[[[main+D9674B8]+78]+18]+40]+10";
        // Add 0x8 to the second to last number to get the next item.
        public const string PointerLayeredArmor = "[[[[[main+0D9674B8]+D8]+10]+10]+20]+20";
        public const string PointerLayeredArmorBuddies = "[[[[[main+0D9674B8]+D0]+28]+10]+20]+10";

        /// <summary>
        /// Distances
        /// </summary>
        // HP
        public const int DistanceHPToRecoverable = 0xC;
        public const int DistanceHPToHPMax = 0x4;
        // Item Pouch
        public const int DistanceItemPouchTypeToCount = 0x4;
        public const int DistanceItemPouchCounts = 0x60;
        // Coordinates
        public const int DistanceCoordinates = 0x4;
        // Activity Log
        public const int DistancePlaytime = -0x3C;
        public const int DistanceActivityLog = 0x4;
        public const int DistanceSlainTotal = 0x24;
        public const int DistanceCapturedTotal = DistanceSlainTotal + DistanceActivityLog;
    }
}
