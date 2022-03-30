using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuplierAddressCRUD.suplierModel;
namespace SuplierAddressCRUD.Athentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Supplier>()
           .HasOne<Address>(s => s.Address)
           .WithOne(ad => ad.Supplier)
           .HasForeignKey<Address>(ad => ad.SupplierId);

            builder.Entity<Products>()
            .HasOne<Supplier>(p => p.Supplier)
            .WithMany(s => s.Product)
            .HasForeignKey(s => s.SupplierId);
        }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Products> products { get; set; }
    }
}
