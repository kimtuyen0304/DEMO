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
	public partial class HÀNG_BÁN_TRẢ_LẠI : Form
	{
		public HÀNG_BÁN_TRẢ_LẠI()
		{
			InitializeComponent();
		}

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

		private void HÀNG_BÁN_TRẢ_LẠI_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet14.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.mh.MatHang);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet7.ChiTietHangBanTraLai' table. You can move, or remove it, as needed.
            this.chiTietHangBanTraLaiTableAdapter.Fill(this.cthbtl.ChiTietHangBanTraLai);
            // TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet8.HangBanTraLai' table. You can move, or remove it, as needed.
            this.hangBanTraLaiTableAdapter.Fill(this.hbtl.HangBanTraLai);

        }
    }
}
