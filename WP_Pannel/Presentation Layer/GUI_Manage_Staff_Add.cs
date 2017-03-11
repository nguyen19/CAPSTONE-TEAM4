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
using System.Globalization;
using System.Threading;
namespace WP_Pannel.Presentation_Layer
{
    public partial class GUI_Manage_Staff_Add : Form
    {
        public Function_Staff busStaff;

        public GUI_Manage_Staff_Add()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            InitializeComponent();           
            setDefault();
        }

        private void setDefault() {
            busStaff = new Function_Staff();
            dtBirthDay.Format = DateTimePickerFormat.Short;
            this.BackColor = GUI_Default.Color_Default;
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
                this.Close();
            }
            else
            {
                MessageBox.Show(GUI_Default.message_staff_add_save_no);
            }
        }
    }
}
