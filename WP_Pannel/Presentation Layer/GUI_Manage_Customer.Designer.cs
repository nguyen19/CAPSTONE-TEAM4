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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgCustumer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSearchManageCustomer = new System.Windows.Forms.TextBox();
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
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(776, 73);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Chi tiết";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dgCustumer
            // 
            this.dgCustumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column7});
            this.dgCustumer.Location = new System.Drawing.Point(48, 111);
            this.dgCustumer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCustumer.Name = "dgCustumer";
            this.dgCustumer.RowTemplate.Height = 24;
            this.dgCustumer.Size = new System.Drawing.Size(1071, 450);
            this.dgCustumer.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(85, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Tìm kiếm";
            // 
            // txtSearchManageCustomer
            // 
            this.txtSearchManageCustomer.Location = new System.Drawing.Point(68, 47);
            this.txtSearchManageCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchManageCustomer.Name = "txtSearchManageCustomer";
            this.txtSearchManageCustomer.Size = new System.Drawing.Size(365, 22);
            this.txtSearchManageCustomer.TabIndex = 12;
            // 
            // GUI_Manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 615);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dgCustumer);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSearchManageCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_Manage_Customer";
            this.Text = "GUI_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgCustumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgCustumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSearchManageCustomer;
    }
}