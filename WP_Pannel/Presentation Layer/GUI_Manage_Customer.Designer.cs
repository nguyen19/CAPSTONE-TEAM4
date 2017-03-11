namespace WP_Pannel.Presentation_Layer
{
    partial class GUI_Manage_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgCustumer = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSearchManageCustomer = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnShowCus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustumer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(900, 20);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(165, 76);
            this.btnAddCustomer.TabIndex = 16;
            this.btnAddCustomer.Text = "+ Khách hàng";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgCustumer
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustumer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustumer.Location = new System.Drawing.Point(48, 111);
            this.dgCustumer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCustumer.Name = "dgCustumer";
            this.dgCustumer.RowTemplate.Height = 24;
            this.dgCustumer.Size = new System.Drawing.Size(1071, 450);
            this.dgCustumer.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Tìm kiếm";
            // 
            // txtSearchManageCustomer
            // 
            this.txtSearchManageCustomer.Location = new System.Drawing.Point(48, 48);
            this.txtSearchManageCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchManageCustomer.Name = "txtSearchManageCustomer";
            this.txtSearchManageCustomer.Size = new System.Drawing.Size(284, 22);
            this.txtSearchManageCustomer.TabIndex = 12;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(704, 20);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(165, 76);
            this.btnEditCustomer.TabIndex = 17;
            this.btnEditCustomer.Text = "Chi tiết khách hàng";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(338, 47);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(70, 23);
            this.btnSearchCustomer.TabIndex = 18;
            this.btnSearchCustomer.Text = "Tìm Khách hàng";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnShowCus
            // 
            this.btnShowCus.Location = new System.Drawing.Point(514, 20);
            this.btnShowCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCus.Name = "btnShowCus";
            this.btnShowCus.Size = new System.Drawing.Size(165, 76);
            this.btnShowCus.TabIndex = 19;
            this.btnShowCus.Text = "Hiển thị khách hàng";
            this.btnShowCus.UseVisualStyleBackColor = true;
            this.btnShowCus.Click += new System.EventHandler(this.btnShowCus_Click);
            // 
            // GUI_Manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 615);
            this.Controls.Add(this.btnShowCus);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgCustumer);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSearchManageCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_Manage_Customer";
            this.Text = "GUI_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgCustumer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSearchManageCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnShowCus;
    }
}