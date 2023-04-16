
namespace WindowsFormsProject
{
    partial class frmAddingProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelItemID = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(617, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(13, 40);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(58, 20);
            this.labelItemID.TabIndex = 1;
            this.labelItemID.Text = "ItemID";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(13, 84);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(87, 20);
            this.labelItemName.TabIndex = 2;
            this.labelItemName.Text = "Item Name";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(13, 133);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(40, 20);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(109, 33);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(214, 26);
            this.txtItemID.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(109, 84);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(214, 26);
            this.txtItemName.TabIndex = 5;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(109, 133);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(214, 26);
            this.txtSize.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(147, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 65);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 513);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelItemID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAddingProduct";
            this.Text = "Adding Product";
            this.Load += new System.EventHandler(this.frmAddingProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAdd;
    }
}