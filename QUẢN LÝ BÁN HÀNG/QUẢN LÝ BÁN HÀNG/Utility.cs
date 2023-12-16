using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.DirectoryServices;

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

        public static bool RecordExists(string table, string column1, string key1, string column2 = null, string key2 = null)
        {
            var dt = new DataTable();
            var conn = GetConnection();
            var sql = $"SELECT * FROM {table} WHERE {column1}='{key1}'";
            if (column2 != null && key2 != null)
            {
                sql += $" AND {column2}='{key2}'";
            }
            conn.Open();
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt.Rows.Count > 0;
        }

        public static bool CheckExist(DataRowCollection rows, string key)
        {
            if (rows.Count == 0) return false;
            foreach (DataRow row in rows)
            {
                if (row.ItemArray[0].ToString().Trim() == key)
                    return true;
            }
            return false;
        }

        public static bool Validate(object obj)
        {
            var tmp = obj.ToString();
            foreach (char c in tmp)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static DataRow GetDataById(DataRowCollection rows, string id)
        {
            if (rows.Count == 0) return null;
            foreach (DataRow row in rows)
            {
                if (row.ItemArray[0].ToString().Trim().Equals(id))
                    return row;
            }
            return null;
        }

        public static SqlConnection GetConnection()
        {
            var connection =
                ConfigurationManager.ConnectionStrings["QUẢN_LÝ_BÁN_HÀNG.Properties.Settings._8___HuynhKimTuyen__QLBH_BBN_20DTK1ConnectionString"].ConnectionString;
            return new SqlConnection(connection);
        }

        public static string GetLastestBackup(string backupFolderPath)
        {
            if (string.IsNullOrEmpty(backupFolderPath) || !Directory.Exists(backupFolderPath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            var folders = Directory.GetDirectories(backupFolderPath).ToList();
            folders.Sort();
            return folders.Last();
        }

        public static void RestoreDatabase(string backupFolderPath, string oDatabaseName, string nDatabaseName)
        {
            var conn = new SqlConnection("Data Source=DUONG-NGUYEN\\MSSQLSERVER03;Initial Catalog=master;User ID=sa;Password=123");
            conn.Open();
            var dt = new DataTable();
            var sql = $"SELECT name FROM master.dbo.sysdatabases WHERE name = '{oDatabaseName}'";
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                sql = $"USE master DROP DATABASE IF EXISTS [{oDatabaseName}] RESTORE DATABASE [{oDatabaseName}] FROM DISK = " +
                $"'{GetLastestBackup(backupFolderPath)}/{nDatabaseName}'";
                cmd = new SqlCommand(sql.Replace('/', '\\'), conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static void AddDirectorySecurity(string DirectoryName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            DirectoryInfo dInfo = new DirectoryInfo(DirectoryName);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
