using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class NHÂN_VIÊN : Form
	{
		private bool isAddFlag = false;
		private bool isEditFlag = false;

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
            Utility.EnableControl(groupBox1, true);

			txtmnv.ResetText();
			txtmcv.ResetText();
			txtnvl.ResetText();
			txtpb.ResetText();
			txtsdt.ResetText();
			txtten.ResetText();

			btnthem.Enabled = false;
			btnsua.Enabled = false;
			btnxoa.Enabled = false;
			btnExit.Enabled = true;
			btnMain.Enabled = true;
			btnLuu.Enabled = true;
			
			txtmnv.Focus();

			isAddFlag = true;
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
			DialogResult ch = MessageBox.Show(" Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
			Utility.EnableControl(groupBox1, true);
			txtmnv.Enabled = false;
			txtten.Focus();

			isEditFlag = true;
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa nhân viên có mã " + txtmnv.Text.Trim() + " không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				try
				{
					nhanVienTableAdapter.Delete(txtmnv.Text.Trim());
					MessageBox.Show("Đã xóa nhân viên thành công!");
                    this.nhanVienTableAdapter.Fill(dlnv.NhanVien);
                }
				catch (Exception ex) { MessageBox.Show("Có lỗi xóa nhân viên này" + ex.Message); }
			}
		}

        private void btnLuu_Click(object sender, EventArgs e)
        {
			try
			{
                if (isAddFlag)
                {
					if (!Utility.RecordExists(dlnv.NhanVien.Rows, txtmnv.Text.Trim()))
					{
                        nhanVienTableAdapter.Insert(txtmnv.Text.Trim(), txtten.Text.Trim(), Int32.Parse(txtsdt.Text), txtpb.Text.Trim(), txtmcv.Text.Trim(), txtnvl.Text.Trim());
                        MessageBox.Show("Thêm mới thành công!");
                        isAddFlag = false;
						ChangeStatus(true);
                        this.nhanVienTableAdapter.Fill(dlnv.NhanVien);
                        Utility.EnableControl(groupBox1, false);
                    }
					else
					{
						MessageBox.Show($"Đã tồn tại nhân viên với ID={txtmnv.Text.Trim()}. Vui lòng kiểm tra lại thông tin.","Lỗi", 
							MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
						isAddFlag = true;
					}
                }
                else if (isEditFlag)
                {
                    if (int.TryParse(txtsdt.Text.Trim(), out int phoneNumber))
                    {
                        nhanVienTableAdapter.Update(txtmnv.Text.Trim(), txtten.Text.Trim(), phoneNumber, txtpb.Text.Trim(), txtmcv.Text.Trim(), txtnvl.Text.Trim());
                        MessageBox.Show("Cập nhật thành công!");
						isEditFlag = false;
						ChangeStatus(true);
						nhanVienTableAdapter.Fill(dlnv.NhanVien);
                        Utility.EnableControl(groupBox1, false);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
			catch (Exception)
			{
				if (isAddFlag)
				{
					MessageBox.Show("Thêm mới thất bại");
					isAddFlag = true;
				}
				else if (isEditFlag)
				{
					MessageBox.Show("Cập nhật thất bại!");
					isEditFlag = true;
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
	