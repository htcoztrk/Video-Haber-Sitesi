using B1.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B1.ViewModel
{
    
    public class b6ViewModel
    {
       public  IEnumerable<Haber> video { get; set; }
       public  IEnumerable<Upload> u { get; set; }
       
    }
}