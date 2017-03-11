using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Pannel.Presentation_Layer
{
    public partial class GUI_Manage_Customer_Edit : Form
    {
        public GUI_Manage_Customer_Edit()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt_customer_address.Clear();
            txt_customer_mail.Clear();
            txt_customer_name.Clear();
            txt_customer_phone.Clear();
            txt_customer_tax.Clear();
        }

        private void btn_add_customer_save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
