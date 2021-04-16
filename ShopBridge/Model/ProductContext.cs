using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Model
{
    public partial class ProductContext: DbContext
    {
        public ProductContext()
        { }
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-897UH6N; Database=Product; Trusted_Connection=True;");
            }
        }
    }
}
