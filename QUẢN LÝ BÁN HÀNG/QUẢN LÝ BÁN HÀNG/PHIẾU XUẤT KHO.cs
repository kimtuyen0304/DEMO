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
	public partial class PHIẾU_XUẤT_KHO : Form
	{
		public PHIẾU_XUẤT_KHO()
		{
			InitializeComponent();
		}

		private void PHIẾU_XUẤT_KHO_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet25.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.mathang.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet24.PhieuXuatKho' table. You can move, or remove it, as needed.
            this.phieuXuatKhoTableAdapter.Fill(this.pxk.PhieuXuatKho);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet23.ChiTietPhieuXuatKho' table. You can move, or remove it, as needed.
            this.chiTietPhieuXuatKhoTableAdapter.Fill(this.ctpxk.ChiTietPhieuXuatKho);

        }
    }
}
