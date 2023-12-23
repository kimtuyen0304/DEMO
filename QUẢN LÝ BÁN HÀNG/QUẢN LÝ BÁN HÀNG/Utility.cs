using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public class Utility
    {
        public class User
        {
            public string Id { get; set; }
            public int Role { get; set; }
        }

        public static User CurrentUser;

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

        public static DataTable Authenticate(string username, string password)
        {
            var dt = new DataTable();
            var conn = GetConnection();
            conn.Open();
            var sql = $"SELECT * FROM TaiKhoan WHERE TaiKhoan='{username}' AND MatKhau='{password}'";
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool CheckPermission(string tableName, string key, string id)
        {
            var dt = new DataTable();
            var conn = GetConnection();
            conn.Open();
            var sql = $"SELECT CreateBy FROM {tableName} WHERE {key}='{id}'";
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                if (CurrentUser.Role == 0)
                {
                    return true;
                }
                else
                {
                    if (dt.Rows[0].ItemArray[0].ToString().Trim().Equals(CurrentUser.Id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string ExecQuery(string sql)
        {
            try
            {
                var dt = new DataTable();
                var conn = GetConnection();
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0].ItemArray[0].ToString();
                }
            }
            catch (Exception) 
            {
                return string.Empty;
            }

            return string.Empty;
        }

        public static void CreateStoreProcedure()
        {
            try
            {
                var conn = GetConnection();
                conn.Open();
                var sql = new StringBuilder();
                sql.Append(" CREATE OR ALTER PROC GetDataReportHoaDon(@id nchar(10))");
                sql.Append(" AS");
                sql.Append(" BEGIN");
                sql.Append("    SELECT");
                sql.Append("        TenMH");
                sql.Append("       ,Soluong");
                sql.Append("       ,Gia");
                sql.Append("       ,VAT");
                sql.Append("       ,Thanhtien");
                sql.Append("       ,TenKH");
                sql.Append("       ,Diachi");
                sql.Append("       ,SDT");
                sql.Append("       ,ROW_NUMBER() OVER(ORDER BY HD.MaHD) AS STT");
                sql.Append("    FROM HoaDon HD");
                sql.Append("    LEFT JOIN ChiTietHoaDon CTHD ON HD.MaHD=CTHD.MaHD");
                sql.Append("    LEFT JOIN MatHang MH ON CTHD.MaMH=MH.MaMH");
                sql.Append("    LEFT JOIN KhachHang KH ON HD.MaKH=KH.MaKH");
                sql.Append("    WHERE HD.MaHD=@id");
                sql.Append(" END");
                var cmd = new SqlCommand(sql.ToString(), conn);
                cmd.ExecuteNonQuery();

                sql = new StringBuilder();
                sql.Append(" CREATE OR ALTER PROC GetDataReportPhieuThu(@id nchar(10))");
                sql.Append(" AS");
                sql.Append(" BEGIN");
                sql.Append("    SELECT");
                sql.Append("        MaPT");
                sql.Append("       ,TenKH");
                sql.Append("       ,Diachi");
                sql.Append("       ,KH.SDT");
                sql.Append("       ,TenNV");
                sql.Append("       ,PTTT");
                sql.Append("       ,NgayHD");
                sql.Append("       ,Ngaythu");
                sql.Append("       ,Sotien");
                sql.Append("       ,ROW_NUMBER() OVER(ORDER BY MaPT) AS STT");
                sql.Append("    FROM ThuTienKhachHang TTKH");
                sql.Append("    LEFT JOIN KhachHang KH ON TTKH.MaKH=KH.MaKH");
                sql.Append("    LEFT JOIN HoaDon HD ON TTKH.MaHD=HD.MaHD");
                sql.Append("    LEFT JOIN NhanVien NV ON TTKH.MaNV=NV.MaNV");
                sql.Append("    WHERE MaPT = @id");
                sql.Append(" END");
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception) { }
        }
    }
}
