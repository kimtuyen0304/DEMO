using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
	public partial class giaodien : Form
	{
		public giaodien()
		{
			InitializeComponent();
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dangnhap fr = new dangnhap();
			fr.ShowDialog();
			this.Close();
		}

		private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dangnhap fr = new dangnhap();
			fr.ShowDialog();
		}

		private void lbtime_Click(object sender, EventArgs e)
		{
			lbtime.Text = System.DateTime.Now.ToLongTimeString();
		}

		private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult ch = MessageBox.Show("Thoát Khỏi Chương trình (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ch == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbtime.Text = System.DateTime.Now.ToLongTimeString();
		}

		private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NHÂN_VIÊN fr = new NHÂN_VIÊN();
			fr.ShowDialog();
		}

		private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KHÁCH_HÀNG fr = new KHÁCH_HÀNG();
			fr.ShowDialog();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}

		private void nhậpKhoHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
		{
		SẢN_PHẨM fr = new SẢN_PHẨM();
			fr.ShowDialog();
		}

		private void lậpPhiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PHIẾU_THU fr = new PHIẾU_THU();
			fr.ShowDialog();
		}

		private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HÓA_ĐƠN fr = new HÓA_ĐƠN();
			fr.ShowDialog();

		}

		private void lậpĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PHIẾU_GIAO_HÀNG fr = new PHIẾU_GIAO_HÀNG();
			fr.ShowDialog();
		}

		private void hàngBánTrảLạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HÀNG_BÁN_TRẢ_LẠI fr = new HÀNG_BÁN_TRẢ_LẠI();
			fr.ShowDialog();
		}

		private void lậpPhiếuNhậpThànhPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PHIẾU_NHẬP_KHO fr = new PHIẾU_NHẬP_KHO();
			fr.ShowDialog();
		}

		private void lậpPhiếuXuấtThànhPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PHIẾU_XUẤT_KHO fr = new PHIẾU_XUẤT_KHO();
			fr.ShowDialog();
		}
	}
}
 