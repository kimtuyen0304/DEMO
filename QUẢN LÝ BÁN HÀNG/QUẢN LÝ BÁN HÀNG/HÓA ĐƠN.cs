using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class HÓA_ĐƠN : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;
        private const string tableChiTietHoaDon = "ChiTietHoaDon";
        private const string keyChiTietHoaDon = "MaMH";
        private const string tableHoaDon = "HoaDon";
        private const string key = "MaHD";

        public HÓA_ĐƠN()
        {
            InitializeComponent();
        }


        private void HÓA_ĐƠN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet20.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.kh.KhachHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet19.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nv.NhanVien);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet18.PhieuXuatKho' table. You can move, or remove it, as needed.
            this.phieuXuatKhoTableAdapter.Fill(this.pxk.PhieuXuatKho);
            this.matHangTableAdapter.Fill(this.mh.MatHang);
            this.chiTietHoaDonTableAdapter.Fill(this.cthd.ChiTietHoaDon);
            this.hoaDonTableAdapter.Fill(this.hd.HoaDon);

            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            btnXem.Enabled = false;

            txtkh.ResetText();
            txtmhd.ResetText();
            txtmkh.ResetText();
            txtmmh.ResetText();
            txtmnv.ResetText();
            txtmpxk.ResetText();
            dtNgay.ResetText();
            txtsl.ResetText();
            txtthanhtien.ResetText();

            txtmhd.Focus();

            txtthanhtien.Text = "0";
            isAddFlag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn xóa hóa đơn " + txtmhd.Text.Trim() + " phải không?", " Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    chiTietHoaDonTableAdapter.Delete(txtmhd.Text);
                    hoaDonTableAdapter.Delete(txtmhd.Text);

                    MessageBox.Show("Đã xóa hóa đơn thành công!");

                    chiTietHoaDonTableAdapter.Fill(this.cthd.ChiTietHoaDon);
                    hoaDonTableAdapter.Fill(hd.HoaDon);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn trở về trang chủ không?", "Xác nhận",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Close();
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
            try
            {
                //Tính lại tổng tiền
                txtthanhtien.Text = (Convert.ToDouble(txtsl.Text) * GetUnitPrice()).ToString();

                if (isAddFlag)
                {
                    if (!Utility.RecordExists(tableHoaDon, key, txtmhd.Text.Trim()))
                    {
                        if (!Utility.CheckExist(pxk.PhieuXuatKho.Rows, txtmpxk.Text.Trim()))
                        {
                            MessageBox.Show($"Phiếu xuất kho với mã {txtmpxk.Text.Trim()} không tồn tại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtmpxk.Focus();
                        }
                        else
                        {
                            // Thêm hóa đơn mới
                            this.hoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtkh.Text.Trim(), dtNgay.Value.ToString(),
                                txtmkh.Text.Trim(), txtmnv.Text.Trim(), txtmpxk.Text.Trim(), Utility.CurrentUser.Id);

                            MessageBox.Show("Thêm mới hóa đơn thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (MessageBox.Show("Bạn có muốn thêm thông tin chi tiết hóa đơn không?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (!Utility.RecordExists(tableChiTietHoaDon, key, txtmhd.Text.Trim(), keyChiTietHoaDon, txtmmh.Text.Trim()))
                                {
                                    if (!Utility.RecordExists("MatHang", "MaMH", txtmmh.Text.Trim()))
                                    {
                                        MessageBox.Show($"Mặt hàng với mã {txtmmh.Text.Trim()} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtmmh.Focus();
                                        return;
                                    }
                                    // Thêm chi tiết hóa đơn mới
                                    this.chiTietHoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtmmh.Text.Trim(),
                                        Int32.Parse(txtsl.Text), Int32.Parse(txtthanhtien.Text));

                                    MessageBox.Show("Thêm mới chi tiết hóa đơn thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            isAddFlag = false;

                            hoaDonTableAdapter.Fill(hd.HoaDon);
                            chiTietHoaDonTableAdapter.Fill(cthd.ChiTietHoaDon);

                            ChangeStatus(true);
                            Utility.EnableControl(groupBox1, false);
                            btnXem.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Đã tòn tại hóa đơn có ID = {txtmhd.Text.Trim()}", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isEditFlag)
                {
                    hoaDonTableAdapter.Update(txtmhd.Text.Trim(), txtkh.Text, dtNgay.Value.ToString(),
                        txtmkh.Text, txtmnv.Text, txtmpxk.Text);

                    MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (double.TryParse(txtsl.Text, out double soLuong))
                    {
                        chiTietHoaDonTableAdapter.Update(txtmhd.Text.Trim(), txtmmh.Text.Trim(),
                            soLuong, Convert.ToInt32(txtthanhtien.Text));

                        MessageBox.Show("Cập nhật chi tiết hóa đơn thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        isEditFlag = false;

                        hoaDonTableAdapter.Fill(hd.HoaDon);
                        chiTietHoaDonTableAdapter.Fill(cthd.ChiTietHoaDon);

                        ChangeStatus(true);
                        Utility.EnableControl(groupBox1, false);
                        btnXem.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtsl.Focus();
                    }
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            txtmhd.Enabled = false;
            txtkh.Focus();

            ChangeStatus(false);
            btnLuu.Enabled = true;

            isEditFlag = true;
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, false);
            var row = Utility.GetDataById(cthd.ChiTietHoaDon.Rows, txtmhd.Text.Trim());
            if (row != null)
            {
                var dt = GetDataChiTietHoaDon(txtmhd.Text);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtmmh.Text = dt.Rows[0].ItemArray[1].ToString().Trim();
                    txtsl.Text = dt.Rows[0].ItemArray[2].ToString().Trim();
                    txtthanhtien.Text = dt.Rows[0].ItemArray[3].ToString().Trim();
                }
                else
                {
                    txtmmh.Text = string.Empty;
                    txtsl.Text = string.Empty;
                    txtthanhtien.Text = string.Empty;
                }
            }
            Utility.EnableControl(groupBox1, false);
            txtSearch.Enabled = true;
            txtSearch.ResetText();

            btnLuu.Enabled = false;
            btnThem.Enabled = true;

            if (Utility.CheckPermission("HoaDon", "MaHD", txtmhd.Text.Trim()))
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private double GetUnitPrice()
        {
            foreach (DataRow row in mh.MatHang.Rows)
            {
                if (row.ItemArray[1].ToString().Trim().Equals(txtmmh.Text))
                {
                    return Convert.ToDouble(row.ItemArray[2]);
                }
            }
            return 0;
        }

        private DataTable GetDataChiTietHoaDon(string id)
        {
            var dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM {tableChiTietHoaDon} WHERE {key}='{id}'";
            conn.Open();
            var cmd = new SqlCommand(sql, conn);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        private void txtmmh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtthanhtien.Text = (Convert.ToDouble(txtsl.Text) * GetUnitPrice()).ToString();
            }
        }

        private void txtmmh_Leave(object sender, EventArgs e)
        {
            txtthanhtien.Text = (Convert.ToDouble(txtsl.Text) * GetUnitPrice()).ToString();
        }

        private void txtsl_Leave(object sender, EventArgs e)
        {
            double.TryParse(txtsl.Text, out double value);

            if (!Utility.Validate(txtsl.Text) || value < 0)
            {
                MessageBox.Show("Giá trị không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsl.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show(" Thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (ch == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            var previewDialog = new frmPreview();
            previewDialog.DataSource = GetHoaDon();
            previewDialog.Parameters = SetReportParameters();
            previewDialog.TemplateReportPath = "HoaDon.rdlc";
            previewDialog.ShowDialog();
        }

        private DataTable GetHoaDon()
        {
            var dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = "GetDataReportHoaDon";

            var cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txtmhd.Text.Trim());
            conn.Open();
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        private ReportParameterCollection SetReportParameters()
        {
            var dt = GetHoaDon();
            var parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("NgayHoaDon", DateTime.Today.Date.ToString()));
            parameters.Add(new ReportParameter("DonViBanHang", "CÔNG TY TNHH BBN"));
            parameters.Add(new ReportParameter("DiachiCongTy", "Số 30 Đường S7, Phường Tây Thạnh, Quận Tân Phú, Thành phố Hồ Chí Minh"));
            parameters.Add(new ReportParameter("MaSoThue", "0313424688"));
            parameters.Add(new ReportParameter("DienThoaiCongTy", "0938054590"));
            parameters.Add(new ReportParameter("NguoiBanHang", "Huỳnh Kim Tuyền"));
            parameters.Add(new ReportParameter("TongTien", GetTotal(dt).ToString()));
            parameters.Add(new ReportParameter("KhachHang", dt.Rows[0].ItemArray[5].ToString()));
            parameters.Add(new ReportParameter("DiachiKhachHang", dt.Rows[0].ItemArray[6].ToString()));
            parameters.Add(new ReportParameter("DienThoaiKhachHang", dt.Rows[0].ItemArray[7].ToString()));
            return parameters;
        }

        private float GetTotal(DataTable dt)
        {
            float total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[4] != null && !string.IsNullOrEmpty(row.ItemArray[4].ToString()))
                    total += float.Parse(row.ItemArray[4].ToString());
            }
            return total;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM KhachHang WHERE MaKH='{txtSearch.Text}' OR TenKH LIKE '%{txtSearch.Text}%' " +
                $"OR SDT LIKE '%{txtSearch.Text}%' OR Diachi LIKE '%{txtSearch.Text}%' OR Gioitinh LIKE '%{txtSearch.Text}%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            dtgData.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = hd.HoaDon;
            txtSearch.ResetText();
        }
    }
}



