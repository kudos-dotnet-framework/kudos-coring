using System;
using System.Collections.Generic;
using Kudos.Coring.Constants;
using Kudos.Coring.Types;

namespace Kudos.Coring.Utils.Collections
{
	public static class QueueUtils
	{
		public static SmartResult<Boolean?> TryDequeue<R>(Queue<R?>? q, out R? o)
		{
            if (q == null) { o = default; return SmartResult<Boolean?>.ArgumentNullException; }
            try { return new SmartResult<bool?>(q.TryDequeue(out o)); }
            catch (Exception exc) { o = default; return new SmartResult<bool?>(exc); }
		}

        public static SmartResult<R?> Dequeue<R>(Queue<R?>? q)
        {
            R? o;

            SmartResult<Boolean?>
                sr = TryDequeue<R>(q, out o);

            return
                sr.Exception == null
                    ? new SmartResult<R?>(o)
                    : new SmartResult<R?>(sr.Exception);
        }

        public static Exception? Enqueue<R>(Queue<R?>? q, R? o)
        {
            if (q == null) return CException.ArgumentNullException;
            try { q.Enqueue(o); return null; }
            catch (Exception exc) { return exc; }
        }
    }
}