using System;

namespace Kudos.Coring.Utils.Numerics
{
    public static class SingleUtils
    {
        public static Single? Parse(Object? o) { return ObjectUtils.Parse<Single?>(o); }
        public static Single NNParse(Object? o) { return ObjectUtils.Parse<Single>(o); }
    }
}