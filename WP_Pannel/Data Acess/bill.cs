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
    
    public partial class bill
    {
        public bill()
        {
            this.bill_detail = new HashSet<bill_detail>();
        }
    
        public int id_bill { get; set; }
        public Nullable<int> payment_bill { get; set; }
        public System.DateTime time_bill { get; set; }
        public string note_bill { get; set; }
        public Nullable<int> price_promote_bill { get; set; }
        public string code_promote_bill { get; set; }
        public int id_customer { get; set; }
        public int id_goods_to_attributes { get; set; }
        public int id_staff { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<bill_detail> bill_detail { get; set; }
        public virtual goods_to_attributes goods_to_attributes { get; set; }
        public virtual staff staff { get; set; }
    }
}
