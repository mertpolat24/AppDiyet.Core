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
            return _context.Meals.Where(m => m.CreateDate>=dateTime1 && m.CreateDate<= dateTime2).ToList(); 
        }

        public List<dynamic> MealFood(int id)
        {
            return _context.Meals.Join(_context.FoodMeals, m => m.Id, fm => fm.MealId, (m, fm) => new { m.MealName, m.UserId,m.CreateDate ,fm.FoodId }).Join(_context.Foods, f => f.FoodId, x => x.Id, (f, x) => new { f.UserId, f.MealName,f.CreateDate, x.Name }).Where(x => x.UserId == id).Select(x => (dynamic)new {x.Name,x.CreateDate, x.MealName }).ToList();
        }
    }
}