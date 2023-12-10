using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class dangnhap : Form
	{
		
		private readonly string adminketoan = "ketoan";
		private readonly string ketoanpassword = "123";
		private readonly string adminkinhdoanh = "kinhdoanh";
		private readonly string kinhdoanhpassword = "456";
		private readonly string adminbanhang = "banhang";
		private readonly string banhangpassword = "789";

		public dangnhap()
		{
			InitializeComponent();
		}

		private void btndangnhap_Click(object sender, EventArgs e)
		{
			string enteredUsername = tentk.Text;
			string enteredPassword = txtmk.Text;

			// Kiểm tra tên đăng nhập và mật khẩu
			if (kiemtradangnhap(enteredUsername, enteredPassword))
			{
				MessageBox.Show("Đăng Nhập Thành Công");
			giaodien f = new giaodien();
				f.Show();
				this.Hide();

			}

			else
			{
				MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
			}

		}

			private bool kiemtradangnhap(string username, string password)
			{
				if ((username == adminketoan && password == ketoanpassword) ||
					   (username == adminkinhdoanh && password == kinhdoanhpassword) ||
					   (username == adminbanhang && password == banhangpassword))
				{ return true; }
				return false;
			}
		} } 



