using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP_Pannel.Data_Acess;
using WP_Pannel.Presentation_Layer;

namespace WP_Pannel.Business_Layer
{
    public class Funnction_Customer:Function
    {

        public Funnction_Customer() {
               
        }
        public Boolean addCustomer(customer c)
        {
            try {
                dEntity.sp_customer_insert(c.id_customer, c.name_customer, c.phone, c.email, c.address_, c.id_tax, c.active, c.create_at, c.update_at);
                return true;
            }
            catch (Exception d) {
                return false;
            }
        }
        public Boolean editCustomer(customer c)
        {
            try
            {
                dEntity.sp_customer_update(c.id,c.id_customer, c.name_customer, c.phone, c.email, c.address_, c.id_tax, c.active, c.create_at, c.update_at);
                return true;
            }
            catch (Exception d)
            {
                return false;
            }
        }
        public Boolean deleteCustomer(customer c)
        {
            try
            {
                dEntity.sp_customer_delete(c.id);
                return true;
            }
            catch (Exception d)
            {
                return false;
            }
        }
        private string idCustomer()
        {
            return "CUS" + DateTime.Today;
        }//get id customer

    }
}
