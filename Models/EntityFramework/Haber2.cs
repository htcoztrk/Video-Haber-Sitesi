//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B1.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Haber2
    {
        public int haber_id { get; set; }
        public string haber_name { get; set; }
        public Nullable<int> tiklanma_s { get; set; }
        public Nullable<int> begeni_s { get; set; }
        public Nullable<int> paylasim_s { get; set; }
        public Nullable<int> yorum_s { get; set; }
        public string haber_aciklama { get; set; }
        public Nullable<int> kategory_id { get; set; }
        public string hbr_src { get; set; }
        public Nullable<System.DateTime> hbr_trh { get; set; }
    
        public virtual Kategori Kategori { get; set; }
    }
}
