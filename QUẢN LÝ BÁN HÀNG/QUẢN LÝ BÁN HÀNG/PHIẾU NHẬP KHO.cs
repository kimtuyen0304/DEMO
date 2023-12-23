using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class PHIẾU_NHẬP_KHO : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public PHIẾU_NHẬP_KHO()
        {
            InitializeComponent();
        }

        private void PHIẾU_NHẬP_KHO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet12.PhieuNhapKho' table. You can move, or remove it, as needed.
            this.phieuNhapKhoTableAdapter2.Fill(this.pnk1.PhieuNhapKho);
            // TODO: This line of code loads data into the 'phieuNhapKho._PhieuNhapKho' table. You can move, or remove it, as needed.
            //this.phieuNhapKhoTableAdapter.Fill(this.pnk.PhieuNhapKho);
            // TODO: This line of code loads data into the 'mathang.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter1.Fill(this.mathang.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet9.ChiTietPhieuNhapKho' table. You can move, or remove it, as needed.
            this.chiTietPhieuNhapKhoTableAdapter.Fill(this.ctpn.ChiTietPhieuNhapKho);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);

            txtpnk.ResetText();
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtMaKho.ResetText();
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtSoLuong.ResetText();
            dtNgayNK.Value = DateTime.Today;

            btnExit.Enabled = true;
            btnMain.Enabled = true;
            btnLuu.Enabled = true;
            groupBox4.Enabled = true;
            txtMaMH.Enabled = true;
            txtSoLuong.Enabled = true;
            dtNgayNK.Enabled = true;

            txtpnk.Focus();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            txtpnk.Enabled = false;
            groupBox4.Enabled = true;
            txtMaMH.Enabled = true;
            txtSoLuong.Enabled = true;
            dtNgayNK.Enabled = true;
            txtMaKho.Focus();

            isEditFlag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập kho có mã " + txtpnk.Text.Trim() + " không? ", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    if(MessageBox.Show($"Bạn phải xóa thông tin phiếu nhập kho từ bảng chi tiết ứng với mã {txtpnk.Text.Trim()} trước?", "Xác nhận", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        chiTietPhieuNhapKhoTableAdapter.Delete(txtpnk.Text.Trim());
                        MessageBox.Show("Đã xóa chi tiết phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        phieuNhapKhoTableAdapter2.Delete(txtpnk.Text.Trim());
                        MessageBox.Show("Đã xóa phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.phieuNhapKhoTableAdapter2.Fill(pnk1.PhieuNhapKho);
                    }
                }
                catch (Exception) 
                { 
                    MessageBox.Show("Có lỗi xóa phiếu nhập kho này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, false);
            groupBox4.Enabled = false;

            if (Utility.CheckPermission("PhieuNhapKho", "MaPNK", txtpnk.Text.Trim()))
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

            GetDataChiTietPNK();
        }

        private void txtMaMH_Enter(object sender, EventArgs e)
        {
            GetDataChiTietPNK();
        }

        private void GetDataChiTietPNK()
        {
            if (isEditFlag || !isAddFlag)
            {
                var dt = new DataTable();
                var conn = Utility.GetConnection();
                conn.Open();
                var sql = $"SELECT * FROM ChiTietPhieuNhapKho WHERE MaPNK='{txtpnk.Text.Trim()}'";
                var cmd = new SqlCommand(sql, conn);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    txtMaMH.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtTenMH.Text = dt.Rows[0].ItemArray[2].ToString();
                    txtSoLuong.Text = dt.Rows[0].ItemArray[3].ToString();
                    dtNgayNK.Value = DateTime.Parse(dt.Rows[0].ItemArray[4].ToString());
                }
            }
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
                    if(!Utility.RecordExists("PhieuNhapKho", "MaPNK", txtpnk.Text.Trim()))
                    {
                        if(!Utility.RecordExists("NhanVien", "MaNV", txtMaNV.Text.Trim()))
                        {
                            MessageBox.Show($"Nhân viên với mã {txtMaNV.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaNV.Focus();
                            return;
                        }

                        if(!Utility.RecordExists("TonKho","MaKho", txtMaKho.Text.Trim()))
                        {
                            MessageBox.Show($"Kho với mã {txtMaKho.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaKho.Focus();
                            return;
                        }

                        phieuNhapKhoTableAdapter2.Insert(txtpnk.Text.Trim(), txtTenNV.Text, txtMaNV.Text.Trim(), txtMaKho.Text.Trim(), Utility.CurrentUser.Id);
                        MessageBox.Show("Thêm mới phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(MessageBox.Show("Bạn có muốn thêm thông tin vào bảng chi tiết phiếu nhập kho không?", "Xác nhận", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if(!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                            {
                                MessageBox.Show($"Mặt hàng với mã {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMaMH.Focus();
                                return;
                            }

                            var checkSoluong = int.TryParse(txtSoLuong.Text, out int soLuong);
                            if (string.IsNullOrEmpty(txtSoLuong.Text) || !checkSoluong)
                            {
                                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSoLuong.Focus();
                                return;
                            }

                            chiTietPhieuNhapKhoTableAdapter.Insert(txtpnk.Text.Trim(), txtMaMH.Text.Trim(), txtTenMH.Text, soLuong, dtNgayNK.Value);
                            MessageBox.Show("Thêm mới chi tiết phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        isAddFlag = false;
                        ChangeStatus(true);
                        this.phieuNhapKhoTableAdapter2.Fill(pnk1.PhieuNhapKho);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show($"Đã tồn tại phiếu nhập kho với mã {txtpnk.Text.Trim()}.\nVui lòng kiểm tra lại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpnk.Focus();
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

                    if (!Utility.RecordExists("TonKho", "MaKho", txtMaKho.Text.Trim()))
                    {
                        MessageBox.Show($"Kho với mã {txtMaKho.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaKho.Focus();
                        return;
                    }

                    phieuNhapKhoTableAdapter2.Update(txtpnk.Text.Trim(), txtTenNV.Text, txtMaNV.Text.Trim(), txtMaKho.Text.Trim());
                    MessageBox.Show("Cập nhật phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.phieuNhapKhoTableAdapter2.Fill(pnk1.PhieuNhapKho);

                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin cho bảng chi tiết phiếu nhập kho không?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                        {
                            MessageBox.Show($"Mặt hàng với mã {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaMH.Focus();
                            return;
                        }

                        var checkSoluong = int.TryParse(txtSoLuong.Text, out int soLuong);
                        if (string.IsNullOrEmpty(txtSoLuong.Text) || !checkSoluong)
                        {
                            MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoLuong.Focus();
                            return;
                        }

                        chiTietPhieuNhapKhoTableAdapter.Update(txtpnk.Text.Trim(), txtMaMH.Text.Trim(), txtTenMH.Text, soLuong, dtNgayNK.Value);
                        MessageBox.Show("Cập nhật chi tiết phiếu nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Utility.EnableControl(groupBox1, false);
                    Utility.EnableControl(groupBox4, false);
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

        private void ChangeStatus(bool status)
        {
            btnSua.Enabled = status;
            btnThem.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            var sql = $"SELECT TenNV FROM NhanVien WHERE MaNV='{txtMaNV.Text.Trim()}'";
            var value = Utility.ExecQuery(sql);
            if (!string.IsNullOrEmpty(value)){
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

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn đóng màn hình không?", "Xác nhận",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
