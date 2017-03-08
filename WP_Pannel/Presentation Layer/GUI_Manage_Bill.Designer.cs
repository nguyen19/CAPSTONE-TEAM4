namespace WP_Pannel.Presentation_Layer
{
    partial class GUI_Manage_Bill
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
            this.button15 = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(766, 25);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(103, 39);
            this.button15.TabIndex = 3;
            this.button15.Text = "Chi tiết";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dataGridView7.Location = new System.Drawing.Point(5, 25);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(741, 422);
            this.dataGridView7.TabIndex = 2;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Mã hóa đơn";
            this.Column16.Name = "Column16";
            this.Column16.Width = 170;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Thời gian";
            this.Column17.Name = "Column17";
            this.Column17.Width = 170;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Khách hàng";
            this.Column18.Name = "Column18";
            this.Column18.Width = 200;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Tổng tiền";
            this.Column19.Name = "Column19";
            this.Column19.Width = 200;
            // 
            // GUI_Manage_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 500);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Manage_Bill";
            this.Text = "GUI_Manage_Bill";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
    }
}