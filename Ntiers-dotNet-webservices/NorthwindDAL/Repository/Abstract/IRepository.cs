using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate = null);
        T FindById(object id);
        T FindByEntity(T entity);
        void Add(T entity);
        void Remove(T entity);
    }
}
