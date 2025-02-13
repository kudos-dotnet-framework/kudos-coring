﻿using System;
namespace Kudos.Coring.Utils.Numerics
{
    public static class Int128Utils
    {
        public static Int128? Parse(String? s) { Int128 i; return Int128.TryParse(s, out i) ? i : null; }
        public static Int128? Parse(Object? o) { return ObjectUtils.Parse<Int128?>(o); }
        public static Int128 NNParse(Object? o) { return ObjectUtils.Parse<Int128>(o); }
    }
}
