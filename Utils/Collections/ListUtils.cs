using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kudos.Coring.Constants;
using Kudos.Coring.Reflection.Utils;

namespace Kudos.Coring.Utils.Collections
{
    public static class ListUtils
    {
        #region public static Boolean IsValidIndex(...)

        public static Boolean IsValidIndex<T>(List<T>? l, Int32 i) { return CollectionUtils.IsValidIndex(l, i); }

        #endregion

        #region public static T? Get(...)

        public static T? Get<T>(List<T>? l, Int32 i)
        {
            return IsValidIndex(l, i) ? l[i] : default(T);
        }

        #endregion

        #region public static Boolean Add(...)

        public static Boolean Add<T>(IList<T> l, T o)
        {
            if (l != null)
                try { l.Add(o); return true; } catch { }

            return false;
        }

        #endregion

        #region public static Type? GetArgumentType(...)

        public static Type? GetArgumentType(IList? l) { return GetArgumentType(TypeUtils.Get(l)); }
        public static Type? GetArgumentType<T>(IList<T>? l) { return GetArgumentType(TypeUtils.Get(l)); }
        public static Type? GetArgumentType<T>() where T : IList { return GetArgumentType(typeof(T)); }
        public static Type? GetArgumentType(Type? t)
        {
            return
                Is(t)
                    ? ArrayUtils.GetFirstValue<Type>(TypeUtils.GetGenericArguments(t))
                    : null;
        }

        #endregion

        #region public static Boolean Is(...)

        public static Boolean Is(Object? o) { return Is(TypeUtils.Get(o)); }
        public static Boolean Is(Type? t) { return ReflectionUtils.GetInterface(t, CInterface.IList) != null; }

        #endregion

        #region public static List<T>? CreateInstance

        public static List<T> CreateInstance<T>()
        {
            return CreateInstance(typeof(T)) as List<T>;
        }
        public static IList? CreateInstance(Type? t)
        {
            return ReflectionUtils.CreateInstance(ReflectionUtils.MakeGenericType(CType.List, t)) as IList;
        }

        #endregion
    }
}