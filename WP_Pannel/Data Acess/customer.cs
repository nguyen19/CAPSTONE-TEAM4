//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WP_Pannel.Data_Acess
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        public customer()
        {
            this.bills = new HashSet<bill>();
        }
    
        public int id { get; set; }
        public string id_customer { get; set; }
        public string name_customer { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address_ { get; set; }
        public string id_tax { get; set; }
        public byte active { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
    
        public virtual ICollection<bill> bills { get; set; }
    }
}
