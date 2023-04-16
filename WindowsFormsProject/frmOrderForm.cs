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

namespace WindowsFormsProject
{
    public partial class frmOrderForm : Form
    {
        public static string SetValueOrderID = "";
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmOrderForm()
        {
            InitializeComponent();
        }

        private void frmOrderForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT OrderID FROM Orders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                comboBoxOrderID.DataSource = dt;
                comboBoxOrderID.DisplayMember = "OrderID";
                comboBoxOrderID.ValueMember = "OrderID";
                LoadData();
            }
            else
            {
                MessageBox.Show("No Data");
            }
            adapter.Dispose();
        }

        private void LoadData()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetail WHERE OrderID='" + comboBoxOrderID.SelectedValue + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SetValueOrderID = comboBoxOrderID.SelectedValue.ToString();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewOrderDetail.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetail", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
         
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewOrderDetail.DataSource = dt;

                }
                adapter.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintOrder f = new frmPrintOrder();
            f.Show();
        }
    }
}
