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
using System.Diagnostics;

namespace WindowsFormsProject
{
    public partial class frmFilterBestItem : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        public static string valueComboBox = "";
        public frmFilterBestItem()
        {
            InitializeComponent();
        }

        private void frmFilterBestItem_Load(object sender, EventArgs e)
        {

        }

        private void LoadData1()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Item.ItemID, Item.ItemName, SUM(OrderDetail.Quantity) AS TotalSold " +
                 "FROM OrderDetail " +
                 "JOIN Item ON OrderDetail.ItemID = Item.ItemID " +
                 "GROUP BY Item.ItemID, Item.ItemName " +
                 "ORDER BY TotalSold DESC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData2()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Item.ItemID, Item.ItemName, SUM(OrderDetail.Quantity) AS TotalSold " +
                 "FROM OrderDetail " +
                 "JOIN Item ON OrderDetail.ItemID = Item.ItemID " +
                 "GROUP BY Item.ItemID, Item.ItemName " +
                 "ORDER BY TotalSold ASC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData3()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT ItemName, Size FROM Item ORDER BY Size DESC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData4()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT ItemName, Size FROM Item ORDER BY Size ASC", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData5()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Item.ItemID, Item.ItemName, Item.Size, SUM(OrderDetail.Quantity) AS TotalQuantitySold FROM OrderDetail JOIN Item ON OrderDetail.ItemID = Item.ItemID GROUP BY Item.ItemID, Item.ItemName, Item.Size HAVING SUM(OrderDetail.Quantity) >= 5", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData6()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SELECT Item.ItemID, Item.ItemName, Item.Size, SUM(OrderDetail.Quantity) AS TotalQuantitySold FROM OrderDetail JOIN Item ON OrderDetail.ItemID = Item.ItemID GROUP BY Item.ItemID, Item.ItemName, Item.Size HAVING SUM(OrderDetail.Quantity) < 5", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewItem.DataSource = dt;
                }

                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.Text == "Highest Sold")
            {
                LoadData1();
            }
            else if (comboBoxFilter.Text == "Lowest Sold")
            {
                LoadData2();
            }
            else if (comboBoxFilter.Text == "Highest Quantity")
            {
                LoadData3();
            }
            else if (comboBoxFilter.Text == "Lowest Quantity")
            {
                LoadData4();
            }
            else if (comboBoxFilter.Text == "High Sold (>=5 products)")
            {
                LoadData5();
            }
            else if (comboBoxFilter.Text == "Low Sold (<5 products)")
            {
                LoadData6();
            }
        }
    }
}
