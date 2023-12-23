using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class HÀNG_BÁN_TRẢ_LẠI : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public HÀNG_BÁN_TRẢ_LẠI()
        {
            InitializeComponent();
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

        private void HÀNG_BÁN_TRẢ_LẠI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet14.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.mh.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet7.ChiTietHangBanTraLai' table. You can move, or remove it, as needed.
            this.chiTietHangBanTraLaiTableAdapter.Fill(this.cthbtl.ChiTietHangBanTraLai);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet8.HangBanTraLai' table. You can move, or remove it, as needed.
            this.hangBanTraLaiTableAdapter.Fill(this.hbtl.HangBanTraLai);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            btnLuu.Enabled = true;

            textmh.ResetText();
            dtNgay.Value = DateTime.Today;
            makh.ResetText();
            manv.ResetText();
            diengiai.ResetText();
            ghichu.ResetText();
            txtMaMH.ResetText();
            txtSoLuong.ResetText();
            textmh.Focus();

            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            isAddFlag = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            textmh.Enabled = false;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
            btnReset.Enabled = false;

            makh.Focus();

            isEditFlag = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa hàng bán trả lại có mã " + textmh.Text.Trim() + " không? ",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    hangBanTraLaiTableAdapter.Delete(textmh.Text.Trim());
                    MessageBox.Show("Đã xóa nhân viên thành công!");
                    this.hangBanTraLaiTableAdapter.Fill(hbtl.HangBanTraLai);
                }
                catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra!" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void SaveHandler()
        {
            try
            {
                if (isAddFlag)
                {
                    if (!Utility.RecordExists("HangBanTraLai", "MaHBTL", textmh.Text.Trim()))
                    {
                        if (!Utility.RecordExists("NhanVien", "MaNV", manv.Text.Trim()))
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            manv.Focus();
                            return;
                        }

                        if (!Utility.RecordExists("KhachHang", "MaKH", makh.Text.Trim()))
                        {
                            MessageBox.Show("Mã khách hàng không tồn tại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            makh.Focus();
                            return;
                        }

                        hangBanTraLaiTableAdapter.Insert(textmh.Text.Trim(), dtNgay.Value, diengiai.Text,
                            ghichu.Text, manv.Text.Trim(), makh.Text.Trim(), Utility.CurrentUser.Id);

                        MessageBox.Show("Thêm mới thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(MessageBox.Show("Bạn có muốn thêm dữ liệu vào bảng chi tiết không?", "Xác nhận", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if(!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                            {
                                MessageBox.Show($"Mặt hàng với mã = {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtMaMH.Focus();
                                return;
                            }

                            if(!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
                            {
                                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSoLuong.Focus();
                                return;
                            }
                            chiTietHangBanTraLaiTableAdapter.Insert(textmh.Text.Trim(), txtMaMH.Text.Trim(), soLuong);
                            MessageBox.Show("Thêm dữ liệu vào bảng chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        isAddFlag = false;
                        ChangeStatus(true);
                        this.hangBanTraLaiTableAdapter.Fill(hbtl.HangBanTraLai);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show($"Đã tồn tại ID = {textmh.Text.Trim()}.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isEditFlag)
                {
                    if (!Utility.RecordExists("NhanVien", "MaNV", manv.Text.Trim()))
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        manv.Focus();
                        return;
                    }

                    if (!Utility.RecordExists("KhachHang", "MaKH", makh.Text.Trim()))
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        makh.Focus();
                        return;
                    }

                    hangBanTraLaiTableAdapter.Update(textmh.Text.Trim(), dtNgay.Value.ToString(),
                        diengiai.Text, ghichu.Text, manv.Text.Trim(), makh.Text.Trim());

                    MessageBox.Show("Cập nhật thành công!");

                    if(MessageBox.Show($"Bạn có muốn cập nhật dữ liệu bảng chi tiết với mã = {textmh.Text.Trim()} không?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!Utility.RecordExists("MatHang", "MaMH", txtMaMH.Text.Trim()))
                        {
                            MessageBox.Show($"Mặt hàng với mã = {txtMaMH.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMaMH.Focus();
                            return;
                        }

                        if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
                        {
                            MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoLuong.Focus();
                            return;
                        }
                        chiTietHangBanTraLaiTableAdapter.Update(textmh.Text.Trim(), txtMaMH.Text.Trim(), soLuong);
                        MessageBox.Show("Cập nhật dữ liệu bảng chi tiết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    isEditFlag = false;
                    ChangeStatus(true);
                    hangBanTraLaiTableAdapter.Fill(hbtl.HangBanTraLai);
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

        private void HÀNG_BÁN_TRẢ_LẠI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAddFlag || isEditFlag)
            {
                if (MessageBox.Show("Bạn có muốn lưu dữ liệu trước khi đóng màn hình không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveHandler();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM HangBanTraLai WHERE MaHBTL='{txtSearch.Text}' OR MaNV LIKE '%{txtSearch.Text}%' OR MaKH LIKE '%{txtSearch.Text}%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            dtgData.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = hbtl.HangBanTraLai;
            txtSearch.ResetText();
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, false);
            txtSearch.Enabled = true;
            txtSearch.ResetText();
            btnSearch.Enabled = true;
            btnReset.Enabled = true;
            var dt = GetDataChiTiet(textmh.Text);
            if(dt.Rows.Count > 0)
            {
                txtMaMH.Text = dt.Rows[0].ItemArray[1].ToString();
                txtSoLuong.Text = dt.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                txtMaMH.Text = string.Empty;
                txtSoLuong.Text = string.Empty;
            }

            btnLuu.Enabled = false;
            btnthem.Enabled = true;

            if (Utility.CheckPermission("HangBanTraLai", "MaHBTL", textmh.Text.Trim()))
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

        private DataTable GetDataChiTiet(string id)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            conn.Open();
            var sql = $"SELECT * FROM ChiTietHangBanTraLai WHERE MaHBTL='{id}'";
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
