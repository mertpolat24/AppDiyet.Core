using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        bool Any(Expression<Func<T, bool>> predicate);
        List<TResult> GetFilteredList<TResult>(Expression<Func<T,TResult>> select, Expression<Func<T,bool>> where = null, Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null);

    }
}
