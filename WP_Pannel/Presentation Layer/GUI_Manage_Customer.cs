using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_Pannel.Business_Layer;
using WP_Pannel.Data_Acess;

namespace WP_Pannel.Presentation_Layer
{
    public partial class GUI_Manage_Customer : Form
    {
        public Funnction_Customer busTo;
        public GUI_Manage_Customer()
        {
            InitializeComponent();
            this.BackColor = GUI_Default.Color_Default;
            this.FormBorderStyle = FormBorderStyle.None;
                        
            this.Load += GUI_Manage_Customer_Load;
            busTo = new Funnction_Customer();
            
        }
        public void showCustomer()
        {
            try
            {
                this.dgCustumer.DataSource = busTo.showCustomer();
                this.dgCustumer.Columns["id_customer"].Visible = false;
                this.dgCustumer.Columns["name_customer"].Visible = false;
                this.dgCustumer.Columns["phone"].Visible = false;
                this.dgCustumer.Columns["email"].Visible = false;
                this.dgCustumer.Columns["address_"].Visible = false;
                this.dgCustumer.Columns["id_tax"].Visible = false;
                this.dgCustumer.Columns["create_at"].Visible = false;
                this.dgCustumer.Columns["update_at"].Visible = false;
                //this.dgCustumer.Columns["id_tax"].Visible = false;

                dgCustumer.Columns["name_customer"].HeaderCell.Value = "Tền KH";
                dgCustumer.Columns["phone"].HeaderCell.Value = "Số ĐT";
                dgCustumer.Columns["email"].HeaderCell.Value = "Email";
                dgCustumer.Columns["address_"].HeaderCell.Value = "Địa chỉ";
                dgCustumer.Columns["id_tax"].HeaderCell.Value = "Mã số thuế";
                dgCustumer.Columns["create_at"].HeaderCell.Value = "Ngày tạo";
                //dgCustumer.Columns["update_at"].HeaderCell.Value = "Số ĐT";




                dgCustumer.Columns["name_customer"].Width = 155;
                dgCustumer.Columns["phone"].Width = 155;
                dgCustumer.Columns["email"].Width = 155;
                dgCustumer.Columns["address_"].Width = 155;
                dgCustumer.Columns["id_tax"].Width = 155;
                dgCustumer.Columns["create_at"].Width = 155;

            }
            catch (Exception e)
            {
                MessageBox.Show(GUI_Default.message_staff_dont_show);
                
            }
        }


        private void GUI_Manage_Customer_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

        }



        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            GUI_Manage_Customer_add aa = new GUI_Manage_Customer_add();
            aa.Show();
        }
    }
}
