//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cuffs_And_Cufflinks.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_products
    {
        public int p_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string p_title { get; set; }
        public string p_article_no { get; set; }
        public Nullable<int> p_price { get; set; }
        public string p_description { get; set; }
        public string p_img { get; set; }
        public Nullable<int> c_id { get; set; }
        public Nullable<int> s_id { get; set; }
    
        public virtual Table_Category Table_Category { get; set; }
        public virtual Table_Colors Table_Colors { get; set; }
        public virtual Table_Size Table_Size { get; set; }
    }
}
