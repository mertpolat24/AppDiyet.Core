using AppDiyet.Core.Abstract;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Repo.Concretes
{
    public class BaseRepo<T> : IBaseRepo<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _dbSet;

        public BaseRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public bool Create(T entity)
        {
            try
            {
                if (entity is not null)
                {
                    _dbSet.Entry(entity).State = EntityState.Added;
                    return _dbContext.SaveChanges() > 0;
                }
                else
                     return false;
            }
            catch
            {
                throw new Exception("Oluşturma işlemi başarısız!");
            }

        }

        public bool Delete(T entity)
        {
            try
            {
                if (entity is not null)
                {
                    _dbSet.Entry(entity).State = EntityState.Deleted;
                    return _dbContext.SaveChanges() > 0;
                }
                else
                    return false;
            }
            catch
            {
                throw new Exception("Silme işlemi başarısız!");
            }
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                if (entity is not null)
                {
                    _dbSet.Entry(entity).State = EntityState.Modified;
                    return _dbContext.SaveChanges() > 0;
                }
                else
                    return false;
            }
            catch
            {
                throw new Exception("Güncelleme işlemi başarısız!");
            }
        }
    }
}
