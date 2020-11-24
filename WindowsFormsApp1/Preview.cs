using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", Class1.Tab1);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void Preview_Load_1(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
