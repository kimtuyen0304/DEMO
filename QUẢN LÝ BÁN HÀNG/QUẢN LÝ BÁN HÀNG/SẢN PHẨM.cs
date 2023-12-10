using Microsoft.SqlServer.Server;
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
		private bool isAddFlag = false;
		private bool isEditFlag = false;

		public SẢN_PHẨM()
		{
			InitializeComponent();
		}

		private void SẢN_PHẨM_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet6.NhomHang' table. You can move, or remove it, as needed.
			this.nhomHangTableAdapter.Fill(this.nhomHang.NhomHang);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet2.MatHang' table. You can move, or remove it, as needed.
			this.matHangTableAdapter.Fill(this.sp.MatHang);

		}

		private void btnxoa_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {tbMMH.Text.Trim()} không?", "Xác nhận",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				try
				{
					matHangTableAdapter.Delete(tbMMH.Text);
					MessageBox.Show("Đã xóa mặt hàng thành công!");
					matHangTableAdapter.Fill(this.sp.MatHang);
				}
				catch (Exception)
				{
					MessageBox.Show("Xóa mặt hàng thất bại!");
				}
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			Utility.EnableControl(groupBox1, true);
			tbMMH.Enabled = false;
			tbTenMH.Focus();

			ChangeStatus(false);
			btnLuu.Enabled = true;
			isEditFlag = true;
		}
		private void btnthem_Click(object sender, EventArgs e)
		{
			Utility.EnableControl(groupBox1, true);

			tbMMH.ResetText();
			tbTenMH.ResetText();
			textgia.ResetText();
			tbVAT.ResetText();
			tbNH.ResetText();
			tbTenNH.ResetText();
			tbGhiChu.ResetText();

            dtNSX.Value = DateTime.Today;
            dtHSD.Value = DateTime.Today;

            tbMMH.Focus();
			ChangeStatus(false);
			btnLuu.Enabled = true;

			isAddFlag = true;
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

		private void btnMain_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show("Bạn có chắc chắn đóng màn hình không?", "Xác nhận",
							   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
                if (isAddFlag)
                {
					if (!Utility.RecordExists(tbMMH.Text.Trim()))
					{
						if (!Utility.RecordExists(tbNH.Text.Trim()))
						{
                            nhomHangTableAdapter.Insert(tbNH.Text.Trim(), tbTenNH.Text, tbGhiChu.Text);
                        }

						matHangTableAdapter.Insert(tbTenMH.Text, tbMMH.Text.Trim(), Convert.ToInt32(textgia.Text),
							dtNSX.Value, dtHSD.Value, Convert.ToInt32(tbVAT.Text), tbNH.Text);
						
						MessageBox.Show("Thêm mới mặt hàng thành công!");

                        nhomHangTableAdapter.Fill(nhomHang.NhomHang);
                        matHangTableAdapter.Fill(sp.MatHang);
                        ChangeStatus(true);
                    }
                }
                else if (isEditFlag)
                {
					if (DateTime.TryParse(dtNSX.Value.ToString(), out DateTime nsxDate) && DateTime.TryParse(dtHSD.Value.ToString(), out DateTime hsdDate))
					{
						string formattedNSX = nsxDate.ToString("yyyy-MM-dd");
						string formattedHSD = hsdDate.ToString("yyyy-MM-dd");

						matHangTableAdapter.Update(tbTenMH.Text.Trim(), tbMMH.Text.Trim(), Int32.Parse(textgia.Text), formattedNSX, formattedHSD, Int32.Parse(tbVAT.Text), tbNH.Text.Trim());
						MessageBox.Show("Cập nhật thành công!");
						matHangTableAdapter.Fill(sp.MatHang);
						isEditFlag = false;
						ChangeStatus(true);
						Utility.EnableControl(groupBox1, false);
					}
					else
					{
						MessageBox.Show("Ngày sản xuất (NSX) hoặc hạn sử dụng (HSD) không hợp lệ!", "Lỗi",
							MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
					}
				}
            }
			catch (Exception)
			{
				if (isAddFlag)
				{
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi", 
						MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else if (isEditFlag)
				{
					MessageBox.Show("Cập nhật thất bại!", "Lỗi", 
						MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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


