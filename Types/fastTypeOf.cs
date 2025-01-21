using System;
namespace Kudos.Coring.Types
{
    public static class fastTypeOf<T>
    {
        public static readonly Type Value;
        static fastTypeOf() { Value = typeof(T); }
    }
}