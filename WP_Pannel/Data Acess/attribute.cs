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
    
    public partial class attribute
    {
        public attribute()
        {
            this.goods_to_attributes = new HashSet<goods_to_attributes>();
        }
    
        public int id { get; set; }
        public string id_attributes { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public int id_attributeset { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
        public byte active { get; set; }
    
        public virtual attributes_set attributes_set { get; set; }
        public virtual ICollection<goods_to_attributes> goods_to_attributes { get; set; }
    }
}
