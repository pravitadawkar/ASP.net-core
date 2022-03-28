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
        }
        public DbSet<Suplier> supliers { get; set; }
        public DbSet<Addresscs> addresses { get; set; }
        public DbSet<Products> products { get; set; }
    }
}
