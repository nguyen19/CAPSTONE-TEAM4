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
    public partial class GUI_Manage_Staff : Form
    {
        public Function_Staff busCus;

        public GUI_Manage_Staff()
        {
            InitializeComponent();
            this.BackColor = GUI_Default.Color_Default;
            this.FormBorderStyle = FormBorderStyle.None;

            busCus = new Function_Staff();
            
        }
        public void showStaff() {
            try
            {
                this.dg_staff.DataSource = busCus.showStaff();
            }
            catch (Exception e)
            {
                MessageBox.Show(GUI_Default.message_staff_dont_show);
            }
            
        }

        private void GUI_Manage_Staff_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowView_Click(object sender, EventArgs e)
        {
            showStaff();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            GUI_Manage_Staff_Add staff_add = new GUI_Manage_Staff_Add();
            staff_add.Show();
        }
    }
}
