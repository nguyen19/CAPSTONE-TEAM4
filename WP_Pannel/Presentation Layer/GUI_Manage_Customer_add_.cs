using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_Pannel.Data_Acess;

namespace WP_Pannel.Presentation_Layer
{
    public partial class GUI_Manage_Customer_add : Form
    {
        Business_Layer.Funnction_Customer db;
        public GUI_Manage_Customer_add()
        {
            InitializeComponent();
            this.date_customer_create.Enabled = false;
            this.date_customer_update.Enabled = false;
            db = new Business_Layer.Funnction_Customer();
            
        }

        private void btn_add_customer_save_Click(object sender, EventArgs e)
        {
            try
            {
                customer ct = new customer();

                ct.name_customer = txt_customer_name.Text;
                //ct.name_customer = "1d1";
                ct.phone = txt_customer_phone.Text;
                ct.email = txt_customer_mail.Text;
                ct.address_ = txt_customer_address.Text;
                ct.id_tax = txt_customer_tax.Text;
                ct.create_at = date_customer_create.Value;
                ct.update_at = date_customer_update.Value;
                //String active = txt_customer_active.Text;
                //ct.active = txt_customer_active.Text.;
                //ct.active = "";
                db.addCustomer(ct);
                //ee.SaveChanges();
                
                
                MessageBox.Show("Thêm thành công!");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công!");
            }

        }
    }
}
