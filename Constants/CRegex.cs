using System.Text.RegularExpressions;

namespace Kudos.Coring.Constants
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    public static class CRegex
	{
		public static readonly Regex
			Spaces1toN;

		static CRegex()
		{
			Spaces1toN = new Regex(@"\s{1,}");
		}
	}
}

