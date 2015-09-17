using System.Data.Entity.Migrations;

namespace www-docker.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<www-docker.EntityFramework.www-dockerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "www-docker";
        }

        protected override void Seed(www-docker.EntityFramework.www-dockerDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
