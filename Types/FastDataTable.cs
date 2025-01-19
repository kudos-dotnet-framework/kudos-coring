using System;
using Kudos.Coring.Utils.Collections;
using System.Collections.Generic;
using System.Data;
using Kudos.Coring.Utils.Datas;

namespace Kudos.Coring.Types
{
    public class FastDataTable
    {
        private readonly FastDataTable _this;
        public readonly FastDataColumnCollection Columns;
        public readonly FastDataRowCollection Rows;

        //public DataRow? GetRow(Int32 i) { return DataTableUtils.GetRow(_dt, i); }
        //public DataRow? GetFirstRow() { return DataTableUtils.GetFirstRow(_dt); }
        //public DataRow? GetLastRow() { return DataTableUtils.GetLastRow(_dt); }

        //public DataColumn? GetColumn(Int32 i) { return DataTableUtils.GetColumn(_dt, i); }
        //public DataColumn? GetFirstColumn() { return DataTableUtils.GetFirstColumn(_dt); }
        //public DataColumn? GetLastColumn() { return DataTableUtils.GetLastColumn(_dt); }

        internal FastDataTable(DataTable dt)
        {
            _this = this;
            Rows = new FastDataRowCollection(ref _this, ref dt);
            Columns = new FastDataColumnCollection(ref _this, ref dt);
        }

        public static FastDataTable? New(DataTable? dt)
        {
            return dt != null ? new FastDataTable(dt) : null;
        }
    }
}