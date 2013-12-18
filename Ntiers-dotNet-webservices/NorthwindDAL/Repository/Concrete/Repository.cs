using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL.Infrastructure;
using NorthwindDAL.Repository.Abstract;

namespace NorthwindDAL.Repository.Concrete
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> items = DataContextFactory.NorthwndEntities.Set<T>();
            return (predicate == null) ? items : items.Where(predicate);
        }

        public abstract T FindById(object id);

        public abstract T FindByEntity(T entity);

        public virtual void Add(T entity)
        {
            DataContextFactory.NorthwndEntities.Set<T>().AddOrUpdate(entity);

            DataContextFactory.NorthwndEntities.SaveChanges();
        }

        public virtual void Remove(T entity)
        {
            T item = FindByEntity(entity);

            if (item != null)
                DataContextFactory.NorthwndEntities.Set<T>().Remove(item);

            DataContextFactory.NorthwndEntities.SaveChanges();
        }
    }
}
