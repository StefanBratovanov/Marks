using System;
using System.Collections.Generic;
using Iskra_Marks_App.Data.Repositories;
using Iskra_Marks_App.Models;

namespace Iskra_Marks_App.Data
{
    public class MarksData : IMarksData
    {
        private readonly IMarksDbContext dbContext;
        private readonly IDictionary<Type, object> repositories;


        public MarksData(IMarksDbContext context)
        {
            this.dbContext = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<Mark> Marks
        {
            get { return this.GetRepository<Mark>(); }
        }

        public IRepository<Country> Countries
        {
            get { return this.GetRepository<Country>(); }
        }

        public IRepository<Owner> Owners
        {
            get { return this.GetRepository<Owner>(); }
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericEfRepository<T>);
                this.repositories.Add(typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
