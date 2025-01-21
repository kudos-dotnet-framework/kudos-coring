using System;
using Kudos.Coring.Constants;
using Kudos.Coring.Utils.Collections;

namespace Kudos.Coring.Utils
{
    public static class TypeUtils
    {
        public static Type? Get(Object? o)
        {
            Type? t = o as Type;
            if (t != null) return t;
            return o != null ? o.GetType() : null;
        }

        #region public static Boolean IsPrimitive(...)

        public static Boolean IsPrimitive(Object? o) { return IsPrimitive(Get(o)); }
        public static Boolean IsPrimitive(Type? t) { return t != null && t.IsPrimitive; }

        #endregion

        #region public static Boolean IsGeneric(...)

        public static Boolean IsGeneric(Object? o) { return IsGeneric(Get(o)); }
        public static Boolean IsGeneric(Type? t) { return t != null && t.IsGenericType; }

        #endregion

        #region public static Boolean IsArray(...)

        public static Boolean IsArray(Object? o) { return IsArray(Get(o)); }
        public static Boolean IsArray(Type? t) { return t != null && t.IsArray; }

        #endregion

        #region public static Boolean IsNumeric(...)

        public static Boolean IsNumeric(Object? o) { return IsNumeric(Get(o)); }
        public static Boolean IsNumeric(Type? t)
        {
            return
                t != null
                &&
                (
                    t == CType.UInt16
                    || t == CType.NullableUInt16
                    || t == CType.UInt32
                    || t == CType.NullableUInt32
                    || t == CType.UInt64
                    || t == CType.NullableUInt64
                    || t == CType.UInt128
                    || t == CType.NullableUInt128
                    || t == CType.Int16
                    || t == CType.NullableInt16
                    || t == CType.Int32
                    || t == CType.NullableInt32
                    || t == CType.Int64
                    || t == CType.NullableInt64
                    || t == CType.Int128
                    || t == CType.NullableInt128
                    || t == CType.Single
                    || t == CType.NullableSingle
                    || t == CType.Double
                    || t == CType.NullableDouble
                    || t == CType.Decimal
                    || t == CType.NullableDecimal
                );
        }

        #endregion

        //public static Boolean IsList(Object? o) { return IsList(Get(o)); }
        //public static Boolean IsList(Type? t) { return ReflectionUtils.GetInterface(t, CInterface.IList) != null; }

        public static Type[]? GetGenericArguments(Object? o) { return GetGenericArguments(Get(o)); }
        public static Type[]? GetGenericArguments(Type? t)
        {
            if (IsGeneric(t)) try { return t.GetGenericArguments(); } catch { }
            return null;
        }

        public static Type? GetUnderlying(Object? o) { return GetUnderlying(Get(o)); }
        public static Type? GetUnderlying(Type? t)
        {
            return t != null ? Nullable.GetUnderlyingType(t) : null;
        }

        public static Type[]? GetArguments(Object? o) { return GetArguments(Get(o)); }
        public static Type[]? GetArguments(Type? t)
        {
            Type? t0 = CollectionUtils.GetArgumentType(t);
            return
                t0 != null
                    ? new Type[] { t0 }
                    : GetGenericArguments(t);
        }
    }
}