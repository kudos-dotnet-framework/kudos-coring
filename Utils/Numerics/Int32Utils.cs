﻿using System;

namespace Kudos.Coring.Utils.Numerics
{
    public static class Int32Utils
    {
        private static readonly Random __rnd;

        static Int32Utils() { __rnd = new Random(); }

        #region Random

        public static Int32 Random(Int32 iMax)
        {
            return Random(iMax, iMax);
        }

        public static Int32 Random(Int32 iMin, Int32 iMax)
        {
            return
                iMin == iMax
                    ? __rnd.Next(iMin + 1)
                    :
                        iMax > iMin
                            ? __rnd.Next(iMin, iMax + 1)
                            : __rnd.Next(iMax, iMin + 1)
                    ;
        }

        #endregion

        public static Int32? Parse(String? s) { Int32 i; return Int32.TryParse(s, out i) ? i : null; }
        public static Int32? Parse(Object? o) { return ObjectUtils.Parse<Int32?>(o); }
        public static Int32 NNParse(Object? o) { return ObjectUtils.Parse<Int32>(o); }
    }
}