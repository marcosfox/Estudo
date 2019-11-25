using APIEntity.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEntity.Data
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected EfDataContext _Db;

        public BaseRepository(EfDataContext Db)
        {
            _Db = Db;
        }

        public virtual void Add(TEntity obj)
        {
            _Db.Set<TEntity>().Add(obj);
            _Db.SaveChanges();
        }

        public virtual void AddRange(List<TEntity> lstObj)
        {
            _Db.Set<TEntity>().AddRange(lstObj);
            _Db.SaveChanges();
        }


        public virtual TEntity GetById(int id)
        {
            return _Db.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> dbQuery = _Db.Set<TEntity>();
            return dbQuery;
        }

        public virtual void Update(TEntity obj)
        {
            _Db.Entry(obj).State = EntityState.Modified;
            _Db.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {
            _Db.Set<TEntity>().Remove(obj);
            _Db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_Db != null)
            {
                _Db.Dispose();
                _Db = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
