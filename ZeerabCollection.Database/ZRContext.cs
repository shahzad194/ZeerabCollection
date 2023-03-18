using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeerabCollection.Entities;

namespace ZeerabCollection.Database
{
    public class ZRContext : DbContext, IDisposable
    {
        public ZRContext() : base("ZeerabCollectionConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
