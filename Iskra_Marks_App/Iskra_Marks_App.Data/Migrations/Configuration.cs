using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection.Emit;
using System.Web.Hosting;
using Iskra_Marks_App.Models;
using Microsoft.VisualBasic.FileIO;

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
            if (!context.Countries.Any())
            {
                this.SeedCountries(context);
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
                new Country() { Name = "Benelux"},
                new Country() { Name = "Bosnia and Herzegovina"},
                new Country() { Name = "Botswana"},
                new Country() { Name = "Bulgaria"},
                new Country() { Name = "China"},
                new Country() { Name = "Croatia"},
                new Country() { Name = "Cyprus"},
                new Country() { Name = "Czech Republic"},
                new Country() { Name = "Denmark"},
                new Country() { Name = "Egypt"},
                new Country() { Name = "Estonia"},
                new Country() { Name = "Finland"},
                new Country() { Name = "France"},
                new Country() { Name = "Georgia"},
                new Country() { Name = "Germany"},
                new Country() { Name = "Ghana"},
                new Country() { Name = "Greece"},
                new Country() { Name = "Hungary"},
                new Country() { Name = "Iceland"},
                new Country() { Name = "India"},
                new Country() { Name = "Iran"},
                new Country() { Name = "Iraq"},
                new Country() { Name = "Ireland"},
                new Country() { Name = "Israel"},
                new Country() { Name = "Italy"},
                new Country() { Name = "Japan"},
                new Country() { Name = "Kazakhstan"},
                new Country() { Name = "Kenya"},
                new Country() { Name = "DPR Korea"},
                new Country() { Name = "Korea"},
                new Country() { Name = "Kosovo"},
                new Country() { Name = "Kyrgyzstan"},
                new Country() { Name = "Kuwait"},
                new Country() { Name = "Latvia"},
                new Country() { Name = "Lebanon"},
                new Country() { Name = "Lesotho"},
                new Country() { Name = "Liberia"},
                new Country() { Name = "Liechtenstein"},
                new Country() { Name = "Lithuania"},
                new Country() { Name = "Luxembourg"},
                new Country() { Name = "Macedonia"},
                new Country() { Name = "Malawi"},
                new Country() { Name = "Malta"},
                new Country() { Name = "Moldova"},
                new Country() { Name = "Monaco"},
                new Country() { Name = "Montenegro"},
                new Country() { Name = "Morocco"},
                new Country() { Name = "Namibia"},
                new Country() { Name = "Netherlands"},
                new Country() { Name = "Nigeria"},
                new Country() { Name = "Norway"},
                new Country() { Name = "OAPI"},
                new Country() { Name = "Oman"},
                new Country() { Name = "Peru"},
                new Country() { Name = "Philippines"},
                new Country() { Name = "Poland"},
                new Country() { Name = "Portugal"},
                new Country() { Name = "Romania"},
                new Country() { Name = "Russia"},
                new Country() { Name = "Rwanda"},
                new Country() { Name = "San Marino"},
                new Country() { Name = "Saudi Arabia"},
                new Country() { Name = "South Africa"},
                new Country() { Name = "Serbia"},
                new Country() { Name = "Sierra Leone"},
                new Country() { Name = "Singapore"},
                new Country() { Name = "Slovakia"},
                new Country() { Name = "Slovenia"},
                new Country() { Name = "Spain"},
                new Country() { Name = "Sudan"},
                new Country() { Name = "Swaziland"},
                new Country() { Name = "Sweden"},
                new Country() { Name = "Switzerland"},
                new Country() { Name = "Syria"},
                new Country() { Name = "Tajikistan"},
                new Country() { Name = "Tanzania"},
                new Country() { Name = "Turkey"},
                new Country() { Name = "Turkmenistan"},
                new Country() { Name = "Tunisia"},
                new Country() { Name = "Uganda"},
                new Country() { Name = "Ukraine"},
                new Country() { Name = "United Arab Emirates"},
                new Country() { Name = "United Kingdom (UK)"},
                new Country() { Name = "USA"},
                new Country() { Name = "Uzbekistan"},
                new Country() { Name = "Vietnam"},
                new Country() { Name = "Zambia"},
                new Country() { Name = "Zimbabwe"}
            };
            foreach (var c in countries)
            {
                context.Countries.Add(c);
            }
            context.SaveChanges();
        }

        private void SeedMarks(MarksDbContext context)
        {
            string filePath = HostingEnvironment.MapPath("~/Content/Tabacchiera word.csv");
            string filePath1 = HostingEnvironment.MapPath("~/Content/Tabacchiera logo.csv");
            string filePath2 = HostingEnvironment.MapPath("~/Content/ORGANZA word.csv");
            string filePath3 = HostingEnvironment.MapPath("~/Content/ORGANZA logo.csv");
            string filePath4 = HostingEnvironment.MapPath("~/Content/LEGATE word.csv");
            string filePath5 = HostingEnvironment.MapPath("~/Content/LEGATE logo black.csv");
            string filePath6 = HostingEnvironment.MapPath("~/Content/LEGATE logo blue.csv");
            string filePath7 = HostingEnvironment.MapPath("~/Content/STELLA word.csv");
            string filePath8 = HostingEnvironment.MapPath("~/Content/STELLA logo.csv");
            string filePath9 = HostingEnvironment.MapPath("~/Content/EMPORIUM word.csv");
            string filePath10 = HostingEnvironment.MapPath("~/Content/CULT word.csv");
            string filePath11 = HostingEnvironment.MapPath("~/Content/BOUDOIR word.csv");
            string filePath12 = HostingEnvironment.MapPath("~/Content/BOUDOIR logo vertical.csv");
            string filePath13 = HostingEnvironment.MapPath("~/Content/BOUDOIR logo dots.csv");
            string filePath14 = HostingEnvironment.MapPath("~/Content/BOUDOIR logo horiz stripes.csv");
            string filePath15 = HostingEnvironment.MapPath("~/Content/HERMITAGE word.csv");
            string filePath16 = HostingEnvironment.MapPath("~/Content/DAGGER word.csv");
            string filePath17 = HostingEnvironment.MapPath("~/Content/FORMAN word.csv");
            string filePath18 = HostingEnvironment.MapPath("~/Content/FORMAN logo.csv");
            string filePath19 = HostingEnvironment.MapPath("~/Content/EXCELSIOR word.csv");
            string filePath20 = HostingEnvironment.MapPath("~/Content/EXCELSIOR logo.csv");
            string filePath21 = HostingEnvironment.MapPath("~/Content/TROCADERO word.csv");
            string filePath22 = HostingEnvironment.MapPath("~/Content/RIXOS word.csv");

            string[] paths = {
                filePath,
                filePath1,
                filePath2,
                filePath3,
                filePath4,
                filePath5,
                filePath6,
                filePath7,
                filePath8,
                filePath9,
                filePath10,
                filePath11,
                filePath12,
                filePath13,
                filePath14,
                filePath15,
                filePath16,
                filePath17,
                filePath18,
                filePath19,
                filePath20,
                filePath21,
                filePath22,
            };

            foreach (var path in paths)
            {
                SeedSingleMarkFromFile(context, path);
            }
        }

        private static void SeedSingleMarkFromFile(MarksDbContext context, string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.Delimiters = new string[] { "," };
                while (true)
                {
                    string[] parts = parser.ReadFields();
                    if (parts == null)
                    {
                        break;
                    }
                    var country = parts[0];
                    var number = parts[1];

                    DateTime? expDateTime = null;
                    if (!String.IsNullOrWhiteSpace(parts[2]))
                    {
                        expDateTime = DateTime.ParseExact(parts[2], "dd.M.yyyy", CultureInfo.InvariantCulture);
                    }

                    string ownerName = "Open mark";
                    if (!String.IsNullOrWhiteSpace(parts[3]))
                    {
                        ownerName = parts[3];
                    }

                    var owner = new Owner { Name = ownerName };
                    if (!context.Owners.Any(o => o.Name == owner.Name))
                    {
                        context.Owners.AddOrUpdate(owner);
                    }

                    var notes = "";
                    if (parts.Length > 4)
                    {
                        notes = parts[4];
                    }

                    string fileName = Path.GetFileNameWithoutExtension(filePath);

                    var mark = new Mark
                    {
                        Name = fileName,
                        Number = number,
                        Country = context.Countries.FirstOrDefault(x => x.Name == country),
                        ExpirationDate = expDateTime,
                        Owner = context.Owners.FirstOrDefault(x => x.Name == ownerName),
                        Notes = notes
                    };

                    context.Marks.Add(mark);
                    context.SaveChanges();
                }
            }
        }
    }
}
