using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public class Utility
    {
        public static void EnableControl(Control control, bool isEnable)
        {
            foreach (Control ctrl in control.Controls)
            {
                switch (ctrl)
                {
                    case TextBox txt:
                    case DateTimePicker dtPicker:
                        ctrl.Enabled = isEnable;
                        break;
                }
            }
        }

        public static bool RecordExists(DataRowCollection rows, string key1, string key2 = null)
        {
            if(rows == null || rows.Count == 0) return false;

            foreach (DataRow row in rows)
            {
                if (row.ItemArray[0].ToString().Trim().Equals(key1))
                {
                    if(key2 != null && row.ItemArray[1].ToString().Trim().Equals(key2))
                    {
                        return true;
                    }
                    return true;
                }
            }
            return false;
        }

        public static void FocusRowById(string id, DataGridView grid)
        {
            if (grid.Rows.Count == 0) return;
            for(int i = 0;i<grid.Rows.Count;i++)
            {
                if (grid.Rows[i].Cells[0].Value.ToString().Trim().Equals(id))
                {
                    grid.Rows[i].Selected = true;
                    return;
                }
            }
        }

        public static DataGridViewColumn GetColumn(DataGridView grid, string columnName)
        {
            if (columnName == null) return null;
            foreach(DataGridViewColumn column in grid.Columns)
            {
                if(column.HeaderText.Equals(columnName)) 
                    return column;
            }
            return null;
        }

        public static bool Validate(object obj)
        {
            var tmp = obj.ToString();
            foreach(char c in tmp)
            {
                if(!char.IsDigit(c)) 
                    return false;
            }
            return true;
        }

        public static DataRow GetDataById(DataRowCollection rows, string id)
        {
            if(rows.Count == 0) return null;
            foreach(DataRow row in rows)
            {
                if (row.ItemArray[0].ToString().Trim().Equals(id)) 
                    return row;
            }
            return null;
        }
    }
}
