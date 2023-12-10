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
	public partial class PHIẾU_THU : Form
	{
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
			DialogResult ch = MessageBox.Show("Bạn có chắc chắn đóng màn hình không (Y/N)", "Xác nhận",
							   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				this.Close();
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
			textmpt.Enabled = !textmpt.Enabled;
			textmhd.Enabled = !textmhd.Enabled;
			textmkh.Enabled = !textmkh.Enabled;
			textmnv.Enabled = !textmnv.Enabled;
			textngay.Enabled = !textngay.Enabled;
			textpt.Enabled = !textpt.Enabled;
			texttien.Enabled = !texttien.Enabled;

			if (btnthem.Text == "Thêm")
			{
				textmpt.Text = " ";
				textmnv.Text = " ";
				textmhd.Text = " ";
				textmkh.Text = " ";
				textngay.Text = " ";
				texttien.Text = " ";
				textpt.Text = " ";	

				// Vô hiệu hóa các nút khác

				btnsua.Enabled = false;
				btnxoa.Enabled = false;
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				MessageBox.Show("Nhập thông tin phiếu thu mới");
				btnthem.Text = "Lưu";

			}
			else
			{
				try
				{
					thuTienKhachHangTableAdapter.Insert(textmpt.Text.Trim(), Int32.Parse( texttien.Text), textngay.Text.Trim(), textpt.Text.Trim(), textmkh.Text.Trim(), textmnv.Text.Trim(), textmhd.Text.Trim());
					MessageBox.Show("Đã thêm");
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("Lỗi thêm khách hàng mới: " + ex.Message);
				}

				try
				{
					// Cập nhật dữ liệu sau khi thêm
					this.thuTienKhachHangTableAdapter.Fill(this.pt.ThuTienKhachHang);
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

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (btnsua.Text == "Sửa")
			{
				// Hiển thị thông báo trước khi sửa
				MessageBox.Show("Sửa thông tin phiếu thu");

				// Tắt các nút Thêm và Xóa khi đang trong chế độ sửa
				btnthem.Enabled = !btnsua.Enabled;
				btnxoa.Enabled = !btnxoa.Enabled;

				// Đổi văn bản của nút Sửa thành Lưu
				btnsua.Text = "Lưu";
			}
			else
			{
				try
				{
					// Sử dụng parameterized query để tránh SQL Injection
					thuTienKhachHangTableAdapter.Update(
						textmpt.Text.Trim(),
						Int32.Parse(texttien.Text),
						textngay.Text.Trim(),
						textpt.Text.Trim(),
						textmkh.Text.Trim(),
						textmnv.Text.Trim(),
						textmhd.Text.Trim()
					);

					// Hiển thị thông báo sau khi đã sửa thành công
					MessageBox.Show("Đã sửa");

					// Load lại dữ liệu sau khi đã sửa
					this.thuTienKhachHangTableAdapter.Fill(this.pt.ThuTienKhachHang);
				}
				catch (System.Exception ex)
				{
					// Hiển thị thông báo lỗi nếu có lỗi xảy ra
					MessageBox.Show("Lỗi sửa phiếu thu mới: " + ex.Message);
				}

				// Đặt lại văn bản của nút Sửa về trạng thái ban đầu
				btnsua.Text = "Sửa";
				btnthem.Enabled = true;
				btnxoa.Enabled = true;
			}
		}

	}
}

