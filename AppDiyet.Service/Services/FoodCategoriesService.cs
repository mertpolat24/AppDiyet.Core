using AppDiyet.Core.Concretes;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Concretes;
using AppDiyet.Repo.Context;
using AppDiyet.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Services
{
    public class FoodCategoriesService : IFoodCategoriesService
    {
        IFoodCategoriesRepo _repo = new FoodCategoriesRepo(new AppDbContext());
        public List<FoodCategories> GetAll()
        {
           return _repo.GetAll();
        }

        public FoodCategories GetById(int id)
        {
            return _repo.GetById(id);
        }
    }
}
