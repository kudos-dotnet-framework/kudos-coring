using System;
using System.Collections;
using Kudos.Coring.Types;

namespace Kudos.Coring.Utils.Collections
{
    public static class CollectionUtils
    {
        #region public static Boolean IsValidIndex(...)

        public static Boolean IsValidIndex(ICollection? o, Int32 i) { return o != null && i > -1 && i < o.Count; }

        #endregion

        #region public static Type? GetArgumentType(...)

        public static Type? GetArgumentType(ICollection? o) { return GetArgumentType(TypeUtils.Get(o)); }
        public static Type? GetArgumentType<T>() { return GetArgumentType(fastTypeOf<T>.Value); }
        public static Type? GetArgumentType(Type? t)
        {
            Type? t0 = ArrayUtils.GetArgumentType(t);
            if(t0 == null) t0 = ListUtils.GetArgumentType(t);
            return t0;
        }

        #endregion
    }
}