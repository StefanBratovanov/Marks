namespace Iskra_Marks_App.Data
{
    using System.Data.Entity;
    using Iskra_Marks_App.Models;

    public interface IMarksDbContext
    {
        IDbSet<ApplicationUser> Users { get; set; }

        IDbSet<Mark> Marks { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Owner> Owners { get; set; }

        int SaveChanges();
    }
}
