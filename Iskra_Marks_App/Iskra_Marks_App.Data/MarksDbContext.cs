using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iskra_Marks_App.Data.Migrations;
using Iskra_Marks_App.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Iskra_Marks_App.Data
{
    public class MarksDbContext : IdentityDbContext<ApplicationUser>, IMarksDbContext
    {
        public MarksDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MarksDbContext, Configuration>());
        }

        public static MarksDbContext Create()
        {
            return new MarksDbContext();
        }

        public IDbSet<Owner> Owners { get; set; }

        public IDbSet<Country> Countries { get; set; }

        public IDbSet<Mark> Marks { get; set; }
    }
}
