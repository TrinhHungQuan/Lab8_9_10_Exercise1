
namespace WindowsFormsProject
{
    partial class frmFilterBestItem
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.labelFilter = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.RowHeadersWidth = 62;
            this.dataGridViewItem.RowTemplate.Height = 28;
            this.dataGridViewItem.Size = new System.Drawing.Size(776, 304);
            this.dataGridViewItem.TabIndex = 0;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(56, 41);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(44, 20);
            this.labelFilter.TabIndex = 1;
            this.labelFilter.Text = "Filter";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Highest Sold",
            "Lowest Sold",
            "Highest Quantity",
            "Lowest Quantity",
            "High Sold (>=5 products)",
            "Low Sold (<5 products)"});
            this.comboBoxFilter.Location = new System.Drawing.Point(122, 41);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(384, 28);
            this.comboBoxFilter.TabIndex = 2;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // frmFilterBestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewItem);
            this.Name = "frmFilterBestItem";
            this.Text = "Filter Best Item";
            this.Load += new System.EventHandler(this.frmFilterBestItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}