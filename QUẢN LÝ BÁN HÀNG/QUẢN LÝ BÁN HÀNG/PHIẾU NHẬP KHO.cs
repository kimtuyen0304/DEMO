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
	public partial class PHIẾU_NHẬP_KHO : Form
	{
		public PHIẾU_NHẬP_KHO()
		{
			InitializeComponent();
		}

		private void PHIẾU_NHẬP_KHO_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'mathang.MatHang' table. You can move, or remove it, as needed.
			this.matHangTableAdapter1.Fill(this.mathang.MatHang);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet12.MatHang' table. You can move, or remove it, as needed.
		//	this.matHangTableAdapter.Fill(this._8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet12.MatHang);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet10.PhieuNhapKho' table. You can move, or remove it, as needed.
			this.phieuNhapKhoTableAdapter.Fill(this.pnk.PhieuNhapKho);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet9.ChiTietPhieuNhapKho' table. You can move, or remove it, as needed.
			this.chiTietPhieuNhapKhoTableAdapter.Fill(this.ctpn.ChiTietPhieuNhapKho);

		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
