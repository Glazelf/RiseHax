using System;

namespace RiseHax.Hunter
{
    public static class DataOffsets
    {
        // None of these seem to be static wtf i hate demos
        public const uint OffsetHunterHP = 0x001DFC86FC;
        // Might just be Pouch slot 2(?)
        public const uint OffsetMegaPotion = 0x001D00BD54;

        public const string PointerHunterHP = "[[[[main+CD7AB00]+28]+390]+20]+10";
    }
}
