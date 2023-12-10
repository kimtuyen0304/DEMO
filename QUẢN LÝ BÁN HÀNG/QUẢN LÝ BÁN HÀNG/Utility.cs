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

        public static bool RecordExists(string primaryKey)
        {
            return YourDatabaseCheckIfRecordExists(primaryKey);
        }

        public static bool YourDatabaseCheckIfRecordExists(string primaryKey)
        {
            return false;
        }
    }
}
