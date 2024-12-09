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
    public class FoodCategoriesRepo : BaseRepo<FoodCategories>, IFoodCategoriesRepo
    {
        // Örnek
        private readonly AppDbContext _context;
        public FoodCategoriesRepo(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public List<FoodCategories> GetFoodCategories()
        {
            return _context.FoodCategories.ToList();
        }
    }
}
