﻿using System.Linq;

namespace Iskra_Marks_App.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> All();

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        T Remove(object id);

        void SaveChanges();
    }
}
