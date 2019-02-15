using B1.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B1.ViewModel
{
    public class b3ViewModel
    {
        public IEnumerable<Haber> haber { get; set; }
        public IEnumerable<Upload> uploads { get; set; }
        public Kategori kategoris { get; set; }

    }
}