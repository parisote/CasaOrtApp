using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaOrtApp.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number{ get; set; }
        public int Size{ get; set; }
        public bool Garden { get; set; }
        public bool SwimmingPool { get; set; }
        public string Path { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }        
    }
}
