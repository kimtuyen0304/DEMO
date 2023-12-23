using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class SẢN_PHẨM : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;
        private const string tableSP = "MatHang";
        private const string keySP = "MaMH";
        private const string tableNH = "NhomHang";
        private const string keyNH = "MaNH";

        public SẢN_PHẨM()
        {
            InitializeComponent();
        }

        private void SẢN_PHẨM_Load(object sender, EventArgs e)
        {
            this.nhomHangTableAdapter.Fill(this.nhomHang.NhomHang);
            this.matHangTableAdapter.Fill(this.sp.MatHang);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {tbMMH.Text.Trim()} không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    matHangTableAdapter.Delete(tbMMH.Text);
                    MessageBox.Show("Đã xóa mặt hàng thành công!");
                    matHangTableAdapter.Fill(this.sp.MatHang);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa mặt hàng thất bại!");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            tbMMH.Enabled = false;
            tbTenMH.Focus();
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            ChangeStatus(false);
            btnLuu.Enabled = true;
            isEditFlag = true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);

            tbMMH.ResetText();
            tbTenMH.ResetText();
            textgia.ResetText();
            tbVAT.ResetText();
            tbNH.ResetText();
            tbTenNH.ResetText();
            tbGhiChu.ResetText();

            dtNSX.Value = DateTime.Today;
            dtHSD.Value = DateTime.Today;

            tbMMH.Focus();

            ChangeStatus(false);
            btnLuu.Enabled = true;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            isAddFlag = true;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show(" Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (ch == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            this.Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn đóng màn hình không?", "Xác nhận",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveHandler();
        }

        private void ChangeStatus(bool status)
        {
            btnsua.Enabled = status;
            btnthem.Enabled = status;
            btnxoa.Enabled = status;
            btnLuu.Enabled = !status;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, false);
            txtSearch.Enabled = true;
            txtSearch.ResetText();
            btnReset.Enabled = true;
            btnSearch.Enabled = true;

            btnLuu.Enabled = false;
            btnthem.Enabled = true;

            if (Utility.CheckPermission("MatHang", "MaMH", tbMMH.Text.Trim()))
            {
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
            else
            {
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        private void SaveHandler()
        {
            try
            {
                if (isAddFlag)
                {
                    if (!Utility.RecordExists(tableSP, keySP, tbMMH.Text.Trim()))
                    {
                        if (!Utility.RecordExists(tableNH, keyNH, tbNH.Text.Trim()))
                        {
                            nhomHangTableAdapter.Insert(tbNH.Text.Trim(), tbTenNH.Text, tbGhiChu.Text);
                        }

                        matHangTableAdapter.Insert(tbTenMH.Text, tbMMH.Text.Trim(), Convert.ToInt32(textgia.Text),
                            dtNSX.Value, dtHSD.Value, Convert.ToInt32(tbVAT.Text), tbNH.Text, Utility.CurrentUser.Id);

                        MessageBox.Show("Thêm mới mặt hàng thành công!");

                        nhomHangTableAdapter.Fill(nhomHang.NhomHang);
                        matHangTableAdapter.Fill(sp.MatHang);
                        ChangeStatus(true);
                    }
                }
                else if (isEditFlag)
                {
                    if (DateTime.TryParse(dtNSX.Value.ToString(), out DateTime nsxDate) && DateTime.TryParse(dtHSD.Value.ToString(), out DateTime hsdDate))
                    {
                        string formattedNSX = nsxDate.ToString("yyyy-MM-dd");
                        string formattedHSD = hsdDate.ToString("yyyy-MM-dd");

                        matHangTableAdapter.Update(tbTenMH.Text.Trim(), tbMMH.Text.Trim(), Int32.Parse(textgia.Text), formattedNSX, formattedHSD, Int32.Parse(tbVAT.Text), tbNH.Text.Trim());
                        MessageBox.Show("Cập nhật thành công!");
                        matHangTableAdapter.Fill(sp.MatHang);
                        isEditFlag = false;
                        ChangeStatus(true);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show("Ngày sản xuất (NSX) hoặc hạn sử dụng (HSD) không hợp lệ!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch (Exception)
            {
                if (isAddFlag)
                {
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else if (isEditFlag)
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM MatHang WHERE MaMH='{txtSearch.Text}' OR TenMH LIKE '%{txtSearch.Text}%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            dtgData1.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgData1.DataSource = sp.MatHang;
            txtSearch.ResetText();
        }
    }
}


