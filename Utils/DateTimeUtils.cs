using System;

namespace Kudos.Coring.Utils
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    public static class DateTimeUtils
    {
        #region public static DateTime GetOrigin(...)

        public static DateTime GetOrigin() { return GetOrigin(DateTimeKind.Utc); }
        public static DateTime GetOrigin(DateTimeKind dtk) { return new DateTime(1970, 1, 1, 0, 0, 0, 0, dtk); }

        #endregion

        #region public static DateTime GetCurrent(...)

        public static DateTime GetCurrent() { return GetCurrent(DateTimeKind.Utc); }
        public static DateTime GetCurrent(DateTimeKind dtk)
        {
            return
                dtk == DateTimeKind.Local
                    ? DateTime.Now.ToLocalTime()
                    : DateTime.Now.ToUniversalTime();
        }

        #endregion
    }
}