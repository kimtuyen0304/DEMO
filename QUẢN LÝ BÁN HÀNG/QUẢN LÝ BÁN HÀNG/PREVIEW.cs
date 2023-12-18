using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_HÀNG
{
    public partial class frmPreview : Form
    {
        public DataTable DataSource;
        public ReportParameterCollection Parameters;
        public string TemplateReportPath;

        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            rptViewer.Reset();
            rptViewer.LocalReport.ReportPath = Application.StartupPath + $"../../../ReportTemplate/{TemplateReportPath}";
            var rptDataSource = new ReportDataSource("DataSet", DataSource);
            rptViewer.LocalReport.DataSources.Clear();
            var settings = rptViewer.GetPageSettings();
            settings.Margins = new System.Drawing.Printing.Margins(5, 5, 2, 2);
            settings.Landscape = true;
            rptViewer.SetPageSettings(settings);
            if(Parameters != null && Parameters.Count > 0)
            {
                rptViewer.LocalReport.SetParameters(Parameters);
            }
            rptViewer.LocalReport.DataSources.Add(rptDataSource);
            this.rptViewer.RefreshReport();
        }

		private void rptViewer_Load(object sender, EventArgs e)
		{

		}
	}
}
