using System;
using System.Collections.Generic;

namespace Kudos.Coring.Utils.Collections
{
	public static class QueueUtils
	{
		public static Boolean TryDequeue<R>(Queue<R?>? q, out R? o)
		{
			if (q != null)
				try { return q.TryDequeue(out o); } catch { }

			o = default(R);
			return false;
		}

        public static R? Dequeue<R>(Queue<R?>? q)
        {
			R? o; TryDequeue<R>(q, out o);
			return o;
        }

        public static Boolean Enqueue<R>(Queue<R?>? q, R? o)
        {
            if (q != null)
                try { q.Enqueue(o); return true; } catch { }

            o = default(R);
            return false;
        }
    }
}

