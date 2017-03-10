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
            this.dg_staff = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.btnShowView = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(752, 36);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(111, 45);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "+ Người Dùng";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(612, 36);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(111, 45);
            this.btnchitiet.TabIndex = 10;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            // 
            // dg_staff
            // 
            this.dg_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_staff.Location = new System.Drawing.Point(27, 103);
            this.dg_staff.Margin = new System.Windows.Forms.Padding(2);
            this.dg_staff.Name = "dg_staff";
            this.dg_staff.RowTemplate.Height = 24;
            this.dg_staff.Size = new System.Drawing.Size(836, 366);
            this.dg_staff.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Tìm kiếm";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(27, 49);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(275, 20);
            this.textBox17.TabIndex = 7;
            // 
            // btnShowView
            // 
            this.btnShowView.Location = new System.Drawing.Point(469, 36);
            this.btnShowView.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowView.Name = "btnShowView";
            this.btnShowView.Size = new System.Drawing.Size(111, 45);
            this.btnShowView.TabIndex = 12;
            this.btnShowView.Text = "Hiển Thị";
            this.btnShowView.UseVisualStyleBackColor = true;
            this.btnShowView.Click += new System.EventHandler(this.btnShowView_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(325, 36);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 45);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // GUI_Manage_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnShowView);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dg_staff);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Manage_Staff";
            this.Text = "GUI_Staff";
            this.Load += new System.EventHandler(this.GUI_Manage_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.DataGridView dg_staff;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button btnShowView;
        private System.Windows.Forms.Button btnTimKiem;
    }
}