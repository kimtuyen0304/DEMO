using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet9TableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class PHIẾU_XUẤT_KHO : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public PHIẾU_XUẤT_KHO()
        {
            InitializeComponent();
        }

        private void PHIẾU_XUẤT_KHO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.mathang.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24.PhieuXuatKho' table. You can move, or remove it, as needed.
            this.phieuXuatKhoTableAdapter.Fill(this.pxk.PhieuXuatKho);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23.ChiTietPhieuXuatKho' table. You can move, or remove it, as needed.
            this.chiTietPhieuXuatKhoTableAdapter.Fill(this.ctpxk.ChiTietPhieuXuatKho);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBoxTP, true);
            ChangeStatus(false);

            txtMaPXK.ResetText();
            txtMaKH.ResetText();
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtMaKho.ResetText();
            txtGhiChu.ResetText();
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtSoLuong.ResetText();
            dtNgayXK.Value = DateTime.Today;
            dtNgayDH.Value = DateTime.Today;

            btnExit.Enabled = true;
            btnMain.Enabled = true;
            btnLuu.Enabled = true;
            groupBox2.Enabled = true;
            Utility.EnableControl(groupBox2, true);
            txtTenMH.Enabled = false;

            txtMaPXK.Focus();

            isAddFlag = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBoxTP, true);
            ChangeStatus(false);
            txtMaPXK.Enabled = false;
            groupBox2.Enabled = true;
            txtMaMH.Enabled = true;
            txtSoLuong.Enabled = true;
            dtNgayXK.Enabled = true;
            dtNgayDH.Enabled = true;
            txtMaNV.Focus();

            isEditFlag = true;
        }

        private void ChangeStatus(bool status)
        {
            btnSua.Enabled = status;
            btnThem.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa phiếu xuất kho có mã " + txtMaPXK.Text.Trim() + " không? ", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    if (MessageBox.Show($"Bạn phải xóa thông tin phiếu xuất kho từ bảng chi tiết ứng với mã {txtMaPXK.Text.Trim()} trước?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        chiTietPhieuXuatKhoTableAdapter.Delete(txtMaPXK.Text.Trim());
                        MessageBox.Show("Đã xóa chi tiết phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        phieuXuatKhoTableAdapter.Delete(txtMaPXK.Text.Trim());
                        MessageBox.Show("Đã xóa phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.phieuXuatKhoTableAdapter.Fill(pxk.PhieuXuatKho);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Có lỗi xóa phiếu xuất kho này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    if(!Utility.RecordExists("PhieuXuatKho", "MaPXK", txtMaPXK.Text.Trim()))
                    {
                        if(!Utility.RecordExists("NhanVien", "MaNV", txtMaNV.Text.Trim()))
                        {
                            MessageBox.Show($"Nhân viên với mã {txtMaNV.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNV.Focus();
                            return;
                        }

                        if (!Utility.RecordExists("KhachHang", "MaKH", txtMaKH.Text.Trim()))
                        {
                            MessageBox.Show($"Khách hàng với mã {txtMaKH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNV.Focus();
                            return;
                        }

                        if (!Utility.RecordExists("TonKho", "MaKho", txtMaKho.Text.Trim()))
                        {
                            MessageBox.Show($"Kho với mã {txtMaKho.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNV.Focus();
                            return;
                        }

                        if (!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                        {
                            MessageBox.Show($"Mặt hàng với mã {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaMH.Focus();
                            return;
                        }

                        var check = int.TryParse(txtSoLuong.Text, out int soLuong);
                        if(string.IsNullOrEmpty(txtSoLuong.Text) || !check || soLuong <= 0)
                        {
                            MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoLuong.Focus();
                            return;
                        }

                        phieuXuatKhoTableAdapter.Insert(txtMaPXK.Text.Trim(), txtMaNV.Text.Trim(), txtTenNV.Text,
                            txtMaKH.Text.Trim(), txtMaKho.Text.Trim(), txtGhiChu.Text, Utility.CurrentUser.Id);
                        MessageBox.Show("Thêm mới phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chiTietPhieuXuatKhoTableAdapter.Insert(txtMaPXK.Text.Trim(), txtMaMH.Text.Trim(), txtTenMH.Text, soLuong, dtNgayXK.Value, dtNgayDH.Value);
                        isAddFlag = false;
                        ChangeStatus(true);
                        this.phieuXuatKhoTableAdapter.Fill(pxk.PhieuXuatKho);
                        Utility.EnableControl(groupBoxTP, false);
                        Utility.EnableControl(groupBox2, false);
                    }
                    else
                    {
                        MessageBox.Show($"Đã tồn tại phiếu xuất kho ứng với mã {txtMaPXK.Text.Trim()}.\nVui lòng kiểm tra lại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaPXK.Focus();
                        return;
                    }
                }
                else if (isEditFlag)
                {
                    if (!Utility.RecordExists("NhanVien", "MaNV", txtMaNV.Text.Trim()))
                    {
                        MessageBox.Show($"Nhân viên với mã {txtMaNV.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNV.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("KhachHang", "MaKH", txtMaKH.Text.Trim()))
                    {
                        MessageBox.Show($"Khách hàng với mã {txtMaKH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNV.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("TonKho", "MaKho", txtMaKho.Text.Trim()))
                    {
                        MessageBox.Show($"Kho với mã {txtMaKho.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaNV.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                    {
                        MessageBox.Show($"Mặt hàng với mã {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaMH.Focus();
                        return;
                    }

                    var check = int.TryParse(txtSoLuong.Text, out int soLuong);
                    if (string.IsNullOrEmpty(txtSoLuong.Text) || !check || soLuong <= 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuong.Focus();
                        return;
                    }

                    phieuXuatKhoTableAdapter.Update(txtMaPXK.Text.Trim(), txtMaNV.Text.Trim(), txtTenNV.Text, txtMaKH.Text.Trim(),
                        txtMaKho.Text.Trim(), txtGhiChu.Text);
                    this.phieuXuatKhoTableAdapter.Fill(pxk.PhieuXuatKho);
                    MessageBox.Show("Cập nhật thông tin phiếu xuất kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chiTietPhieuXuatKhoTableAdapter.Update(txtMaPXK.Text.Trim(), txtMaMH.Text.Trim(), txtTenMH.Text, soLuong, dtNgayXK.Value, dtNgayDH.Value);
                    Utility.EnableControl(groupBoxTP, false);
                    Utility.EnableControl(groupBox2, false);
                    ChangeStatus(true);
                    isEditFlag = false;
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
            Utility.EnableControl(groupBoxTP, false);
            Utility.EnableControl(groupBox2, false);

            if (Utility.CheckPermission("PhieuXuatKho", "MaPXK", txtMaPXK.Text.Trim()))
            {
                btnThem.Enabled = true;

                if (Utility.CurrentUser.Role == 0)
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                }
            }
            else
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
            }

            GetDataChiTietPXK();
        }

        private void GetDataChiTietPXK()
        {
            if (isEditFlag || !isAddFlag)
            {
                var dt = new DataTable();
                var conn = Utility.GetConnection();
                conn.Open();
                var sql = $"SELECT * FROM ChiTietPhieuXuatKho WHERE MaPXK='{txtMaPXK.Text.Trim()}'";
                var cmd = new SqlCommand(sql, conn);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    txtMaMH.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTenMH.Text = dt.Rows[0].ItemArray[2].ToString();
                    txtSoLuong.Text = dt.Rows[0].ItemArray[3].ToString();
                    dtNgayXK.Value = DateTime.Parse(dt.Rows[0].ItemArray[4].ToString());
                    dtNgayDH.Value = DateTime.Parse(dt.Rows[0].ItemArray[5].ToString());
                }
            }
        }

        private void txtMaMH_Enter(object sender, EventArgs e)
        {
            GetDataChiTietPXK();
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            var sql = $"SELECT TenNV FROM NhanVien WHERE MaNV='{txtMaNV.Text.Trim()}'";
            var value = Utility.ExecQuery(sql);
            if (!string.IsNullOrEmpty(value))
            {
                txtTenNV.Text = value;
            }
        }

        private void txtMaMH_Leave(object sender, EventArgs e)
        {
            var sql = $"SELECT TenMH FROM MatHang WHERE MaMH='{txtMaMH.Text.Trim()}'";
            var value = Utility.ExecQuery(sql);
            if (!string.IsNullOrEmpty(value))
            {
                txtTenMH.Text = value;
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out int soluong) || soluong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }
        }
    }
}
