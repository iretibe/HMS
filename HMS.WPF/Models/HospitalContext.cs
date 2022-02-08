using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.WPF.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Damage> Damages { get; set; }
        public DbSet<DamageDetail> DamageDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<TransferDetail> TransferDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        //{
        //    //modelBuilder.UseSqlServer("Server=codelearnersoft.net;Database=PersolPosDb;user id=sa;password=YEso!@12;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True");

        //    base.OnConfiguring(modelBuilder);
        //}
    }
}
