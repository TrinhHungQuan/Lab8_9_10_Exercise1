
namespace WindowsFormsProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterBestItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addingFormToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.filterBestItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addingFormToolStripMenuItem
            // 
            this.addingFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addingProductToolStripMenuItem,
            this.addingAgentsToolStripMenuItem});
            this.addingFormToolStripMenuItem.Name = "addingFormToolStripMenuItem";
            this.addingFormToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.addingFormToolStripMenuItem.Text = "Adding Form";
            // 
            // addingProductToolStripMenuItem
            // 
            this.addingProductToolStripMenuItem.Name = "addingProductToolStripMenuItem";
            this.addingProductToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.addingProductToolStripMenuItem.Text = "Adding Product";
            this.addingProductToolStripMenuItem.Click += new System.EventHandler(this.addingProductToolStripMenuItem_Click);
            // 
            // addingAgentsToolStripMenuItem
            // 
            this.addingAgentsToolStripMenuItem.Name = "addingAgentsToolStripMenuItem";
            this.addingAgentsToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.addingAgentsToolStripMenuItem.Text = "Adding Agents";
            this.addingAgentsToolStripMenuItem.Click += new System.EventHandler(this.addingAgentsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersFormToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // ordersFormToolStripMenuItem
            // 
            this.ordersFormToolStripMenuItem.Name = "ordersFormToolStripMenuItem";
            this.ordersFormToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.ordersFormToolStripMenuItem.Text = "Orders Form";
            this.ordersFormToolStripMenuItem.Click += new System.EventHandler(this.ordersFormToolStripMenuItem_Click);
            // 
            // filterBestItemToolStripMenuItem
            // 
            this.filterBestItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestItemToolStripMenuItem});
            this.filterBestItemToolStripMenuItem.Name = "filterBestItemToolStripMenuItem";
            this.filterBestItemToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.filterBestItemToolStripMenuItem.Text = "Filter";
            // 
            // bestItemToolStripMenuItem
            // 
            this.bestItemToolStripMenuItem.Name = "bestItemToolStripMenuItem";
            this.bestItemToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bestItemToolStripMenuItem.Text = "Best Item";
            this.bestItemToolStripMenuItem.Click += new System.EventHandler(this.bestItemToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterBestItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestItemToolStripMenuItem;
    }
}