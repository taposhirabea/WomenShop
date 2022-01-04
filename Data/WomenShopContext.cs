#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WomenShop.Models;

namespace WomenShop.Data
{
    public class WomenShopContext : DbContext
    {
        public WomenShopContext (DbContextOptions<WomenShopContext> options)
            : base(options)
        {
        }

        public DbSet<WomenShop.Models.Shop> Shop { get; set; }
    }
}
