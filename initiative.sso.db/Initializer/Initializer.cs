

namespace initiative.sso.db.Initializer
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using initiative.sso.db.Context;
    using initiative.sso.db.Migrations;
    using initiative.sso.db.Model;

    public class Initializer : CreateDatabaseIfNotExists<AuthContext>
    {
        protected override void Seed(AuthContext db)
        {
            List<Company> defaultCompany = new List<Company>
            {
                new Company{    Id = 1, Name = "Accenture" },
                new Company{    Id = 2,  Name = "IBM" },
                new Company{    Id = 3,  Name = "Microsoft" },

            };

            db.Company.AddRange(defaultCompany);

            db.SaveChanges();
        }
    }
}
