namespace WP_Pannel.Presentation_Layer
{
    partial class GUI_Manage_Customer_Edit
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
            this.btn_add_customer_save = new System.Windows.Forms.Button();
            this.date_customer_update = new System.Windows.Forms.DateTimePicker();
            this.txt_customer_address = new System.Windows.Forms.TextBox();
            this.txt_customer_tax = new System.Windows.Forms.TextBox();
            this.txt_customer_mail = new System.Windows.Forms.TextBox();
            this.txt_customer_phone = new System.Windows.Forms.TextBox();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_customer_save
            // 
            this.btn_add_customer_save.Location = new System.Drawing.Point(665, 201);
            this.btn_add_customer_save.Name = "btn_add_customer_save";
            this.btn_add_customer_save.Size = new System.Drawing.Size(122, 49);
            this.btn_add_customer_save.TabIndex = 34;
            this.btn_add_customer_save.Text = "Lưu";
            this.btn_add_customer_save.UseVisualStyleBackColor = true;
            this.btn_add_customer_save.Click += new System.EventHandler(this.btn_add_customer_save_Click);
            // 
            // date_customer_update
            // 
            this.date_customer_update.Location = new System.Drawing.Point(587, 83);
            this.date_customer_update.Name = "date_customer_update";
            this.date_customer_update.Size = new System.Drawing.Size(200, 22);
            this.date_customer_update.TabIndex = 33;
            // 
            // txt_customer_address
            // 
            this.txt_customer_address.Location = new System.Drawing.Point(587, 111);
            this.txt_customer_address.Name = "txt_customer_address";
            this.txt_customer_address.Size = new System.Drawing.Size(289, 22);
            this.txt_customer_address.TabIndex = 31;
            // 
            // txt_customer_tax
            // 
            this.txt_customer_tax.Location = new System.Drawing.Point(587, 51);
            this.txt_customer_tax.Name = "txt_customer_tax";
            this.txt_customer_tax.Size = new System.Drawing.Size(289, 22);
            this.txt_customer_tax.TabIndex = 30;
            // 
            // txt_customer_mail
            // 
            this.txt_customer_mail.Location = new System.Drawing.Point(144, 83);
            this.txt_customer_mail.Name = "txt_customer_mail";
            this.txt_customer_mail.Size = new System.Drawing.Size(289, 22);
            this.txt_customer_mail.TabIndex = 29;
            // 
            // txt_customer_phone
            // 
            this.txt_customer_phone.Location = new System.Drawing.Point(144, 111);
            this.txt_customer_phone.Name = "txt_customer_phone";
            this.txt_customer_phone.Size = new System.Drawing.Size(289, 22);
            this.txt_customer_phone.TabIndex = 28;
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Location = new System.Drawing.Point(144, 51);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.Size = new System.Drawing.Size(289, 22);
            this.txt_customer_name.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày cập nhật";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Mã số thuế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số ĐT";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(803, 201);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(122, 49);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "Làm mới";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // GUI_Manage_Customer_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 262);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btn_add_customer_save);
            this.Controls.Add(this.date_customer_update);
            this.Controls.Add(this.txt_customer_address);
            this.Controls.Add(this.txt_customer_tax);
            this.Controls.Add(this.txt_customer_mail);
            this.Controls.Add(this.txt_customer_phone);
            this.Controls.Add(this.txt_customer_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI_Manage_Customer_Edit";
            this.Text = "Chi tiết khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_customer_save;
        private System.Windows.Forms.DateTimePicker date_customer_update;
        private System.Windows.Forms.TextBox txt_customer_address;
        private System.Windows.Forms.TextBox txt_customer_tax;
        private System.Windows.Forms.TextBox txt_customer_mail;
        private System.Windows.Forms.TextBox txt_customer_phone;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
    }
}