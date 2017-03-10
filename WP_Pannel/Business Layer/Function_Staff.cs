using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Pannel.Data_Acess;
using WP_Pannel.Data_Acess;
namespace WP_Pannel.Business_Layer
{
    public class Function_Staff : Function
    {
        public Function_Staff()
        {
        }

        public List<staff> showStaff()
        {
            return dEntity.sp_staff_select().ToList<staff>();
        }
        public Boolean addStaff(staff s)
        {
            try
            {
                //dEntity.sp_staff_insert(s.id);
                return true;
            }
            catch (Exception d)
            {
                return false;
            }
        }

    }
}

