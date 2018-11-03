using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyCoffeeShop.Models
{
    public class MyCoffeeShopContext : DbContext
    {
        public MyCoffeeShopContext (DbContextOptions<MyCoffeeShopContext> options)
            : base(options)
        {
        }

        public DbSet<MyCoffeeShop.Models.Coffee> Coffee { get; set; }
    }
}
