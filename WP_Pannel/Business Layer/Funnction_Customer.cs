using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Pannel.Data_Acess;

namespace WP_Pannel.Business_Layer
{
    public class Funnction_Customer:Function
    {
        public Funnction_Customer() {
               
        }
        public List<customer> showCustomer()
        {
            return dEntity.sp_customer_select().ToList<customer>();
            
        }

        public Boolean addCustomer(customer c)
        {
            try
            { 
                dEntity.sp_customer_insert(c.id_customer,c.name_customer,c.phone,c.email,c.address_,c.id_tax,c.active,c.create_at,c.update_at);
                return true;
            }
            catch (Exception d)
            {
                return false;
            }
        }
        public string idCustomer()
        {
            return "KH" + DateTime.UtcNow;
        }//get id customer

    }
}
