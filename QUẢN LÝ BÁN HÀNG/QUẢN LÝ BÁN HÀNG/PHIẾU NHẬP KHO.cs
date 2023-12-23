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
		private bool isAddFlag = false;
		private bool isEditFlag = false;

		public PHIẾU_NHẬP_KHO()
		{
			InitializeComponent();
		}

		private void PHIẾU_NHẬP_KHO_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'mathang.MatHang' table. You can move, or remove it, as needed.
			this.matHangTableAdapter1.Fill(this.mathang.MatHang);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet10.PhieuNhapKho' table. You can move, or remove it, as needed.
			this.phieuNhapKhoTableAdapter.Fill(this.pnk.PhieuNhapKho);
			// TODO: This line of code loads data into the '_8___HuynhKimTuyen__QLBH_BBN_20DTK1DataSet9.ChiTietPhieuNhapKho' table. You can move, or remove it, as needed.
			this.chiTietPhieuNhapKhoTableAdapter.Fill(this.ctpn.ChiTietPhieuNhapKho);

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
            Utility.EnableControl(groupBox1, true);

            txtpnk.ResetText();
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtMaKho.ResetText();
            txtMaMH.ResetText();
            txtSoLuong.ResetText();
            dtNgayNK.Value = DateTime.Today;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnExit.Enabled = true;
            btnMain.Enabled = true;
            btnLuu.Enabled = true;

            txtpnk.Focus();

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Utility.EnableControl(groupBox1, true);
            txtpnk.Enabled = false;
            txtMaNV.Focus();

            isEditFlag = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập kho có mã " + txtpnk.Text.Trim() + " không? ", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                try
                {
                    phieuNhapKhoTableAdapter.Delete(txtpnk.Text.Trim());
                    MessageBox.Show("Đã xóa phiếu nhập kho thành công!");
                    this.phieuNhapKhoTableAdapter.Fill(pnk.PhieuNhapKho);
                }
                catch (Exception ex) { MessageBox.Show("Có lỗi xóa phiếu nhập kho này" + ex.Message); }
            }
        }
    }
}
