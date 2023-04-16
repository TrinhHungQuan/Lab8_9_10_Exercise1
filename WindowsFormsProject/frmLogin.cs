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
    public partial class frmLogin : Form
    {

        public string messageboxText;

        public frmLogin()
        {
            InitializeComponent();
           

        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            //conn.ConnectionString = @"Data Source=LAPTOP-SJ19AVB1\SQLEXPRESS; Initial Catalog=LabDB; Integrated Security=True";
            conn.Open();
            String sSQL = "SELECT UserID, Password FROM tblUsers WHERE " +
                        "UserID='" + txtUserID.Text + "' and Password= '" + txtPassword.Text + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                
                this.Close();
                messageboxText = "Login Successful!";
            }
            else
            {
                MessageBox.Show("Wrong UserID or Password!");
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public void SetUserID(string userID)
        {
            txtUserID.Text = userID;
           

        }
    }
}
