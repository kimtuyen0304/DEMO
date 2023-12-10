using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class KHÁCH_HÀNG : Form
	{
		public KHÁCH_HÀNG()
		{
			InitializeComponent();
		}

		private void KHÁCH_HÀNG_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.khachhang.KhachHang);

        }

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show(" Thoát chương trình (Y/N)", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			{
				if (ch == DialogResult.Yes)
				{
					Application.Exit();
				}
			}
			this.Close();
		}

		private void btnMain_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show("Bạn có chắc chắn đóng màn hình không (Y/N)", "Xác nhận",
							   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			txtten.Enabled = !txtten.Enabled;
			txtkh.Enabled = !txtkh.Enabled;
			txtsdt.Enabled = !txtsdt.Enabled;
			txtdiachi.Enabled = !txtdiachi.Enabled;


			if (btnthem.Text == "Thêm")
			{
				txtkh.Text = "";
				txtten.Text = "";
				txtdiachi.Text = "";
				txtsdt.Text = "";
				txtgc.Text = "";
				txtgt.Text = "";
				// Vô hiệu hóa các nút khác
				
			
				
				btnsua.Enabled = false;
				btnxoa.Enabled = false;
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				MessageBox.Show("Nhập thông tin khách hàng mới");
				btnthem.Text = "Lưu";

			}
			else
			{
				try
				{
					khachHangTableAdapter.Insert(txtkh.Text.Trim(), txtten.Text.Trim(), txtsdt.Text.Trim() ,txtdiachi.Text.Trim(),txtgt.Text.Trim(),txtgc.Text.Trim() );
					MessageBox.Show("Đã thêm");
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("Lỗi thêm khách hàng mới: " + ex.Message);
				}

				try
				{
					// Cập nhật dữ liệu sau khi thêm
					this.khachHangTableAdapter.Fill(khachhang.KhachHang);
				}
				catch (System.Exception) { };

				// Bật lại các nút khi đã thêm xong
				btnsua.Enabled = true;
				btnxoa.Enabled = true;
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				btnthem.Text = "Thêm";
			}
		}

		

		private void btnxoa_Click(object sender, EventArgs e)
		{
			{
				DialogResult ch = MessageBox.Show("Bạn có muốn xóa nhân viên " + btnxoa.Text.Trim() + "phải không", " xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ch == DialogResult.Yes)
				{
					try
					{
						khachHangTableAdapter.Delete(txtkh.Text);
						MessageBox.Show("Đã xóa");
					}
					catch (System.Exception ex) { MessageBox.Show("Có lỗi khách hàng này" + ex.Message); }
					try
					{

						this.khachHangTableAdapter.Fill(this.khachhang.KhachHang);
					}
					catch (System.Exception) { }

				}
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (btnsua.Text == "Sửa")
			{
				MessageBox.Show("Sửa thông tin khách hàng");
				btnthem.Enabled = !btnsua.Enabled;
				btnxoa.Enabled = !btnxoa.Enabled;
				btnsua.Text = "Lưu";
			}
			else
			{
				try
				{
					khachHangTableAdapter.Update(txtkh.Text.Trim(), txtten.Text.Trim(), txtsdt.Text.Trim(), txtdiachi.Text.Trim(), txtgt.Text.Trim(), txtgc.Text.Trim());
					
					MessageBox.Show("Đã sửa");
					
				}
				catch (System.Exception ex)
				{ MessageBox.Show("Lỗi sửa khách hàng mới:" + ex.Message); }
				try
				{

					this.khachHangTableAdapter.Fill(this.khachhang.KhachHang);
				}
				catch (System.Exception) { }
				btnsua.Text = "Sửa";
			}
		}
	}
}
