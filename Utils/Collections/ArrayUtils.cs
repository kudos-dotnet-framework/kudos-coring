using System;
using System.Collections.Generic;
using Kudos.Coring.Reflecting.Utils;
using Kudos.Coring.Types;

namespace Kudos.Coring.Utils.Collections
{
    public static class ArrayUtils
    {
        #region Cast(...)

        public static T[]? Cast<T>(Object? o) { return o as T[]; }
        public static Array? Cast(Object? o) { return o as Array; }

        #endregion

        #region CreateInstance<...>(...)

        public static T?[]? CreateInstance<T>(int i) { return CreateInstance(fastTypeOf<T>.Value, i) as T?[]; }
        //public static Object[]? CreateInstance(Type? t, int i) { if (t != null && i > -1) try { return Array.CreateInstance(t, i) as Object[]; } catch { } return null; }
        public static Array? CreateInstance(Type? t, int i) { if (t != null && i > -1) try { return Array.CreateInstance(t, i);  } catch { } return null; }

        #endregion

        #region SetValue<...>(...)

        public static Boolean SetValue<T>(T?[]? a, T? v, int i) { if (IsValidIndex(a, i)) try { a[i] = v; return true; } catch { } return false; }
        public static Boolean SetValue(Array? a, Object? v, int i) { if (IsValidIndex(a, i)) try { a.SetValue(v, i); return true; } catch { } return false; }

        #endregion

        #region RemoveNullEntries()

        public static T[]? RemoveNullEntries<T>(T?[]? oa)
        {
            return ObjectUtils.Cast<T[]>(RemoveNullEntries(oa as Object?[]));
        }
        public static Object[]? RemoveNullEntries(Object?[]? oa)
        {
            if (oa == null || oa.Length < 1) return null;

            List<Object> lo = new List<object>(oa.Length);

            for (int i = 0; i < oa.Length; i++)
            {
                if (oa[i] == null) continue;
                lo.Add(oa[i]);
            }

            return lo.ToArray();
        }

        #endregion

        #region GetValue(...)

        public static T? GetFirstValue<T>(Array? a) { return ObjectUtils.Cast<T>(GetFirstValue(a)); }
        public static Object? GetFirstValue(Array? a) { return GetValue(a, 0); }
        public static T? GetLastValue<T>(Array? a) { return ObjectUtils.Cast<T>(GetLastValue(a)); }
        public static Object? GetLastValue(Array? a) { return a != null ? GetValue(a, a.Length - 1) : null; }
        public static T? GetValue<T>(Array? a, int i) { return ObjectUtils.Cast<T>(GetValue(a, i)); }
        public static Object? GetValue(Array? a, int i) { return IsValidIndex(a, i) ? a.GetValue(i) : null; }

        #endregion

        #region Shift(...)

        public static T? Shift<T>(T[]? a0, out T[]? a1)
        {
            if (a0 == null || a0.Length < 1)
            {
                a1 = null;
                return default(T?);
            }

            a1 = new T[a0.Length - 1];

            if (a1.Length > 0)
                Array.Copy(a0, 1, a1, 0, a1.Length);

            return a0[0];
        }

        #endregion

        #region public static T?[] UnShift(...)

        public static T?[] UnShift<T>(T? o, T?[]? a)
        {
            int i = a != null ? a.Length : 0;

            T?[] a1 = new T[1 + i];
            a1[0] = o;

            if (i > 0)
                Array.Copy(a, 0, a1, 1, a.Length);

            return a1;
        }

        #endregion

        #region public static ... Append<...>(...)

        private static void _ToArray(ref Type? t, ref Object? o, out Array? a)
        {
            //if(!ObjectUtils.IsInstance(o, t)) { a = null; return; }
            a = o as Array;
            if (a != null) return;
            a = CreateInstance(t, 1); SetValue(a, o, 0);
        }

        public static T?[]? Append<T>(T? o0, T? o1) { return Append(fastTypeOf<T>.Value, o0, o1) as T?[]; }
        public static T?[]? Append<T>(T? o0, T?[]? a1) { return Append(fastTypeOf<T>.Value, o0, a1) as T?[]; }
        public static T?[]? Append<T>(T?[]? a0, T? o1) { return Append(fastTypeOf<T>.Value, a0, o1) as T?[]; }
        public static T?[]? Append<T>(T?[]? a0, T?[]? a1) { return Append(fastTypeOf<T>.Value, a0, a1) as T?[]; }
        public static Array? Append(Type? t, Object? o0, Array? a1)
        {
            Array? a0; _ToArray(ref t, ref o0, out a0);
            return Append(t, a0, a1);
        }
        public static Array? Append(Type? t, Array? a0, Object? o1)
        {
            Array? a1; _ToArray(ref t, ref o1, out a1);
            return Append(t, a0, a1);
        }
        public static Array? Append(Type? t, Object? o0, Object? o1)
        {
            Array? a0; _ToArray(ref t, ref o0, out a0);
            Array? a1; _ToArray(ref t, ref o1, out a1);
            return Append(t, a0, a1);
        }
        public static Array? Append(Type? t, Array? a0, Array? a1)
        {
            Type?
                t0 = GetArgumentType(a0),
                t1 = GetArgumentType(a1);

            if
            (
                t == null
                || (a0 != null && t0 != t)
                || (a1 != null && t1 != t)
            )
                return null;
            else if(a1 == null)
                return a0;
            else if(a0 == null)
                return a1;

            Array
                a = CreateInstance(t, a0.Length + a1.Length);

            Array.Copy(
                a0,
                0,
                a,
                0,
                a0.Length
            );

            Array.Copy(
                a1,
                0,
                a,
                a0.Length,
                a1.Length
            );

            return a;
        }

        #endregion

        #region public static T[]? Prepend<T>(...)

        public static Byte[]? Prepend(Byte[]? ta0, Byte[]? ta1)
        {
            return Append(ta1, ta0);
        }

        #endregion

        #region public static Boolean IsValidIndex(...)

        public static Boolean IsValidIndex<T>(T[]? oa, Int32 i) { return CollectionUtils.IsValidIndex(oa, i); }
        public static Boolean IsValidIndex(Array? o, Int32 i) { return CollectionUtils.IsValidIndex(o, i); }

        #endregion

        #region public static void Split<T>(...)

        public static void Split<T>(T[]? tai, int i, out T[]? tao0, out T[]? tao1)
        {
            if (!IsValidIndex(tai, i))
            {
                tao0 = null;
                tao1 = tai;
                return;
            }

            tao0 = new T[i];
            tao1 = new T[tai.Length - i];

            Array.Copy(tai, 0, tao0, 0, tao0.Length);
            Array.Copy(tai, i, tao1, 0, tao1.Length);
        }

        #endregion

        #region public static Type? GetArgumentType(...)

        public static Type? GetArgumentType(Array? o) { return GetArgumentType(TypeUtils.Get(o)); }
        public static Type? GetArgumentType(Type? t)
        {
            return
                Is(t)
                    ? ReflectionUtils.GetMemberValueType(ReflectionUtils.GetMethod(t, "Get"))
                    : null;
        }

        #endregion

        #region public static Boolean Is(...)

        public static Boolean Is(Object? o) { return TypeUtils.IsArray(o); }
        public static Boolean Is(Type? t) { return TypeUtils.IsArray(t); }

        #endregion
    }
}
