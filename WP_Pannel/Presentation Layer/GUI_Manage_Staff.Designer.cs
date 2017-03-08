namespace WP_Pannel.Presentation_Layer
{
    partial class GUI_Manage_Staff
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(688, 32);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 62);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "+ Người Dùng";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(707, 126);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(56, 19);
            this.btnchitiet.TabIndex = 10;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(71, 103);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(740, 366);
            this.dataGridView2.TabIndex = 9;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Đăng Nhập";
            this.Column5.Name = "Column5";
            this.Column5.Width = 400;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên Người Dùng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 400;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Tìm kiếm";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(71, 49);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(275, 20);
            this.textBox17.TabIndex = 7;
            // 
            // GUI_Manage_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Manage_Staff";
            this.Text = "GUI_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox17;
    }
}