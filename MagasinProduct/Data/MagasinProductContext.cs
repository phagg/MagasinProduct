using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MagasinProduct.Models;

namespace MagasinProduct.Data
{
    public class MagasinProductContext : DbContext
    {
        public MagasinProductContext (DbContextOptions<MagasinProductContext> options)
            : base(options)
        {
        }

        public DbSet<MagasinProduct.Models.Product> Product { get; set; }
    }
}
