using Microsoft.EntityFrameworkCore;
using Plan_C.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plan_C.Data
{
    public class StoreContext : DbContext
    {
      
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<CustomersDao> Customers { get; set; }

        public DbSet<StoresDao> Stores { get; set; }

        public DbSet<ProductsDao>Products { get; set; }

        public DbSet<CategoriesDao> Categories { get; set; }

        public DbSet<BrandsDao>Brands { get; set; }

        public DbSet<StaffsDao>Staffs { get; set; }

        public DbSet<StocksDao> Stocks { get; set; }

        public DbSet<OrderDao> Orders { get; set; }

        public DbSet<OrderItemsDao> OrderItems { get; set; }


    }
}
