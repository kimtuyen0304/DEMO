using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class PHIẾU_THU : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public PHIẾU_THU()
        {
            InitializeComponent();
        }

        private void PHIẾU_THU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet3.ThuTienKhachHang' table. You can move, or remove it, as needed.
            this.thuTienKhachHangTableAdapter.Fill(this.pt.ThuTienKhachHang);

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

        private void btnxoa_Click(object sender, EventArgs e)
        {

            {
                DialogResult ch = MessageBox.Show("Bạn muốn xóa phiếu thu " + btnxoa.Text.Trim() + " phải không", " xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        thuTienKhachHangTableAdapter.Delete(textmpt.Text);
                        MessageBox.Show("Đã xóa");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi khi xóa phiếu thu này" + ex.Message); }
                    try
                    {

                        this.thuTienKhachHangTableAdapter.Fill(this.pt.ThuTienKhachHang);
                    }
                    catch (System.Exception) { }

                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);

            textmpt.ResetText();
            textmhd.ResetText();
            textmnv.ResetText();
            textmkh.ResetText();
            texttien.ResetText();
            textpt.ResetText();

            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnExit.Enabled = true;
            btnMain.Enabled = true;
            btnLuu.Enabled = true;

            textmpt.Focus();

            isAddFlag = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            ChangeStatus(false);
            btnLuu.Enabled = true;
            textmpt.Enabled = false;
            textmhd.Focus();
            isEditFlag = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAddFlag)
                {
                    thuTienKhachHangTableAdapter.Insert(textmpt.Text.Trim(), Int32.Parse(texttien.Text),
                        dtChungTu.Value.ToString().Trim(), textpt.Text.Trim(), textmkh.Text.Trim(), textmnv.Text.Trim(), textmhd.Text.Trim(), Utility.CurrentUser.Id);
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChangeStatus(true);
                    isAddFlag = false;

                    Utility.EnableControl(groupBox1, false);
                }
                else if (isEditFlag)
                {
                    // Sử dụng parameterized query để tránh SQL Injection
                    thuTienKhachHangTableAdapter.Update(
                        textmpt.Text.Trim(),
                        Int32.Parse(texttien.Text),
                        dtChungTu.Value.ToString().Trim(),
                        textpt.Text.Trim(),
                        textmkh.Text.Trim(),
                        textmnv.Text.Trim(),
                        textmhd.Text.Trim()
                    );

                    // Hiển thị thông báo sau khi đã sửa thành công
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isEditFlag = false;
                    ChangeStatus(true);
                    Utility.EnableControl(groupBox1, false);
                }
                this.thuTienKhachHangTableAdapter.Fill(this.pt.ThuTienKhachHang);
            }
            catch
            {
                if (isAddFlag)
                {
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textmpt.Focus();
                }
                else if (isEditFlag)
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textmhd.Focus();
                }
            }
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

            btnLuu.Enabled = false;
            btnthem.Enabled = true;

            if (Utility.CheckPermission("ThuTienKhachHang", "MaPT", textmpt.Text.Trim()))
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = $"SELECT * FROM ThuTienKhachHang WHERE MaPT='{txtSearch.Text}' OR PTTT LIKE '%{txtSearch.Text}%' OR MaKH='{txtSearch.Text}' OR MaNV='{txtSearch.Text}' OR MaHD='{txtSearch.Text}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pt.ThuTienKhachHang;
            txtSearch.ResetText();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            var preview = new frmPreview();
            preview.DataSource = GetPhieuThu();
            preview.Parameters = SetReportParameters();
            preview.TemplateReportPath = "PhieuThu.rdlc";
            preview.ShowDialog();
        }

        private DataTable GetPhieuThu()
        {
            var dt = new DataTable();
            var conn = Utility.GetConnection();
            var sql = "GetDataReportPhieuThu";

            var cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", textmpt.Text.Trim());
            conn.Open();
            var dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        private ReportParameterCollection SetReportParameters()
        {
            var dt = GetPhieuThu();
            var parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("NgayXuatPhieu", DateTime.Today.Date.ToString()));
            parameters.Add(new ReportParameter("DonViBanHang", "CÔNG TY TNHH BBN"));
            parameters.Add(new ReportParameter("DiachiCongTy", "Số 30 Đường S7, Phường Tây Thạnh, Quận Tân Phú, Thành phố Hồ Chí Minh"));
            parameters.Add(new ReportParameter("MaSoThue", "0313424688"));
            parameters.Add(new ReportParameter("DienThoaiCongTy", "0938054590"));
            parameters.Add(new ReportParameter("NguoiXuatPhieu", "Huỳnh Kim Tuyền"));
            parameters.Add(new ReportParameter("TongTien", GetTotal(dt).ToString()));
            parameters.Add(new ReportParameter("MaPhieuThu", dt.Rows[0].ItemArray[0].ToString()));
            parameters.Add(new ReportParameter("KhachHang", dt.Rows[0].ItemArray[1].ToString()));
            parameters.Add(new ReportParameter("DiachiKhachHang", dt.Rows[0].ItemArray[2].ToString()));
            parameters.Add(new ReportParameter("DienThoaiKhachHang", dt.Rows[0].ItemArray[3].ToString()));
            return parameters;
        }

        private float GetTotal(DataTable dt)
        {
            float total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[8] != null && !string.IsNullOrEmpty(row.ItemArray[8].ToString()))
                    total += float.Parse(row.ItemArray[8].ToString());
            }
            return total;
        }
    }
}

