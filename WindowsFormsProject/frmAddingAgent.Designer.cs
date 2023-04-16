
namespace WindowsFormsProject
{
    partial class frmAddingAgent
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
            this.labelAgentID = new System.Windows.Forms.Label();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(578, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelAgentID
            // 
            this.labelAgentID.AutoSize = true;
            this.labelAgentID.Location = new System.Drawing.Point(25, 48);
            this.labelAgentID.Name = "labelAgentID";
            this.labelAgentID.Size = new System.Drawing.Size(73, 20);
            this.labelAgentID.TabIndex = 1;
            this.labelAgentID.Text = "Agent ID";
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Location = new System.Drawing.Point(25, 100);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(98, 20);
            this.labelAgentName.TabIndex = 2;
            this.labelAgentName.Text = "Agent Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(25, 153);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(135, 48);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(204, 26);
            this.txtAgentID.TabIndex = 4;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(135, 94);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(204, 26);
            this.txtAgentName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 66);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddingAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelAgentName);
            this.Controls.Add(this.labelAgentID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAddingAgent";
            this.Text = "Adding Agent";
            this.Load += new System.EventHandler(this.frmAddingAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAgentID;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
    }
}