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
            ((System.ComponentModel.ISupportInitialize)(this.dg_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(917, 39);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 76);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "+ Người Dùng";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(734, 39);
            this.btnchitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(160, 76);
            this.btnchitiet.TabIndex = 10;
            this.btnchitiet.Text = "Chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            // 
            // dg_staff
            // 
            this.dg_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_staff.Location = new System.Drawing.Point(95, 127);
            this.dg_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_staff.Name = "dg_staff";
            this.dg_staff.RowTemplate.Height = 24;
            this.dg_staff.Size = new System.Drawing.Size(987, 450);
            this.dg_staff.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(103, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 8;
            this.label19.Text = "Tìm kiếm";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(95, 60);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(365, 22);
            this.textBox17.TabIndex = 7;
            // 
            // GUI_Manage_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 615);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dg_staff);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}