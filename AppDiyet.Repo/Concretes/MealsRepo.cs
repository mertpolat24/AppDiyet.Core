using AppDiyet.Core.Concretes;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Repo.Concretes
{
    public class MealsRepo : BaseRepo<Meals>, IMealsRepo
    {
        private readonly AppDbContext _context;
        public MealsRepo(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public List<Meals> GetByMeals(DateTime dateTime1, DateTime dateTime2)
        {
            return _context.Meals.Where(m => m.CreateDate>=dateTime1 && m.CreateDate<= dateTime2).ToList(); // create date'i iki tarih arasında olan öğünleri liste şeklinde geri döndürecektir.
        }
    }
}
