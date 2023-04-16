using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class frmAddingProduct : Form
    {
        public frmAddingProduct()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(Program.strConn);
            //con.ConnectionString = @"Data Source=LAPTOP-SJ19AVB1\SQLEXPRESS; Initial Catalog=LabDB; Integrated Security=True";
            con.Open();

            String sSQL = "Select * from Item";
            SqlCommand cmd = new SqlCommand(sSQL, con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtSize.Text = "";

        }
        private void frmAddingProduct_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "SELECT * FROM Item ";

            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            String sSQL = "INSERT INTO Item (ItemID, ItemName, Size) VALUES(@ItemID, @ItemName, @Size)";
            SqlCommand cmd = new SqlCommand(sSQL, conn);

            cmd.Parameters.Add(new SqlParameter("@ItemID", txtItemID.Text));
            cmd.Parameters.Add(new SqlParameter("@ItemName", txtItemName.Text));
            cmd.Parameters.Add(new SqlParameter("@Size", txtSize.Text));
           
            

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            MessageBox.Show("Save Successfully!");
            DisplayData();
            ClearData();
        }
    }
}
