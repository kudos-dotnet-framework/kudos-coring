using System.Reflection;

namespace Kudos.Coring.Constants
{
    /// <author>
    /// Pietro Terracciano
    /// https://it.linkedin.com/in/pietroterracciano
    /// pterracciano95@gmail.com
    /// </author>
    public static class CBindingFlags
    {
        public const BindingFlags
            PublicInstance = BindingFlags.Public | BindingFlags.Instance,       //Public|Instance
            PublicStatic = BindingFlags.Public | BindingFlags.Static,           //Public|Static
            Public = PublicInstance | PublicStatic,                             //Public|Instance
            NonPublicInstance = BindingFlags.NonPublic | BindingFlags.Instance, //NonPublic|Instance
            NonPublicStatic = BindingFlags.NonPublic | BindingFlags.Static,     //NonPublic|Static
            NonPublic = NonPublicInstance | NonPublicStatic,                    //NonPublic|Static|Instance
            Instance = PublicInstance | NonPublicInstance,                      //Public|NonPublic|Instance
            All = Public | NonPublic;                                           //Public|NonPublic|Static|Instance
    }
}