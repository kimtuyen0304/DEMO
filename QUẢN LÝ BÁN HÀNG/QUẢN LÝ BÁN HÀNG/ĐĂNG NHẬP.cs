using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            var taiKhoan = Utility.Authenticate(tentk.Text, txtmk.Text);
            if(taiKhoan != null )
            {
                Utility.CurrentUser = new Utility.User();
                Utility.CurrentUser.Id = taiKhoan.Rows[0].ItemArray[1].ToString().Trim();
                Utility.CurrentUser.Role = Convert.ToInt32(Convert.ToBoolean(taiKhoan.Rows[0].ItemArray[4]));

                var main = new giaodien();
                main.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tentk.Focus();
            }
        }
    }
}



