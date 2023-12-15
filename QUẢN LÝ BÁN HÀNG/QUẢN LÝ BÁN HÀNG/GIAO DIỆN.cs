using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class giaodien : Form
    {
        private const string oDatabaseName = "8 _ HuynhKimTuyen_ QLBH BBN_20DTK1";
        private const string nDatabaseName = "QLBH.bak";
        private string backupFolderPath = Application.StartupPath.Split(new string[]{"\\bin" }, StringSplitOptions.None)[0] + "\\BACKUP";

        public giaodien()
        {
            InitializeComponent();
            Utility.RestoreDatabase(backupFolderPath, oDatabaseName, nDatabaseName);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap fr = new dangnhap();
            fr.ShowDialog();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap fr = new dangnhap();
            fr.ShowDialog();
        }

        private void lbtime_Click(object sender, EventArgs e)
        {
            lbtime.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát Khỏi Chương trình (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHÂN_VIÊN fr = new NHÂN_VIÊN();
            fr.ShowDialog();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KHÁCH_HÀNG fr = new KHÁCH_HÀNG();
            fr.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhậpKhoHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SẢN_PHẨM fr = new SẢN_PHẨM();
            fr.ShowDialog();
        }

        private void lậpPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIẾU_THU fr = new PHIẾU_THU();
            fr.ShowDialog();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HÓA_ĐƠN fr = new HÓA_ĐƠN();
            fr.ShowDialog();

        }

        private void lậpĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIẾU_GIAO_HÀNG fr = new PHIẾU_GIAO_HÀNG();
            fr.ShowDialog();
        }

        private void hàngBánTrảLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HÀNG_BÁN_TRẢ_LẠI fr = new HÀNG_BÁN_TRẢ_LẠI();
            fr.ShowDialog();
        }

        private void lậpPhiếuNhậpThànhPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIẾU_NHẬP_KHO fr = new PHIẾU_NHẬP_KHO();
            fr.ShowDialog();
        }

        private void lậpPhiếuXuấtThànhPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIẾU_XUẤT_KHO fr = new PHIẾU_XUẤT_KHO();
            fr.ShowDialog();
        }

        private void saoLưuTựĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = Utility.GetConnection();

                if (!Directory.Exists(backupFolderPath))
                {
                    Directory.CreateDirectory(backupFolderPath);
                }

                if (!Directory.Exists($"{backupFolderPath}/{DateTime.Today.ToString("yyyyMMdd")}"))
                {
                    Directory.CreateDirectory($"{backupFolderPath}/{DateTime.Today.ToString("yyyyMMdd")}");
                }

                var sql = $"BACKUP DATABASE [{oDatabaseName}] TO DISK=" +
                    $"'{backupFolderPath}/{DateTime.Today.ToString("yyyyMMdd")}/{nDatabaseName}'";
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show($"Đã sao lưu dữ liệu thành công!\nVui lòng kiểm tra tại thư mục:" +
                    $"\n\t{backupFolderPath}/{DateTime.Today.ToString("yyyyMMdd")}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sao lưu dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phụcHồiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Utility.RestoreDatabase(backupFolderPath, oDatabaseName, nDatabaseName);
                MessageBox.Show("Phục hồi dữ liệu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Phục hồi dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
