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
    
    public partial class category
    {
        public category()
        {
            this.attributes_set = new HashSet<attributes_set>();
            this.goods = new HashSet<good>();
        }
    
        public int id { get; set; }
        public string id_categories { get; set; }
        public string name { get; set; }
        public Nullable<int> id_parent { get; set; }
        public Nullable<byte> sex { get; set; }
        public Nullable<byte> active { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
    
        public virtual ICollection<attributes_set> attributes_set { get; set; }
        public virtual ICollection<good> goods { get; set; }
    }
}
