using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class frmPreview : Form
    {
        public DataTable DataSource;

        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            rptViewer.Reset();
            rptViewer.LocalReport.ReportPath = Application.StartupPath + "../../../ReportTemplate/DanhSachHoaDon.rdlc";
            var rptDataSource = new ReportDataSource("DataSet1", DataSource);
            rptViewer.LocalReport.DataSources.Clear();
            rptViewer.LocalReport.DataSources.Add(rptDataSource);
            this.rptViewer.RefreshReport();
        }
    }
}
