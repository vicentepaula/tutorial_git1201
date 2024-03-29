namespace ECommerce.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerce.Models.EcommerceContext>
    {
        public Configuration()
        {   
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ECommerce.Models.EcommerceContext";
           
            /*
            AutomaticMigrationsEnabled = false;
            var historyContextFactory = GetHistoryContextFactory("Oracle.ManagedDataAccess.Client");
            SetHistoryContextFactory("Oracle.ManagedDataAccess.Client",
            (dbc, schema) => historyContextFactory.Invoke(dbc, "usuEstudo".ToUpper()));
            */
        }

        protected override void Seed(ECommerce.Models.EcommerceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
