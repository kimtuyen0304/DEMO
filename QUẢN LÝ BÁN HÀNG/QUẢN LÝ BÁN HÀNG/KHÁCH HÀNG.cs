using System;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class KHÁCH_HÀNG : Form
    {
        private bool isAddFlag = false;
        private bool isEditFlag = false;

        public KHÁCH_HÀNG()
        {
            InitializeComponent();
        }

        private void KHÁCH_HÀNG_Load(object sender, EventArgs e)
        {
            khachHangTableAdapter.Fill(this.khachhang.KhachHang);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (ch == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            Close();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn đóng màn hình hiện tại không?", "Xác nhận",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);

            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnMain.Enabled = true;

            txtkh.ResetText();
            txtten.ResetText();
            txtdiachi.ResetText();
            txtgc.ResetText();
            txtsdt.ResetText();
            txtgt.ResetText();

            txtkh.Focus();

            isAddFlag = true;
        }



        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show($"Bạn có muốn xóa khách hàng có ID = {txtkh.Text.Trim()} không?", " Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    khachHangTableAdapter.Delete(txtkh.Text);
                    MessageBox.Show("Đã xóa thành công!");
                    khachHangTableAdapter.Fill(khachhang.KhachHang);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            txtkh.Enabled = false;
            txtten.Focus();
            btnLuu.Enabled = true;

            isEditFlag = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAddFlag)
                {
                    if (!Utility.RecordExists(txtkh.Text.Trim()))
                    {
                        khachHangTableAdapter.Insert(txtkh.Text.Trim(), txtten.Text.Trim(), txtsdt.Text.Trim(), txtdiachi.Text.Trim(), txtgt.Text.Trim(), txtgc.Text.Trim());
                        MessageBox.Show("Thêm mới thành công!");
                        ChangeStatus(true);
                        isAddFlag = false;
                        khachHangTableAdapter.Fill(khachhang.KhachHang);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show($"Đã tồn tại khách hàng với ID={txtkh.Text.Trim()}. Vui lòng kiểm tra lại thông tin.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        isAddFlag = true;
                    }
                }
                else if (isEditFlag)
                {
                    khachHangTableAdapter.Update(txtkh.Text.Trim(), txtten.Text.Trim(), txtsdt.Text.Trim(), txtdiachi.Text.Trim(), txtgt.Text.Trim(), txtgc.Text.Trim());
                    MessageBox.Show("Cập nhật thành công");
                    ChangeStatus(true);
                    isEditFlag = false;
                    khachHangTableAdapter.Fill(khachhang.KhachHang);
                    Utility.EnableControl(groupBox1, false);
                }
            }
            catch (Exception)
            {
                if (isAddFlag)
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
                else if (isEditFlag)
                {
                    MessageBox.Show("Cập nhật thất bại!");
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
        }
    }
}
