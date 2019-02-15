using B1.Models.Deneme;
using B1.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B1.ViewModel
{
    public class b1ViewModel
    {
        public IEnumerable<Haber> habers { get; set; }
        //public Haber habers { get; set; }
        public IEnumerable<Upload> uploads { get; set; }
        public Kategori kategori { get; set; }

    }
}