using System;
namespace Kudos.Coring.Utils
{
	public static class ByteUtils
	{
        public static Byte? Parse(Object? o) { return ObjectUtils.Parse<Byte?>(o); }
        public static Byte NNParse(Object? o) { return ObjectUtils.Parse<Byte>(o); }
    }
}

