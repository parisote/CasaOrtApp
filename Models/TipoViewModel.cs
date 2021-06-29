using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CasaOrtApp.Models
{
    public class TipoViewModel
    {
        public List<House> Houses { get; set; }
        public SelectList Tipo { get; set; }
        public Tipo TipoOperacion { get; set; }
    }
}