using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using Kudos.Coring.Utils.Collections;
using Kudos.Coring.Utils.Datas;

namespace Kudos.Coring.Types
{
    public class FastDataRow
    {
        private readonly FastDataTable _fdt;
        private readonly DataRow _dr;

        public object? this[int i] { get { return _fdt.Columns.IsValidIndex(i) ? DataRowUtils.NormalizeValue(_dr.ItemArray[i]) : null; } }
        public object? this[String? s] { get { Int32? i = _fdt.Columns.GetIndex(s); return i != null ? DataRowUtils.NormalizeValue(_dr.ItemArray[i.Value]) : null; } }

        internal FastDataRow(ref FastDataTable fdt, DataRow dr)
        {
            _fdt = fdt;
            _dr = dr;
        }
    }
}