namespace initiative.sso.db.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using initiative.sso.db.Model;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<initiative.sso.db.Context.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(initiative.sso.db.Context.AuthContext context)
        {
            context.Company.Add(new Company { Name = "Accenture" });
            context.Company.Add(new Company { Name = "DXC" });
            context.Company.Add(new Company { Name = "IBM" });

            context.SaveChanges();
        }
    }
}
