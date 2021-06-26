using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CasaOrtApp.Models;

namespace CasaOrtApp.Data
{
    public class CasaOrtAppContext : DbContext
    {
        public CasaOrtAppContext (DbContextOptions<CasaOrtAppContext> options)
            : base(options)
        {
        }

        public DbSet<CasaOrtApp.Models.House> House { get; set; }
    }
}
