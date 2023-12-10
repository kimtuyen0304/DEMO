using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class NHÂN_VIÊN : Form
	{
		public NHÂN_VIÊN()
		{
			InitializeComponent();
		}

		private void NHÂN_VIÊN_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet.NhanVien' table. You can move, or remove it, as needed.
			this.nhanVienTableAdapter.Fill(this.dlnv.NhanVien);

		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			txtten.Enabled = !txtten.Enabled;
			txtmnv.Enabled = !txtmnv.Enabled;
			txtpb.Enabled = !txtpb.Enabled;
			txtsdt.Enabled = !txtsdt.Enabled;
			txtmcv.Enabled = !txtmcv.Enabled;
			txtnvl.Enabled = !txtnvl.Enabled;
			btnsua.Enabled = !btnsua.Enabled;
			btnxoa.Enabled = !btnxoa.Enabled;

			if (btnthem.Text == "Thêm")
			{
				txtmnv.Text = "";
				txtten.Text = "";
				txtsdt.Text = "";
				txtpb.Text = "";
				txtmcv.Text = "";
				txtnvl.Text = "";
				
				MessageBox.Show("Nhập thông tin nhân viên mới");
				btnthem.Text = "Lưu";
			}
			else
			{
				try
				{
					// Check if the record already exists
					if (!RecordExists(txtmnv.Text.Trim()))
					{
						nhanVienTableAdapter.Insert(txtmnv.Text.Trim(), txtten.Text.Trim(), Int32.Parse(txtsdt.Text), txtpb.Text.Trim(), txtmcv.Text.Trim(), txtnvl.Text.Trim());
						
						MessageBox.Show("Đã Thêm");
					}
					else
					{
						MessageBox.Show("Nhân viên đã tồn tại. Vui lòng kiểm tra lại mã nhân viên.");
					}
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("Lỗi thêm nhân viên mới: " + ex.Message);
				}

				try
				{
					this.nhanVienTableAdapter.Fill(dlnv.NhanVien);
				}
				catch (System.Exception) { };
				btnthem.Text = "Thêm";
			}
		}

		// Function to check if a record with the given primary key exists
		private bool RecordExists(string primaryKey)
		{
			// Your logic to check if a record with the given primary key exists
			// Return true if exists, false otherwise
			// Example: replace this with your actual logic
			return YourDatabaseCheckIfRecordExists(primaryKey);
		}

		// Replace this function with your actual logic to check if a record exists in the database
		private bool YourDatabaseCheckIfRecordExists(string primaryKey)
		{
			// Your database query logic to check if a record with the given primary key exists
			// Return true if exists, false otherwise
			// Example: replace this with your actual database query logic
			// For example, if using Entity Framework:
			// return context.NhanVien.Any(nv => nv.MaNhanVien == primaryKey);

			// For now, assuming it doesn't exist to avoid compilation errors
			return false;
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

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (btnsua.Text == "Sửa")
			{
				MessageBox.Show("Sửa thông tin nhân viên");
				btnsua.Text = "Lưu";
				btnthem.Enabled = !btnsua.Enabled;
				btnxoa.Enabled = !btnxoa.Enabled;
			}
			else
			{
				try
				{
					if (int.TryParse(txtsdt.Text.Trim(), out int phoneNumber))
					{
						nhanVienTableAdapter.Update(txtmnv.Text.Trim(), txtten.Text.Trim(), phoneNumber, txtpb.Text.Trim(), txtmcv.Text.Trim(), txtnvl.Text.Trim());
						MessageBox.Show("Đã Sửa");
						
					}
					else
					{
						MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
				}
				catch (System.Exception ex)
				{ MessageBox.Show("Lỗi sửa nhân viên mới :" + ex.Message); }
				try
				{
					this.nhanVienTableAdapter.Fill(dlnv.NhanVien);
				}
				catch (System.Exception) { }
				btnsua.Text = "Sửa";
			}
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show("Xóa nhân viên có mã " + txtmnv.Text.Trim() + " không(Y/N) ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				try
				{
					nhanVienTableAdapter.Delete(txtmnv.Text.Trim());
					MessageBox.Show("Đã xóa");
				}
				catch (System.Exception ex) { MessageBox.Show("Có lỗi xóa nhân viên này" + ex.Message); }

			}
			try
			{

				this.nhanVienTableAdapter.Fill(dlnv.NhanVien);
			}
			catch (System.Exception) { }
		}
	}
}
	