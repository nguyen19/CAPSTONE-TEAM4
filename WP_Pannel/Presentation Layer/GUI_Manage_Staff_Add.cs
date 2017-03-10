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
    public partial class GUI_Manage_Staff_Add : Form
    {
        public Function_Staff busStaff;

        public GUI_Manage_Staff_Add()
        {
            InitializeComponent();
            busStaff = new Function_Staff();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            staff newStaff = new staff();
            newStaff.birthday_staff = (DateTime)dtBirthDay.Value;
            newStaff.name_staff = txtNameStaff.Text;
            newStaff.username_staff = txtUserNameStaff.Text;
            newStaff.pass_staff = txtUserNameStaff.Text;
            newStaff.address_staff = txtAddress.Text;
            newStaff.mobile_staff = txtMobile.Text;
            newStaff.id_role = 1;
            if (busStaff.addStaff(newStaff)) {
                MessageBox.Show(GUI_Default.message_staff_add_save_yes); 
            }
            else
            {
                MessageBox.Show(GUI_Default.message_staff_add_save_no);
            }
        }
    }
}
