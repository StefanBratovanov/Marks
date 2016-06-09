using System.Collections.Generic;
using System.Reflection.Emit;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Iskra_Marks_App.Data.MarksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Iskra_Marks_App.Data.MarksDbContext context)
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

            if (!context.Countries.Any())
            {
                this.SeedCountries(context);
            }

            if (!context.Owners.Any())
            {
                this.SeedOwners(context);
            }

            if (!context.Marks.Any())
            {
                this.SeedMarks(context);
            }

        }

        private void SeedCountries(MarksDbContext context)
        {
            var countries = new List<Country>()
            {
                new Country() { Name = "Albania"},
                new Country() { Name = "Algeria"},
                new Country() { Name = "Armenia"},
                new Country() { Name = "Austria"},
                new Country() { Name = "Azerbaijan"},
                new Country() { Name = "Bahrain"},
                new Country() { Name = "Belarus"},
                new Country() { Name = "Belgium"},
                new Country() { Name = "Bosnia and H"},
                new Country() { Name = "Botswana"},
                new Country() { Name = "Bulgaria"},
                new Country() { Name = "China"},
                new Country() { Name = "Croatia"},
                new Country() { Name = "Cyprus"},
                new Country() { Name = "Czech Rep"},
            };
            foreach (var c in countries)
            {
                context.Countries.Add(c);
            }
            context.SaveChanges();
        }


        private void SeedOwners(MarksDbContext context)
        {
            var owners = new List<Owner>()
            {
                new Owner { Name = "OM UK"},
                new Owner { Name = "Teleman"},

            };
            foreach (var o in owners)
            {
                context.Owners.Add(o);
            }
            context.SaveChanges();
        }

        private void SeedMarks(MarksDbContext context)
        {
            var marks = new List<Mark>()
            {
                new Mark
                {
                    Name = "Tabacchiera word",
                    Number = "965330",
                    OwnerId = 1,
                    CountryId = 1,
                    ExpirationDate = new DateTime(2018, 04, 30)
                },
                 new Mark
                {
                    Name = "Tabacchiera word",
                    Number = "965330",
                    OwnerId = 1,
                    CountryId = 3,
                    ExpirationDate = new DateTime(2018, 04, 30)
                },

                   new Mark
                {
                    Name = "Tabacchiera word",
                    Number = "77756",
                    OwnerId = 2,
                    CountryId = 14,
                    ExpirationDate = new DateTime(2020, 01, 14)
                },

            };
            foreach (var m in marks)
            {
                context.Marks.Add(m);
            }
            context.SaveChanges();
        }
    }
}
