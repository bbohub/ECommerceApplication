using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerceApplication.Models;

namespace ECommerceApplication.Data
{
    public class ECommerceApplicationContext : DbContext
    {
        public ECommerceApplicationContext (DbContextOptions<ECommerceApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ECommerceApplication.Models.User> User { get; set; } = default!;
    }
}
