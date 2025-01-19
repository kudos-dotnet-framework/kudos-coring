using System;
using System.Collections;
using System.Reflection;
using Kudos.Coring.Constants;
using Kudos.Coring.Reflection.Utils;

namespace Kudos.Coring.Utils.Collections
{
    public static class CollectionUtils
    {
        #region public static Boolean IsValidIndex(...)

        public static Boolean IsValidIndex(ICollection? o, Int32 i)
        {
            return
                o != null
                && i > -1
                && i < o.Count;
        }

        #endregion

        #region public static Type? GetArgumentType(...)

        public static Type? GetArgumentType(ICollection? o) { return GetArgumentType(TypeUtils.Get(o)); }
        public static Type? GetArgumentType<T>() { return GetArgumentType(typeof(T)); }
        public static Type? GetArgumentType(Type? t)
        {
            Type? t0 = ArrayUtils.GetArgumentType(t);
            if(t0 == null) t0 = ListUtils.GetArgumentType(t);
            return t0;
        }

        #endregion
    }
}