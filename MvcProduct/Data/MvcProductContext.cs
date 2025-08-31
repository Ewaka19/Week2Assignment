using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProduct.Models;

namespace MvcProduct.Data
{
    public class MvcProductContext : DbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProduct.Models.Products> Products { get; set; } = default!;
    }
}
