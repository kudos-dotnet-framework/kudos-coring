using System;
using Kudos.Coring.Constants;

namespace Kudos.Coring.Utils
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    public static class DelegateUtils
	{
        #region public static Delegate? Cast(...)

        public static Delegate? Cast(Object? o) { return o as Delegate; }

        #endregion

        #region public static Boolean Is(...)

        public static Boolean Is(Object? o) { return Is(TypeUtils.Get(o)); }
        public static Boolean Is(Type? t) { return ObjectUtils.IsSubclass(t, CType.Delegate); }

        #endregion

        #region public static Boolean DynamicInvoke(...)

        public static Object? DynamicInvoke(Object? o, params Object?[]? oa) { return DynamicInvoke(Cast(o), oa); }
        public static Object? DynamicInvoke(Delegate? dlg, params Object?[]? oa)
        {
            if (dlg != null) try { return dlg.DynamicInvoke(oa); } catch { }
            return null;
        }

        #endregion
    }
}

