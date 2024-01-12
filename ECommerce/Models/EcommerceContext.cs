using System.Data.Entity;

namespace ECommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("conexaoecommerce")
        {
           
        }

        public System.Data.Entity.DbSet<ECommerce.Models.Departaments> Departaments { get; set; }
        public System.Data.Entity.DbSet<ECommerce.Models.City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().ToTable("City","usutreino".ToUpper());
            modelBuilder.Entity<Departaments>().ToTable("Departaments", "usutreino".ToUpper());

            /*
           base.OnModelCreating(modelBuilder);
           modelBuilder.HasDefaultSchema("usuEstudo".ToUpper());
            */
        }


    }
}