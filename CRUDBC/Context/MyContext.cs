using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDBC.Model;

namespace CRUDBC.NewFolder1
{
    public class MyContext : DbContext
    {

        public MyContext() : base("MyContext") { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<Transaksi> Transaksi { get; set; }
        public DbSet<TransaksiItem> TransaksiItems {get; set;}
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
