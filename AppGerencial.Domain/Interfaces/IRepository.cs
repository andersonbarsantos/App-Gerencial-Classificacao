using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGerencial.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        //comands
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        int SaveChanges();

        //queries
        TEntity SelectById(int id);
        IQueryable<TEntity> SelectAll();
    }
}
