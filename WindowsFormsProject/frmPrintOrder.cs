using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsProject
{
    public partial class frmPrintOrder : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection(Program.strConn);
        public frmPrintOrder()
        {
            InitializeComponent();
        }

        private void frmPrintOrder_Load(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM OrderDetail WHERE OrderID = '" + frmOrderForm.SetValueOrderID + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, con);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "OrderDetail");

            OrderCrystalReport myDataReport = new OrderCrystalReport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
