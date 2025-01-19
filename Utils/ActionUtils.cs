using System;
using Kudos.Coring.Constants;

namespace Kudos.Coring.Utils
{
	public static class ActionUtils
	{
        //#region ... static ...

        //private static readonly String
        //    __sActionFullName;

        //static ActionUtils()
        //{
        //    __sActionFullName = CType.Action.FullName;
        //}

        //#endregion

        #region public static Action? Cast(...)

        public static Action? Cast(Object? o) { return o as Action; }
        public static Action<I0>? Cast<I0>(Object? o) { return o as Action<I0>; }
        public static Action<I0,I1>? Cast<I0,I1>(Object? o) { return o as Action<I0,I1>; }
        public static Action<I0,I1,I2>? Cast<I0,I1,I2>(Object? o) { return o as Action<I0,I1,I2>; }
        public static Action<I0,I1,I2,I3>? Cast<I0,I1,I2,I3>(Object? o) { return o as Action<I0,I1,I2,I3>; }

        #endregion

        #region public static Boolean Is(...)

        public static Boolean Is(Object? o) { return Is(TypeUtils.Get(o)); }
        public static Boolean Is(Type? t) { return ObjectUtils.IsSubclass(t, CType.Action); }
        //{
        //    return
        //        t != null
        //        &&
        //        (
        //            t == CType.Action
        //            ||
        //            (
        //                t.FullName != null
        //                && t.FullName.Contains(__sActionFullName, StringComparison.OrdinalIgnoreCase)
        //            )
        //        );
        //}

        #endregion

        #region public static Boolean Invoke(...)

        public static Boolean Invoke(Action? act)
        {
            if (act != null) try { act.Invoke(); return true; } catch { }
            return false;
        }

        public static Boolean Invoke<I0>(Action<I0>? act, I0? o0)
        {
            if (act != null) try { act.Invoke(o0); return true; } catch { }
            return false;
        }

        public static Boolean Invoke<I0,I1>(Action<I0,I1>? act, I0? o0, I1? o1)
        {
            if (act != null) try { act.Invoke(o0,o1); return true; } catch { }
            return false;
        }

        public static Boolean Invoke<I0,I1,I2>(Action<I0,I1,I2>? act, I0? o0, I1? o1, I2? o2)
        {
            if (act != null) try { act.Invoke(o0,o1,o2); return true; } catch { }
            return false;
        }

        public static Boolean Invoke<I0,I1,I2,I3>(Action<I0,I1,I2,I3>? act, I0? o0, I1? o1, I2? o2, I3? o3)
        {
            if (act != null) try { act.Invoke(o0,o1,o2,o3); return true; } catch { }
            return false;
        }

        public static Boolean DynamicInvoke(Action? act, params Object?[]? o)
        {
            if (act != null) try { act.DynamicInvoke(o); return true; } catch { }
            return false;
        }

        public static Boolean DynamicInvoke(Object? act, params Object?[]? oa)
        {
            if (!Is(act)) return false;
            DelegateUtils.DynamicInvoke(act, oa);
            return true;
        }

        #endregion
    }
}

