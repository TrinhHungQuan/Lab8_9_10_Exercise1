
namespace WindowsFormsProject
{
    partial class frmOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.comboBoxOrderID = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOrderDetail);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(28, 75);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(70, 20);
            this.labelOrderID.TabIndex = 1;
            this.labelOrderID.Text = "Order ID";
            // 
            // comboBoxOrderID
            // 
            this.comboBoxOrderID.FormattingEnabled = true;
            this.comboBoxOrderID.Location = new System.Drawing.Point(104, 72);
            this.comboBoxOrderID.Name = "comboBoxOrderID";
            this.comboBoxOrderID.Size = new System.Drawing.Size(336, 28);
            this.comboBoxOrderID.TabIndex = 2;
            this.comboBoxOrderID.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderID_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(485, 60);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(129, 51);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(653, 60);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 51);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridViewOrderDetail
            // 
            this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetail.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            this.dataGridViewOrderDetail.RowHeadersWidth = 62;
            this.dataGridViewOrderDetail.RowTemplate.Height = 28;
            this.dataGridViewOrderDetail.Size = new System.Drawing.Size(866, 264);
            this.dataGridViewOrderDetail.TabIndex = 0;
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 496);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.comboBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.frmOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.ComboBox comboBoxOrderID;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetail;
    }
}