using Kudos.Coring.Enums;

namespace Kudos.Coring.Constants
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    internal static class CCharType
	{
        internal static ECharType
            Standard = ECharType.StandardUpperCase | ECharType.StandardLowerCase,
            Numeric = ECharType.Numeric,
            StandardNumeric = Standard | Numeric;
    }
}

