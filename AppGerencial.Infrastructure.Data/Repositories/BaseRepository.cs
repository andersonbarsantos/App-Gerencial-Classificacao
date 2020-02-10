using AppGerencial.Domain.Interfaces;
using AppGerencial.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGerencial.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AjusteProcessoContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(AjusteProcessoContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity SelectById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> SelectAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        //public int SaveChangesAsync()
        //{
        //    return Db.SaveChangesAsync();
        //}
       

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

