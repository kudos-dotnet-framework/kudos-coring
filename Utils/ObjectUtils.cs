using System;
using Kudos.Coring.Reflecting.Utils;

namespace Kudos.Coring.Utils
{
    public abstract class ObjectUtils
    {
        #region public static ... Cast<...>(...)

        public static T? Cast<T>(Object? o) { return IsInstance<T>(o) ? (T?)o : default(T?); }
        public static Object? Cast(Object? o, Type? tOf) { return IsInstance(o, tOf) ? o : null; }

        #endregion

        #region public static Object? Parse(...)

        public static T? Parse<T>(Object? o, Boolean bForceNotNullable = false) { return Cast<T>(Parse(typeof(T), o, bForceNotNullable)); }
        public static Object? Parse(Type? t, Object? o, Boolean bForceNotNullable = false)
        {
            if (t == null)
                return null;

            Type? 
                t0 = Nullable.GetUnderlyingType(t);

            if (t0 != null)
                t = t0;

            if (o != null)
            {
                if (t.Equals(o.GetType())) return o;
                else if (t.IsEnum) return EnumUtils.Parse(t, o);
                else try { return Convert.ChangeType(o, t); } catch { }
            }

            Boolean
                bIsNullable = !bForceNotNullable && (!t.IsValueType || t0 != null);

            return !bIsNullable ? ReflectionUtils.CreateInstance(t) : o;
        }

        #endregion

        #region public static Boolean IsInstance<...>(...)

        public static Boolean IsInstance<T>(Object? o) { return IsInstance(o, typeof(T)); }
        public static Boolean IsInstance(Object? o, Type? tOf) { return tOf != null && tOf.IsInstanceOfType(o); }

        #endregion

        #region public static Boolean IsSubclass(...)

        public static Boolean IsSubclass(Type? tSubclass, Type? tClass, Boolean bOrEquals = true)
        {
            return
                tSubclass != null
                && tClass != null
                &&
                (
                    (
                        bOrEquals
                        && tSubclass == tClass
                    )
                    || tSubclass.IsSubclassOf(tClass)
                );
        }

        #endregion

        #region public static ... ChangeType<...>(...)

        public static T? ChangeType<T>(Object? o) { return Cast<T>(ChangeType(typeof(T), o)); }
        public static Object? ChangeType(Type? t, Object? o)
        {
            if (t == null || o == null)
                return null;

            Type
                to = o.GetType();

            if (to.Equals(t))
                return o;

            Type?
                t0 = TypeUtils.GetUnderlying(t);

            if (t0 != null)
            {
                t = t0;
                if (to.Equals(t))
                    return o;
            }

            if (t.IsEnum) return EnumUtils.Parse(t, o);
            else try { return Convert.ChangeType(o, t); } catch { }

            return null;
        }

        #endregion
    }
}