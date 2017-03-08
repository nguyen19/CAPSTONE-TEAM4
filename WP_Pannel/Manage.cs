using System.Drawing;
using System.Windows.Forms;
using WP_Pannel.Presentation_Layer;
namespace WP_Pannel
{
    public partial class Manage : Form
    {
        private const int VISIBLE_FALSE = -3;
        private const int VISIBLE_TRUE = -5;
        private int MENU_ID = 0;
        private const int MENU_SELL = 0;
        private const int MENU_MANAGE = 1;
        private const int MENU_IMPORT = 2;
        private const int MENU_STATISTICAL = 3;

        private void changeMenu(int id)
        {
            if (id == MENU_ID) return;
            MENU_ID = id;
            switch (id)
            {
                case MENU_SELL:
                    btnSell.BackgroundImage = Properties.Resources.sell_down_icon;
                    btnManage.BackgroundImage = Properties.Resources.mangage_up_icon;
                    btnImport.BackgroundImage = Properties.Resources.import_up_icon;
                    btnSatification.BackgroundImage = Properties.Resources.statistical_up_icon;
                    changeMenuManage(VISIBLE_FALSE);
                    changeMenuStatistical(VISIBLE_FALSE);
                    changeMenuImport(VISIBLE_FALSE);
                    break;
                case MENU_MANAGE:
                    btnSell.BackgroundImage = Properties.Resources.sell_up_icon;
                    btnManage.BackgroundImage = Properties.Resources.mangage_down_icon;
                    btnImport.BackgroundImage = Properties.Resources.import_up_icon;
                    btnSatification.BackgroundImage = Properties.Resources.statistical_up_icon;
                    changeMenuManage(VISIBLE_TRUE);
                    changeMenuStatistical(VISIBLE_FALSE);
                    changeMenuImport(VISIBLE_FALSE);
                    changeMenuManage(MENU_MANAGE_ACCOUNT);
                    break;
                case MENU_IMPORT:
                    btnSell.BackgroundImage = Properties.Resources.sell_up_icon;
                    btnManage.BackgroundImage = Properties.Resources.mangage_up_icon;
                    btnImport.BackgroundImage = Properties.Resources.import_down_icon;
                    btnSatification.BackgroundImage = Properties.Resources.statistical_up_icon;
                    changeMenuManage(VISIBLE_FALSE);
                    changeMenuStatistical(VISIBLE_FALSE);
                    changeMenuImport(VISIBLE_TRUE);
                    changeMenuImport(MENU_IMPORT_IMPORT);
                    break;
                case MENU_STATISTICAL:
                    btnSell.BackgroundImage = Properties.Resources.sell_up_icon;
                    btnManage.BackgroundImage = Properties.Resources.mangage_up_icon;
                    btnImport.BackgroundImage = Properties.Resources.import_up_icon;
                    btnSatification.BackgroundImage = Properties.Resources.statistical_down_icon;
                    changeMenuManage(VISIBLE_FALSE);
                    changeMenuStatistical(VISIBLE_TRUE);
                    changeMenuImport(VISIBLE_FALSE);
                    changeMenuStatistical(MENU_STATISTICAL_DAY);
                    break;
                default:
                    break;
            }
        }

        //manage
        private int MENU_MANAGE_ID = 0;
        private const int MENU_MANAGE_ACCOUNT = 0;
        private const int MENU_MANAGE_USER = 1;
        private const int MENU_MANAGE_PRODUCT = 2;
        private const int MENU_MANAGE_CUSTOMER = 3;
        private const int MENU_MANAGE_BILL = 4;
        private const int MENU_MANAGE_VISIBLE_TRUE = 5;
        private void changeMenuManage(int id)
        {
            if (id == MENU_MANAGE_ID) return;
            MENU_MANAGE_ID = id;
            switch (id)
            {
                case MENU_MANAGE_ACCOUNT:
                    btnManageAccount.BackgroundImage = Properties.Resources.manage_account_up_icon;
                    btnManageUser.BackgroundImage = Properties.Resources.manage_staff_down_icon;
                    btnManageProduct.BackgroundImage = Properties.Resources.manage_product_down_icon;
                    btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_down_icon;
                    btnManageBill.BackgroundImage = Properties.Resources.manage_bill_down_icon;
                    GUI_Manage_Account account = new GUI_Manage_Account();
                    addView(account);                               
                    break;
                case MENU_MANAGE_USER:
                    btnManageAccount.BackgroundImage = Properties.Resources.manage_account_down_icon;
                    btnManageUser.BackgroundImage = Properties.Resources.manage_staff_up_icon;
                    btnManageProduct.BackgroundImage = Properties.Resources.manage_product_down_icon;
                    btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_down_icon;
                    btnManageBill.BackgroundImage = Properties.Resources.manage_bill_down_icon;
                    GUI_Manage_Staff staff = new GUI_Manage_Staff();
                    addView(staff);
                    break;
                case MENU_MANAGE_PRODUCT:
                    btnManageAccount.BackgroundImage = Properties.Resources.manage_account_down_icon;
                    btnManageUser.BackgroundImage = Properties.Resources.manage_staff_down_icon;
                    btnManageProduct.BackgroundImage = Properties.Resources.manage_product_up_icon;
                    btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_down_icon;
                    btnManageBill.BackgroundImage = Properties.Resources.manage_bill_down_icon;
                    GUI_Manage_Product product = new GUI_Manage_Product();
                    addView(product);
                    break;
                case MENU_MANAGE_CUSTOMER:
                    btnManageAccount.BackgroundImage = Properties.Resources.manage_account_down_icon;
                    btnManageUser.BackgroundImage = Properties.Resources.manage_staff_down_icon;
                    btnManageProduct.BackgroundImage = Properties.Resources.manage_product_down_icon;
                    btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_up_icon;
                    btnManageBill.BackgroundImage = Properties.Resources.manage_bill_down_icon;
                    GUI_Manage_Customer customer = new GUI_Manage_Customer();
                    addView(customer);
                    break;
                case MENU_MANAGE_BILL:
                    btnManageAccount.BackgroundImage = Properties.Resources.manage_account_down_icon;
                    btnManageUser.BackgroundImage = Properties.Resources.manage_staff_down_icon;
                    btnManageProduct.BackgroundImage = Properties.Resources.manage_product_down_icon;
                    btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_down_icon;
                    btnManageBill.BackgroundImage = Properties.Resources.manage_bill_up_icon;
                    GUI_Manage_Bill bill = new GUI_Manage_Bill();
                    addView(bill);
                    break;
                case VISIBLE_TRUE:       
                    btnManageAccount.Visible = true;
                    btnManageUser.Visible = true;
                    btnManageProduct.Visible = true;
                    btnMangeCustomer.Visible = true;
                    btnManageBill.Visible = true;
                    break;
                case VISIBLE_FALSE:
                    btnManageAccount.Visible = false;
                    btnManageUser.Visible = false;
                    btnManageProduct.Visible = false;
                    btnMangeCustomer.Visible = false;
                    btnManageBill.Visible = false;
                    break;
                default :
                    break;
            }
        }

        //statistical
        private int MENU_STATISTICAL_ID = 0;
        private const int MENU_STATISTICAL_DAY = 0;
        private const int MENU_STATISTICAL_STAFF= 1;
        private const int MENU_STATISTICAL_RECEIVE = 2;
        private void changeMenuStatistical(int id) {
            if (id == MENU_STATISTICAL_ID) return;
            MENU_STATISTICAL_ID = id;
            switch (id) {
                case VISIBLE_TRUE:
                    btnSatificationDay.Visible = true;
                    btnSatificationStaff.Visible = true;
                    btnSatificationRecive.Visible = true;
                    break;
                case VISIBLE_FALSE:
                    btnSatificationDay.Visible = false;
                    btnSatificationStaff.Visible = false;
                    btnSatificationRecive.Visible = false;
                    break;
                case MENU_STATISTICAL_DAY:
                    btnSatificationDay.BackgroundImage = Properties.Resources.statistical_day_up;
                    btnSatificationStaff.BackgroundImage = Properties.Resources.statistical_staff_down;
                    btnSatificationRecive.BackgroundImage = Properties.Resources.statistical_reciver_down;
                    GUI_Statistical_Day day = new GUI_Statistical_Day();
                    addView(day);
                    break;
                case MENU_STATISTICAL_STAFF:
                    btnSatificationDay.BackgroundImage = Properties.Resources.statistical_day_down;
                    btnSatificationStaff.BackgroundImage = Properties.Resources.statistical_staff_up;
                    btnSatificationRecive.BackgroundImage = Properties.Resources.statistical_reciver_down;
                    GUI_Statistical_Staff staff = new GUI_Statistical_Staff();
                    addView(staff);
                    break;
                case MENU_STATISTICAL_RECEIVE:
                    btnSatificationDay.BackgroundImage = Properties.Resources.statistical_day_down;
                    btnSatificationStaff.BackgroundImage = Properties.Resources.statistical_staff_down;
                    btnSatificationRecive.BackgroundImage = Properties.Resources.statistical_reciver_up;
                    GUI_Statistical_Receive receive = new GUI_Statistical_Receive();
                    addView(receive);
                    break;
                default:
                    break;
            }
        }

        //impore int
        private int MENU_IMPORT_ID = 0;
        private const int MENU_IMPORT_IMPORT = 0;
        private const int MENU_IMPORT_EXPORT = 1;
        private const int MENU_IMPORT_CHECK = 2;
        private void changeMenuImport(int id) {
            if (id == MENU_IMPORT_ID) return;
            MENU_IMPORT_ID = id;
            switch (id)
            {
                case VISIBLE_TRUE:
                    btnImportImport.Visible = true;
                    btnImportExport.Visible = true;
                    btnImportCheckList.Visible = true;
                    break;
                case VISIBLE_FALSE:
                    btnImportImport.Visible = false;
                    btnImportExport.Visible = false;
                    btnImportCheckList.Visible = false;
                    break;
                case MENU_IMPORT_IMPORT:
                    btnImportImport.BackgroundImage = Properties.Resources.import_import_up_icon;
                    btnImportExport.BackgroundImage = Properties.Resources.import_export_down_icon;
                    btnImportCheckList.BackgroundImage = Properties.Resources.import_check_down_icon;
                    GUI_Import_Import import = new GUI_Import_Import();
                    addView(import);
                    break;
                case MENU_IMPORT_EXPORT:
                    btnImportImport.BackgroundImage = Properties.Resources.import_import_down_icon;
                    btnImportExport.BackgroundImage = Properties.Resources.import_export_up_icon;
                    btnImportCheckList.BackgroundImage = Properties.Resources.import_check_down_icon;
                    GUI_Import_Export export = new GUI_Import_Export();
                    addView(export);
                    break;
                case MENU_IMPORT_CHECK:
                    btnImportImport.BackgroundImage = Properties.Resources.import_import_down_icon;
                    btnImportExport.BackgroundImage = Properties.Resources.import_export_down_icon;
                    btnImportCheckList.BackgroundImage = Properties.Resources.import_check_up_icon;
                    GUI_Import_CheckList check = new GUI_Import_CheckList();
                    addView(check);
                    break;
                default:
                    break;
            }
        }

        private void addView(Form d) {
            pnlView.Controls.Clear();
            d.TopLevel = false;
            pnlView.Controls.Add(d);
            d.Show();
        }

        public Manage()
        {
            InitializeComponent();
            setGUI();
            changeMenu(MENU_MANAGE);
        }

        public void setGUI()
        {
            MENU_ID = -1;
            MENU_MANAGE_ID = -1;
            MENU_IMPORT_ID = -1;
            MENU_STATISTICAL_ID = -1;

            btnManage.BackColor = GUI_Default.Color_Default;
            btnManage.TabStop = false;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.BackgroundImageLayout = ImageLayout.Stretch;

            btnSell.BackColor = GUI_Default.Color_Default;
            btnSell.TabStop = false;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.FlatAppearance.BorderSize = 0;
            btnSell.BackgroundImageLayout = ImageLayout.Stretch;

            btnSatification.BackColor = GUI_Default.Color_Default;
            btnSatification.TabStop = false;
            btnSatification.FlatStyle = FlatStyle.Flat;
            btnSatification.FlatAppearance.BorderSize = 0;
            btnSatification.BackgroundImageLayout = ImageLayout.Stretch;

            btnImport.BackColor = GUI_Default.Color_Default;
            btnImport.TabStop = false;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.BackgroundImageLayout = ImageLayout.Stretch;

            this.BackColor = GUI_Default.Color_View;
            pnlMENU.BackColor = GUI_Default.Color_View;
            pnlView.BackColor = GUI_Default.Color_Default;

            btnMENU.BackColor = GUI_Default.Color_Default;
            btnMENU.TabStop = false;
            btnMENU.FlatStyle = FlatStyle.Flat;
            btnMENU.FlatAppearance.BorderSize = 0;

            btnManageAccount.BackColor = GUI_Default.Color_Default;
            btnManageAccount.TabStop = false;
            btnManageAccount.FlatStyle = FlatStyle.Flat;
            btnManageAccount.FlatAppearance.BorderSize = 0;
            btnManageAccount.BackgroundImageLayout = ImageLayout.Stretch;
            btnManageAccount.BackgroundImage = Properties.Resources.manage_account_down_icon;

            btnManageBill.BackColor = GUI_Default.Color_Default;
            btnManageBill.TabStop = false;
            btnManageBill.FlatStyle = FlatStyle.Flat;
            btnManageBill.FlatAppearance.BorderSize = 0;
            btnManageBill.BackgroundImageLayout = ImageLayout.Stretch;
            btnManageBill.BackgroundImage = Properties.Resources.manage_bill_down_icon;

            btnManageProduct.BackColor = GUI_Default.Color_Default;
            btnManageProduct.TabStop = false;
            btnManageProduct.FlatStyle = FlatStyle.Flat;
            btnManageProduct.FlatAppearance.BorderSize = 0;
            btnManageProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnManageProduct.BackgroundImage = Properties.Resources.manage_product_down_icon;


            btnManageUser.BackColor = GUI_Default.Color_Default;
            btnManageUser.TabStop = false;
            btnManageUser.FlatStyle = FlatStyle.Flat;
            btnManageUser.FlatAppearance.BorderSize = 0;
            btnManageUser.BackgroundImageLayout = ImageLayout.Stretch;
            btnManageUser.BackgroundImage = Properties.Resources.manage_staff_down_icon;

            btnMangeCustomer.BackColor = GUI_Default.Color_Default;
            btnMangeCustomer.TabStop = false;
            btnMangeCustomer.FlatStyle = FlatStyle.Flat;
            btnMangeCustomer.FlatAppearance.BorderSize = 0;
            btnMangeCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            btnMangeCustomer.BackgroundImage = Properties.Resources.manage_customer_down_icon;

            btnSatificationDay.BackColor = GUI_Default.Color_Default;
            btnSatificationDay.TabStop = false;
            btnSatificationDay.FlatStyle = FlatStyle.Flat;
            btnSatificationDay.FlatAppearance.BorderSize = 0;
            btnSatificationDay.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatificationDay.BackgroundImage = Properties.Resources.statistical_day_down;

            btnSatificationStaff.BackColor = GUI_Default.Color_Default;
            btnSatificationStaff.TabStop = false;
            btnSatificationStaff.FlatStyle = FlatStyle.Flat;
            btnSatificationStaff.FlatAppearance.BorderSize = 0;
            btnSatificationStaff.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatificationStaff.BackgroundImage = Properties.Resources.statistical_staff_down;

            btnSatificationRecive.BackColor = GUI_Default.Color_Default;
            btnSatificationRecive.TabStop = false;
            btnSatificationRecive.FlatStyle = FlatStyle.Flat;
            btnSatificationRecive.FlatAppearance.BorderSize = 0;
            btnSatificationRecive.BackgroundImageLayout = ImageLayout.Stretch;
            btnSatificationRecive.BackgroundImage = Properties.Resources.statistical_reciver_down;

            btnImportImport.BackColor = GUI_Default.Color_Default;
            btnImportImport.TabStop = false;
            btnImportImport.FlatStyle = FlatStyle.Flat;
            btnImportImport.FlatAppearance.BorderSize = 0;
            btnImportImport.BackgroundImageLayout = ImageLayout.Stretch;
            btnImportImport.BackgroundImage = Properties.Resources.import_import_down_icon;

            btnImportExport.BackColor = GUI_Default.Color_Default;
            btnImportExport.TabStop = false;
            btnImportExport.FlatStyle = FlatStyle.Flat;
            btnImportExport.FlatAppearance.BorderSize = 0;
            btnImportExport.BackgroundImageLayout = ImageLayout.Stretch;
            btnImportExport.BackgroundImage = Properties.Resources.import_export_down_icon;

            btnImportCheckList.BackColor = GUI_Default.Color_Default;
            btnImportCheckList.TabStop = false;
            btnImportCheckList.FlatStyle = FlatStyle.Flat;
            btnImportCheckList.FlatAppearance.BorderSize = 0;
            btnImportCheckList.BackgroundImageLayout = ImageLayout.Stretch;
            btnImportCheckList.BackgroundImage = Properties.Resources.import_check_down_icon;

        }

        private void btnSell_Click(object sender, System.EventArgs e)
        {
            changeMenu(MENU_SELL);
        }

        private void btnManage_Click(object sender, System.EventArgs e)
        {
            changeMenu(MENU_MANAGE);
        }

        private void btnSatification_Click(object sender, System.EventArgs e)
        {
            changeMenu(MENU_STATISTICAL);
        }

        private void btnImport_Click(object sender, System.EventArgs e)
        {
            changeMenu(MENU_IMPORT);
        }

        private void btnManageAccount_Click(object sender, System.EventArgs e)
        {
            changeMenuManage(MENU_MANAGE_ACCOUNT);
        }

        private void btnManageUser_Click(object sender, System.EventArgs e)
        {
            changeMenuManage(MENU_MANAGE_USER);
        }

        private void btnManageProduct_Click(object sender, System.EventArgs e)
        {
            changeMenuManage(MENU_MANAGE_PRODUCT);
        }

        private void btnMangeCustomer_Click(object sender, System.EventArgs e)
        {
            changeMenuManage(MENU_MANAGE_CUSTOMER);
        }

        private void btnManageBill_Click(object sender, System.EventArgs e)
        {
            changeMenuManage(MENU_MANAGE_BILL);
        }

        private void btnImportImport_Click(object sender, System.EventArgs e)
        {
            changeMenuImport(MENU_IMPORT_IMPORT);
        }

        private void btnImportExport_Click(object sender, System.EventArgs e)
        {
            changeMenuImport(MENU_IMPORT_EXPORT);
        }

        private void btnImportCheckList_Click(object sender, System.EventArgs e)
        {
            changeMenuImport(MENU_IMPORT_CHECK);
        }

        private void btnSatificationDay_Click(object sender, System.EventArgs e)
        {
            changeMenuStatistical(MENU_STATISTICAL_DAY);
        }

        private void btnSatificationStaff_Click(object sender, System.EventArgs e)
        {
            changeMenuStatistical(MENU_STATISTICAL_STAFF);
        }

        private void btnSatificationRecive_Click(object sender, System.EventArgs e)
        {
            changeMenuStatistical(MENU_STATISTICAL_RECEIVE);
        }
    }
}
