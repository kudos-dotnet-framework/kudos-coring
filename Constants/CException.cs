using System;
namespace Kudos.Coring.Constants
{
	public static class CException
	{
		public static readonly Exception
            ArgumentException,
            ArgumentOutOfRangeException,
            ArgumentNullException;

		static CException()
		{
			ArgumentException = new ArgumentException();
            ArgumentOutOfRangeException = new ArgumentOutOfRangeException();
			ArgumentNullException = new ArgumentNullException();
		}
	}
}

