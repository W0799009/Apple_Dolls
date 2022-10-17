using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Apple_Dolls.Models
{
    public class DollMaterialViewModel
    {
        public List<Doll> Dolls { get; set; }
        public SelectList Materials { get; set; }
        public string DollMaterial { get; set; }
        public string SearchString { get; set; }
    }
}
