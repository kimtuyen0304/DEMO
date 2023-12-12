using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUẢN_LÝ_BÁN_HÀNG;
using COMExcel = Microsoft.Office.Interop.Excel;
using QUẢN_LÝ_BÁN_HÀNG._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet1TableAdapters;
using System.Drawing.Printing;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class HÓA_ĐƠN : Form
	{
		public HÓA_ĐƠN()
		{
			InitializeComponent();
		}


		private void HÓA_ĐƠN_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet13.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.mh.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet5.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.cthd.ChiTietHoaDon);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet4.HoaDon' table. You can move, or remove it, as needed.
			this.hoaDonTableAdapter.Fill(this.hd.HoaDon);
		}

		private void btnThem_Click(object sender, EventArgs e)

		{
			txtmhd.Enabled = !txtmhd.Enabled;
			txtmhd.Enabled = !txtmhd.Enabled;
			txtmkh.Enabled = !txtmkh.Enabled;
			txtmmh.Enabled = !txtmmh.Enabled;
			txtmnv.Enabled = !txtmnv.Enabled;
			txtmpxk.Enabled = !txtmpxk.Enabled;
			txtngay.Enabled = !txtngay.Enabled;
			txtsl.Enabled = !txtsl.Enabled;
			txtthanhtien.Enabled = !txtthanhtien.Enabled;

			if (btnThem.Text == "Thêm")
			{
				txtkh.Text = "";
				txtthanhtien.Text = "";
				txtsl.Text = "";
				txtmkh.Text = "";
				txtmhd.Text = "";
				txtmmh.Text = "";
				txtmnv.Text = "";
				txtmpxk.Text = "";
				txtngay.Text = "";

				// Vô hiệu hóa các nút khác

				btnSua.Enabled = false;
				btnXoa.Enabled = false;
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				MessageBox.Show("Nhập thông tin hóa đơn mới");
				btnThem.Text = "Lưu";

			}
			else
			{
				try
				{
					// Thêm hóa đơn mới
					this.hoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtkh.Text.Trim(), txtngay.Text.Trim(), txtmkh.Text.Trim(), txtmnv.Text.Trim(), txtmpxk.Text.Trim());
					MessageBox.Show("Đã thêm");
					// Thêm chi tiết hóa đơn mới
					this.chiTietHoaDonTableAdapter.Insert(txtmhd.Text.Trim(), txtmmh.Text, Int32.Parse(txtsl.Text), Int32.Parse(txtthanhtien.Text));
					MessageBox.Show("Đã thêm");
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("Lỗi thêm khách hàng mới: " + ex.Message);
				}
				try
				{

					// Load lại dữ liệu sau khi thêm
					this.hoaDonTableAdapter.Fill(this.hd.HoaDon);
					this.chiTietHoaDonTableAdapter.Fill(this.cthd.ChiTietHoaDon);
				}
				catch (System.Exception) { };
				// Bật lại các nút khi đã thêm xong
				btnSua.Enabled = true;
				btnXoa.Enabled = true;
				btnExit.Enabled = true;
				btnMain.Enabled = true;
				btnThem.Text = "Thêm";

			} }

		private void btnXoa_Click(object sender, EventArgs e)
			{

			DialogResult ch = MessageBox.Show("Bạn có muốn xóa hóa đơn " + btnXoa.Text.Trim() + "phải không", " xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				try
				{
					chiTietHoaDonTableAdapter.Delete(txtmhd.Text);
					MessageBox.Show("Đã xóa");
				}
				catch (System.Exception ex) { MessageBox.Show("Có lỗi khách hàng này" + ex.Message); }
				try
				{

					chiTietHoaDonTableAdapter.Fill(this.cthd.ChiTietHoaDon);
				}
				catch (System.Exception) { }

			}
		}

        private void btnin_Click(object sender, EventArgs e)
        {
			var printPreviewDialog = new PrintPreviewDialog();
			printPreviewDialog.SetDesktopLocation(Left, Top);
			printPreviewDialog.ShowDialog();

        }
    }
}
	 


