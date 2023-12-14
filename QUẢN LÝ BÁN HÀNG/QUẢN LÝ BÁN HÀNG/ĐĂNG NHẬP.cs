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
		private Dictionary<string, string> accounts = new Dictionary<string, string>();

		public dangnhap()
		{
			InitializeComponent();
			accounts.Add("ketoan", "123");
			accounts.Add("kinhdoanh", "456");
			accounts.Add("banhang", "789");
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
				f.ShowDialog();
				this.Hide();

			}

			else
			{
				MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
			}

		}

		private bool kiemtradangnhap(string username, string password)
		{
			foreach(string key in accounts.Keys)
			{
				if(key == username && accounts[key] == password)
				{
					return true;
				}
			}
			return false;
		}

    } 
} 



