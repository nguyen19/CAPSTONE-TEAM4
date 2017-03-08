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
    
    public partial class goods_to_attributes
    {
        public goods_to_attributes()
        {
            this.bills = new HashSet<bill>();
            this.bill_detail = new HashSet<bill_detail>();
        }
    
        public int id { get; set; }
        public int id_goods { get; set; }
        public int id_attributes { get; set; }
        public int id_group_goods_attributes { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
    
        public virtual attribute attribute { get; set; }
        public virtual ICollection<bill> bills { get; set; }
        public virtual ICollection<bill_detail> bill_detail { get; set; }
        public virtual good good { get; set; }
        public virtual group_goods_quantity_stock group_goods_quantity_stock { get; set; }
    }
}
