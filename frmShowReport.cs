using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLKS2
{
    public partial class frmShowReport : Form
    {
        public frmShowReport()
        {
            InitializeComponent();
        }

        private void frmShowReport_Load(object sender, EventArgs e)
        {
            // Reset báo cáo
            reportViewer1.Reset();

            // Dùng embedded report (đã nhúng vào trong project)
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS2.report1.rdlc";

            LoadReport(DateTime.MinValue, DateTime.MaxValue);
            reportViewer1.Visible = false;
        }



        private void btnXuatra_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            LoadReport(from, to);
            reportViewer1.Visible = true;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            LoadReport(DateTime.MinValue, DateTime.MaxValue);
        }


        private void LoadReport(DateTime from, DateTime to)
        {
            // Câu SQL có lọc theo Ngay_thanhtoan
            string query = $@"
                SELECT * FROM Hoadon_tong
                WHERE Ngay_thanhtoan >= '{from:yyyy-MM-dd}' AND Ngay_thanhtoan <= '{to:yyyy-MM-dd}'";

            DataTable dt = Modify.GetDataToTable(query);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS2.Report1.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
