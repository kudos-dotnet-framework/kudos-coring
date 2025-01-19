using System;
using System.Collections.Generic;
using System.Data;
using Kudos.Coring.Utils.Collections;

namespace Kudos.Coring.Types
{
	public class FastDataRowCollection
	{
        private FastDataTable _fdt;
        public readonly FastDataTable Table;
        private readonly DataRowCollection _drc;

        public Int32 Count { get { return _drc.Count; } }

        public FastDataRow? this[Int32 i] { get { return new FastDataRow(ref _fdt, DataRowCollectionUtils.GetRow(_drc, i)); } }
        public FastDataRow? GetFirst() { return new FastDataRow(ref _fdt, DataRowCollectionUtils.GetFirstRow(_drc)); }
        public FastDataRow? GetLast() { return new FastDataRow(ref _fdt, DataRowCollectionUtils.GetLastRow(_drc)); }

        internal FastDataRowCollection(ref FastDataTable fdt, ref DataTable dt)
        {
            Table = _fdt= fdt;
            _drc = dt.Rows;
        }
    }
}

