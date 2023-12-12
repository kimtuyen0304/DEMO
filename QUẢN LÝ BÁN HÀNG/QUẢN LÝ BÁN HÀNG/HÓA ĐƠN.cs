using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class HÓA_ĐƠN : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public HÓA_ĐƠN()
        {
            InitializeComponent();
        }


        private void HÓA_ĐƠN_Load(object sender, EventArgs e)
        {
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
                    if (!Utility.RecordExists(mh.MatHang.Rows, txtmhd.Text.Trim()))
                    {
                        // Thêm hóa đơn mới
                        this.hoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtkh.Text.Trim(), dtNgay.Text.Trim(),
                            txtmkh.Text.Trim(), txtmnv.Text.Trim(), txtmpxk.Text.Trim());

                        MessageBox.Show("Thêm mới hóa đơn thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(MessageBox.Show("Bạn có muốn thêm thông tin chi tiết hóa đơn không?", "Xác nhận", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if(!Utility.RecordExists(cthd.ChiTietHoaDon.Rows, txtmhd.Text.Trim(), txtmmh.Text.Trim()))

                            // Thêm chi tiết hóa đơn mới
                            this.chiTietHoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtmmh.Text,
                                Int32.Parse(txtsl.Text), Int32.Parse(txtthanhtien.Text));

                            MessageBox.Show("Thêm mới chi tiết hóa đơn thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        isAddFlag = false;

                        hoaDonTableAdapter.Fill(hd.HoaDon);
                        chiTietHoaDonTableAdapter.Fill(cthd.ChiTietHoaDon);

                        ChangeStatus(true);
                        Utility.EnableControl(groupBox1, false);
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

                    if(double.TryParse(txtsl.Text, out double soLuong))
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
                else if(isEditFlag)
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
            if(row != null)
            {
                txtmmh.Text = row.ItemArray[1].ToString().Trim();
                txtsl.Text = row.ItemArray[2].ToString().Trim();
                txtthanhtien.Text = row.ItemArray[3].ToString().Trim();
            }
        }

        private double GetUnitPrice()
        {
            foreach(DataRow row in mh.MatHang.Rows)
            {
                if (row.ItemArray[1].ToString().Trim().Equals(txtmmh.Text)){
                    return Convert.ToDouble(row.ItemArray[2]);
                }
            }
            return 0;
        }

        private void txtmmh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
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
            previewDialog.DataSource = cthd.ChiTietHoaDon;
            previewDialog.ShowDialog();
        }
    }
}



