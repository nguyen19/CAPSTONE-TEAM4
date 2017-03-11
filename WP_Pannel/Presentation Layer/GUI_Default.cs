using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WP_Pannel.Presentation_Layer
{
    public class GUI_Default
    {
        public static Color Color_Default = Color.White;
        public static Color Color_View= Color.FromArgb(64, 83, 164);

        //Message

        //Staff
        public static String message_staff_dont_show = "Không hiển thị được thông tin nhân viên";
        public static String message_staff_add_save_no = "Khổng thể thêm được nhân viên";
        public static String message_staff_add_save_yes = "Thêm nhân viên thành công";


        //Customer
        public static String message_customer_dont_show = "Không hiển thị được thông tin khách hàng";
        public static String message_customer_add_save_no = "Không thể thêm được khách hàng";
        public static String message_customer_add_save_yes = "Thêm khách hàng thành công";
        public static String message_customer_edit_save_yes = "Sửa khách hàng thành công";
        public static String message_customer_edit_save_no = "Sửa khách hàng thành công";
        public static String message_customer_search_notexist = "Không có thông tin khách hàng";
        public static String message_customer_search_null = "Vui lòng nhập lại";

    }
}
