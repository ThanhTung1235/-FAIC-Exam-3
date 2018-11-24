using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAIC.Models;

namespace FAIC.Models
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<FAIC.Models.Category> Category { get; set; }

        public DbSet<FAIC.Models.Product> Product { get; set; }
    }
}
