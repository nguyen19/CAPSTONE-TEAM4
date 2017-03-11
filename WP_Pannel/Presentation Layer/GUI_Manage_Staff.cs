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

        private static int MENU_ID;
        private const int VISIBLE_FALSE = -3;
        private const int VISIBLE_TRUE = -5;
        private const int MENU_FIND = 0;
        private const int MENU_SHOW = 1;
        private const int MENU_DELETE = 2;
        private const int MENU_ADD = 3;
        private void changeMenu(int id) {
            if (MENU_ID == id) return;
            MENU_ID = id;
            switch (id) {
                case VISIBLE_FALSE:
                    btnFind.Visible = false;
                    btnShowView.Visible = false;
                    btnDelete.Visible = false;
                    btnAdd.Visible = false;
                    break;
                case VISIBLE_TRUE:
                    btnFind.Visible = true;
                    btnShowView.Visible = true;
                    btnDelete.Visible = true;
                    btnAdd.Visible = true;
                    break;
                case MENU_FIND:
                    btnFind.BackgroundImage = Properties.Resources.manage_staff_seach_down_icon;
                    btnShowView.BackgroundImage = Properties.Resources.manage_staff_show_up_icon;
                    btnDelete.BackgroundImage = Properties.Resources.manage_staff_delete_up_icon;
                    btnAdd.BackgroundImage = Properties.Resources.manage_staff_add_up_icon;
                    break;
                case MENU_SHOW:
                    btnFind.BackgroundImage = Properties.Resources.manage_staff_seach_up_icon;
                    btnShowView.BackgroundImage = Properties.Resources.manage_staff_show_down_icon;
                    btnDelete.BackgroundImage = Properties.Resources.manage_staff_delete_up_icon;
                    btnAdd.BackgroundImage = Properties.Resources.manage_staff_add_up_icon;
                    showStaff();
                    break;
                case MENU_DELETE:
                    btnFind.BackgroundImage = Properties.Resources.manage_staff_seach_up_icon;
                    btnShowView.BackgroundImage = Properties.Resources.manage_staff_show_up_icon;
                    btnDelete.BackgroundImage = Properties.Resources.manage_staff_delete_down_icon;
                    btnAdd.BackgroundImage = Properties.Resources.manage_staff_add_up_icon;                   
                    break;
                case MENU_ADD:
                    btnFind.BackgroundImage = Properties.Resources.manage_staff_seach_up_icon;
                    btnShowView.BackgroundImage = Properties.Resources.manage_staff_show_up_icon;
                    btnDelete.BackgroundImage = Properties.Resources.manage_staff_delete_up_icon;
                    btnAdd.BackgroundImage = Properties.Resources.manage_staff_add_down_icon;
                    GUI_Manage_Staff_Add add = new GUI_Manage_Staff_Add();
                    add.Show();
                    break;
                default:
                    break;
            }
        }

        public Function_Staff busCus;

        public GUI_Manage_Staff()
        {
            InitializeComponent();
            this.BackColor = GUI_Default.Color_Default;
            this.FormBorderStyle = FormBorderStyle.None;

            busCus = new Function_Staff();
            setView();      
        }
        public void setView() {
            btnFind.BackgroundImage = Properties.Resources.manage_staff_seach_up_icon;
            btnFind.BackColor = GUI_Default.Color_Default;
            btnFind.BackgroundImageLayout = ImageLayout.Stretch;
            btnFind.TabStop = false;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.FlatAppearance.BorderSize = 0;

            btnShowView.BackgroundImage = Properties.Resources.manage_staff_show_up_icon;
            btnShowView.BackColor = GUI_Default.Color_Default;
            btnShowView.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowView.TabStop = false;
            btnShowView.FlatStyle = FlatStyle.Flat;
            btnShowView.FlatAppearance.BorderSize = 0;

            btnDelete.BackgroundImage = Properties.Resources.manage_staff_delete_up_icon;
            btnDelete.BackColor = GUI_Default.Color_Default;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.TabStop = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;

            btnAdd.BackgroundImage = Properties.Resources.manage_staff_add_up_icon;
            btnAdd.BackColor = GUI_Default.Color_Default;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.TabStop = false;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;

            MENU_ID = 0;
            
        }

        public void showStaff() {
            try
            {              
                this.dg_staff.DataSource = busCus.showStaff();
                this.dg_staff.Columns["id_staff"].Visible = false;
                this.dg_staff.Columns["pass_staff"].Visible = false;
                this.dg_staff.Columns["id_role"].Visible = false;
                this.dg_staff.Columns["bills"].Visible = false;
                this.dg_staff.Columns["outbounds"].Visible = false;
                this.dg_staff.Columns["role_staff"].Visible = false;

                dg_staff.Columns["birthday_staff"].HeaderCell.Value = "Ngày Sinh";
                dg_staff.Columns["name_staff"].HeaderCell.Value = "Tên";
                dg_staff.Columns["username_staff"].HeaderCell.Value = "Tên Đăng Nhập";
                dg_staff.Columns["address_staff"].HeaderCell.Value = "Địa Chỉ";
                dg_staff.Columns["mobile_staff"].HeaderCell.Value = "Số Điện Thoại";

                dg_staff.Columns["birthday_staff"].Width = 155;
                dg_staff.Columns["name_staff"].Width= 155;
                dg_staff.Columns["username_staff"].Width=155;
                dg_staff.Columns["address_staff"].Width= 155;
                dg_staff.Columns["mobile_staff"].Width=155;
            }
            catch (Exception e)
            {
                MessageBox.Show(GUI_Default.message_staff_dont_show);
                MENU_ID = 0;
            }         
        }

        private void GUI_Manage_Staff_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShowView_Click(object sender, EventArgs e)
        {
            changeMenu(MENU_SHOW);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            changeMenu(MENU_ADD);
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            changeMenu(MENU_FIND);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            changeMenu(MENU_DELETE);
        }
    }
}
