using System;

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
    }
}
