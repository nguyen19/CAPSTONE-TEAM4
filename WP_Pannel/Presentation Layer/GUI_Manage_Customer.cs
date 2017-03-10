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
        Business_Layer.Funnction_Customer db;
        CapstoneEnitity dde = new CapstoneEnitity();
        
        public GUI_Manage_Customer()
        {
            InitializeComponent();
            this.BackColor = GUI_Default.Color_Default;
            this.FormBorderStyle = FormBorderStyle.None;
            db = new Business_Layer.Funnction_Customer();
            
            this.Load += GUI_Manage_Customer_Load;

            //dgCustumer.DataSource = db.;
        }

        private void GUI_Manage_Customer_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.dgCustumer.DataSource = dde.customers.ToList();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            GUI_Manage_Customer_add aa = new GUI_Manage_Customer_add();
            aa.Show();
        }
    }
}
