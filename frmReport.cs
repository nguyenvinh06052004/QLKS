using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLKS2
{
    public partial class frmReport : Form
    {
      
        public frmReport(DateTime from, DateTime to)
        {
            InitializeComponent();
           
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
        //    string query = $"SELECT * FROM Hoadon_tong WHERE Ngay_thanhtoan BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'";

            //    reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS2.Report1.rdlc";
            //    ReportDataSource reportDataSource = new ReportDataSource
            //    {
            //        Name = "DataSet1",
            //        Value = Modify.GetDataToTable(query)
            //    };

            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //    reportViewer1.RefreshReport();
            }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }


        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}
