using System;
using System.Collections.Generic;
using System.Data;
using Kudos.Coring.Utils.Collections;

namespace Kudos.Coring.Types
{
	public sealed class FastDataColumnCollection
	{
        public readonly FastDataTable Table;

        private readonly Dictionary<String, Int32?> _ddcn2dci;
        private readonly Dictionary<Int32, DataColumn?> _ddci2dc;

        public DataColumn? this[Int32 i]
        {
            get
            {
                DataColumn? dc;
                _ddci2dc.TryGetValue(i, out dc);
                return dc;
            }
        }

        public DataColumn? this[String? s]
        {
            get
            {
                Int32? i = GetIndex(s);
                return i != null ? this[i.Value] : null;
            }
        }

        public Int32? GetIndex(DataColumn? dc)
        {
            return
                dc != null
                    ? GetIndex(dc.ColumnName)
                    : null;
        }

        public Int32? GetIndex(String? s)
        {
            if (s == null) return null;
            Int32? i; _ddcn2dci.TryGetValue(s, out i); return i;
        }

        public Boolean IsValidIndex(Int32 i)
        {
            return this[i] != null;
        }

        internal FastDataColumnCollection(ref FastDataTable fdt, ref DataTable dt)
        {
            Table = fdt;

            _ddcn2dci = new Dictionary<string, int?>(dt.Columns.Count);
            _ddci2dc = new Dictionary<int, DataColumn?>(dt.Columns.Count);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                _ddci2dc[i] = dt.Columns[i];
                _ddcn2dci[dt.Columns[i].ColumnName] = i;
            }
        }
    }
}

