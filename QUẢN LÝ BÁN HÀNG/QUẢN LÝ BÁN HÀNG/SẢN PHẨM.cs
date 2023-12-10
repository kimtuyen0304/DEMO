using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2TableAdapters;
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
	public partial class SẢN_PHẨM : Form
	{
		public SẢN_PHẨM()
		{
			InitializeComponent();
		}

		private void SẢN_PHẨM_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2.MatHang' table. You can move, or remove it, as needed.
			this.matHangTableAdapter.Fill(this.sp.MatHang);

		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			{
				DialogResult ch = MessageBox.Show("Bạn có muốn xóa sản phẩm " + btnxoa.Text.Trim() + "phải không", " xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ch == DialogResult.Yes)
				{
					try
					{
						matHangTableAdapter.Delete(tbMMH.Text);
						MessageBox.Show("Đã xóa");
					}
					catch (System.Exception ex) { MessageBox.Show("Có lỗi sản phẩm này" + ex.Message); }
					try
					{

						this.matHangTableAdapter.Fill(this.sp.MatHang);
					}
					catch (System.Exception) { }

				}
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			{
				if (btnsua.Text == "Sửa")
				{
					MessageBox.Show("Sửa thông tin sản phẩm");
					btnsua.Text = "Lưu";
				}
				else
				{
					try
					{
						// Parse DateTime values
						DateTime nsxDate;
						DateTime hsdDate;

						if (DateTime.TryParse(tbNSX.Text, out nsxDate) && DateTime.TryParse(tbHSD.Text, out hsdDate))
						{
							// Convert DateTime values to string with a specific format
							string formattedNSX = nsxDate.ToString("yyyy-MM-dd");
							string formattedHSD = hsdDate.ToString("yyyy-MM-dd");

							matHangTableAdapter.Update(tbTenMH.Text.Trim(), tbMMH.Text.Trim(), Int32.Parse(textgia.Text), formattedNSX, formattedHSD, Int32.Parse(tbVAT.Text), tbNH.Text.Trim());
							MessageBox.Show("Đã sửa");
						}
						else
						{
							MessageBox.Show("Ngày sản xuất (NSX) hoặc hạn sử dụng (HSD) không hợp lệ.");
						}
					}
					catch (System.Exception ex)
					{
						MessageBox.Show("Lỗi sửa sản phẩm mới: " + ex.Message);
					}
					try
					{
						this.matHangTableAdapter.Fill(this.sp.MatHang);
					}
					catch (System.Exception) { }
					btnsua.Text = "Sửa";
				}
			}


		}
			private void btnthem_Click(object sender, EventArgs e)
			{
			if (btnthem.Text == "Thêm")
			{
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				btnxoa.Enabled = false;
				btnsua.Enabled = false;
				tbMMH.Text = "";
				tbTenMH.Text = "";
				textgia.Text = "";
				tbNSX.Text = "";
				tbHSD.Text = "";
				tbVAT.Text = "";
				tbNH.Text = "";
				MessageBox.Show("Nhập thông tin sản phẩm mới");
			}
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

		private void btnluu_Click(object sender, EventArgs e)
		{
			if (btnthem.Text=="Thêm") 
			{

				// Thực hiện thêm sản phẩm mới
				matHangTableAdapter.Insert(tbTenMH.Text.Trim(), tbMMH.Text.Trim(), Int32.Parse(textgia.Text), DateTime.Parse(tbNSX.Text), DateTime.Parse(tbHSD.Text), Int32.Parse(tbVAT.Text), tbNH.Text.Trim());
				MessageBox.Show("Đã thêm");
			}
				else
				{
					try
					{
						
					}
					catch (System.Exception ex)
					{
						MessageBox.Show("Lỗi thêm sản phẩm mới: " + ex.Message);
					}
				}
try
{
	// Cập nhật dữ liệu sau khi thêm
	this.matHangTableAdapter.Fill(this.sp.MatHang);
}
catch (System.Exception) { };
btnthem.Text = "Thêm";
				}
		}
	
	}

