using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void addingProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddingProduct frm = new frmAddingProduct();
            frm.Show();
        }

        private void addingAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddingAgent frm = new frmAddingAgent();
            frm.Show();
        }

        private void ordersFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderForm frm = new frmOrderForm();
            frm.Show();
        }

        private void bestItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilterBestItem frm = new frmFilterBestItem();
            frm.Show();
        }
    }
}
