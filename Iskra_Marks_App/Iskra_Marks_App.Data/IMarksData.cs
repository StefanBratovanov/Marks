namespace Iskra_Marks_App.Data
{
    using Repositories;
    using Models;

    public interface IMarksData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Mark> Marks { get; }

        IRepository<Country> Countries { get; }

        IRepository<Owner> Owners { get; }

        int SaveChanges();
    }
}
