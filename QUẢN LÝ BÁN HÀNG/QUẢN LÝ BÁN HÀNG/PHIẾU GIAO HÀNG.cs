using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class PHIẾU_GIAO_HÀNG : Form
	{
		private bool isAddFlag = false;
		private bool isEditFlag = false;

		public PHIẾU_GIAO_HÀNG()
		{
			InitializeComponent();
		}

		private void PHIẾU_GIAO_HÀNG_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet21.PhieuGiaoHang' table. You can move, or remove it, as needed.
            this.phieuGiaoHangTableAdapter.Fill(this.pgh.PhieuGiaoHang);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);

            txtMaPGH.ResetText();
            txtMaHD.ResetText();
            txtMaKH.ResetText();
            txtMaNV.ResetText();
            txtKH.ResetText();
            txtNV.ResetText();
            txtNguoiGH.ResetText();
            dtNgayGH.Value = DateTime.Today;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnExit.Enabled = true;
            btnMain.Enabled = true;
            btnLuu.Enabled = true;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            txtMaPGH.Focus();

            isAddFlag = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            txtMaPGH.Enabled = false;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            dtNgayGH.Focus();

            isEditFlag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa nhân viên có mã " + txtMaPGH.Text.Trim() + " không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    phieuGiaoHangTableAdapter.Delete(txtMaPGH.Text.Trim());
                    MessageBox.Show("Đã xóa nhân viên thành công!");
                    phieuGiaoHangTableAdapter.Fill(pgh.PhieuGiaoHang);
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void ChangeStatus(bool status)
        {
            btnSua.Enabled = status;
            btnThem.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveHandler();
        }

        private void SaveHandler()
        {
            try
            {
                if (isAddFlag)
                {
                    if (!Utility.RecordExists("PhieuGiaoHang", "MaPGH", txtMaPGH.Text.Trim()))
                    {
                        if(!Utility.RecordExists("HoaDon", "MaHD", txtMaHD.Text.Trim()))
                        {
                            MessageBox.Show("Mã hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaHD.Focus();
                            return;
                        }

                        if(!Utility.RecordExists("KhachHang", "MaKH", txtMaKH.Text.Trim()))
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.Focus();
                            return;
                        }

                        if (!Utility.RecordExists("NhanVien", "MaNV", txtMaNV.Text.Trim()))
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKH.Focus();
                            return;
                        }

                        phieuGiaoHangTableAdapter.Insert(txtKH.Text, txtNV.Text, txtMaPGH.Text.Trim(), txtMaHD.Text.Trim(),
                            txtMaKH.Text.Trim(), txtMaNV.Text.Trim(), dtNgayGH.Value, txtNguoiGH.Text);

                        MessageBox.Show("Thêm mới thành công!");
                        isAddFlag = false;
                        ChangeStatus(true);
                        this.phieuGiaoHangTableAdapter.Fill(pgh.PhieuGiaoHang);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show($"Đã tồn tại ID = {txtMaPGH.Text.Trim()}!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isEditFlag)
                {
                    if (!Utility.RecordExists("HoaDon", "MaHD", txtMaHD.Text.Trim()))
                    {
                        MessageBox.Show("Mã hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaHD.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("KhachHang", "MaKH", txtMaKH.Text.Trim()))
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKH.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("NhanVien", "MaNV", txtMaNV.Text.Trim()))
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKH.Focus();
                        return;
                    }

                    phieuGiaoHangTableAdapter.Update(txtKH.Text, txtNV.Text, txtMaPGH.Text.Trim(), txtMaHD.Text.Trim(),
                            txtMaKH.Text.Trim(), txtMaNV.Text.Trim(), dtNgayGH.Value.ToString(), txtNguoiGH.Text);
                    
                    MessageBox.Show("Cập nhật thành công!");
                    isEditFlag = false;
                    ChangeStatus(true);
                    phieuGiaoHangTableAdapter.Fill(pgh.PhieuGiaoHang);
                    Utility.EnableControl(groupBox1, false);
                }
            }
            catch (Exception)
            {
                if (isAddFlag)
                {
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (isEditFlag)
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, false);
            txtSearch.Enabled = true;
            txtSearch.ResetText();
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM PhieuGiaoHang WHERE MaPGH='{txtSearch.Text}' OR TenNV LIKE '%{txtSearch.Text}%' OR TenKH LIKE '%{txtSearch.Text}%'" +
                $" OR MaKH LIKE '%{txtSearch.Text}%' OR MaNV LIKE '%{txtSearch.Text}%' OR MaHD LIKE '%{txtSearch.Text}%' OR NguoiGiao LIKE '%{txtSearch.Text}%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pgh.PhieuGiaoHang;
            txtSearch.ResetText();
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT TenKH FROM KhachHang WHERE MaKH='{txtMaKH.Text.Trim()}'";
            conn.Open();
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                txtKH.Text = dt.Rows[0].ItemArray[0].ToString();
            }

            conn.Close();
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT TenNV FROM NhanVien WHERE MaNV='{txtMaNV.Text.Trim()}'";
            conn.Open();
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtNV.Text = dt.Rows[0].ItemArray[0].ToString();
            }

            conn.Close();
        }
    }
}
