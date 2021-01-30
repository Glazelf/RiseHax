namespace RiseHax.Hunter
{
    public static class DataOffsets
    {
        // Offsets --> Use .ReadBytes()
        // None of these seem to be static wtf i hate demos
        public const uint OffsetHunterHP = 0x001DFC86FC;
        // Might just be Pouch slot 2(?)
        public const uint OffsetMegaPotion = 0x001D00BD54;

        // Pointers --> Use .ReadBytesAbsolute()
        public const string PointerHunterHP = "[[[main+CD73FA0]+390]+20]+10";
        public const string PointerHunterHPRecoverable = "[[[main+CD76310]+D0]+118]+1C";
        // Coords are directly after eachother, 4 bytes each so add 0x4 to get the next coord
        public const string PointerHunterCoordX = "[[[main+CDBBF88]+A0]+18]+30";
        // Item counts follow eachother, ad 0x08 to get the next item
        public const string PointerPouchItem1 = "[[[main+CD7A060]+68]+70]+44";
        // Would preferably get all offsets from just the first item pointer
        public const string PointerPouchItem2 = "[[[main+CD7A060]+68]+78]+44";
        public const string PointerPouchItem3 = "[[[main+CD7A060]+68]+80]+44";
        public const string PointerPouchItem4 = "[[[main+CD7A060]+68]+88]+44";
        public const string PointerPouchItem5 = "[[[main+CD7A060]+68]+90]+44";
    }
}
