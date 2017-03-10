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

        CapstoneEnitity dd = new CapstoneEnitity();
        public GUI_Manage_Staff()
        {
            InitializeComponent();
            this.BackColor = GUI_Default.Color_Default;
            this.FormBorderStyle = FormBorderStyle.None;
           

            busCus = new Function_Staff();
            showStaff();

        }
        public void showStaff() {
            
        }

        private void GUI_Manage_Staff_Load(object sender, EventArgs e)
        {
            this.dg_staff.DataSource = dd.staffs.ToList();
        }
    }
}
