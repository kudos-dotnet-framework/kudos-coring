using System;
using Kudos.Coring.Constants;

namespace Kudos.Coring.Types
{
	public sealed class SmartResult<V>
	{
		#region ... static ...

		public static readonly SmartResult<V>
            ArgumentException,
            ArgumentNullException,
			ArgumentOutOfRangeException;


        static SmartResult()
        {
            ArgumentException = new SmartResult<V>(CException.ArgumentException);
            ArgumentNullException = new SmartResult<V>(CException.ArgumentNullException);
            ArgumentOutOfRangeException = new SmartResult<V>(CException.ArgumentOutOfRangeException);
        }

        #endregion

        public readonly Exception? Exception;
		public readonly V Value;
		public readonly Boolean HasValue, HasException;

		public SmartResult(V v) : this(null, v) { }
        public SmartResult(Exception? exc) : this(exc, default) { }
        public SmartResult(Exception? exc, V v)
		{
            HasException = (Exception = exc) != null;
            HasValue = (Value = v) != null;
		}
	}
}