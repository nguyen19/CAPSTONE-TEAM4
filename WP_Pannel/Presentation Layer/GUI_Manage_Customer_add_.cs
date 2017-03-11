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
using WP_Pannel.Business_Layer;
using WP_Pannel.Presentation_Layer;
namespace WP_Pannel.Presentation_Layer
{
    public partial class GUI_Manage_Customer_add : Form
    {
        public Funnction_Customer busTo;
        public GUI_Manage_Customer_add()
        {
            InitializeComponent();
            this.date_customer_create.Enabled = false;
            this.date_customer_update.Enabled = false;

            busTo = new Funnction_Customer();
        }

        private void btn_add_customer_save_Click(object sender, EventArgs e)
        {
               
            customer newCustomer = new customer();

            newCustomer.id_customer = busTo.idCustomer();
            newCustomer.name_customer = txt_customer_name.Text;
            newCustomer.phone = txt_customer_phone.Text;
            newCustomer.address_ = txt_customer_address.Text;
            newCustomer.email = txt_customer_mail.Text;
            newCustomer.id_tax = txt_customer_tax.Text;
            newCustomer.create_at = date_customer_create.Value;
            newCustomer.update_at = date_customer_update.Value;
            newCustomer.active = 1;
            if (busTo.addCustomer(newCustomer))
            {
                MessageBox.Show(GUI_Default.message_customer_add_save_yes);
                this.Close();
            }
            else
            {
                MessageBox.Show(GUI_Default.message_customer_add_save_no);
            }

        }
    }
}
