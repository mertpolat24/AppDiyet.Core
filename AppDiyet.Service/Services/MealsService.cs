using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Concretes;
using AppDiyet.Repo.Context;
using AppDiyet.Service.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Services
{
    public class MealsService : IMealsService
    {
        IMealsRepo _repo = new MealsRepo(new AppDbContext());
        public bool Add(MealCategories meals)
        {
            if (meals > 0)
            {
                return _repo.Create(new Meals() { CreateDate = DateTime.Now, MealName = meals });
            }
            else
                return false;
        }

        public bool Delete(int id)
        {
            if (id > 0)
                return _repo.Delete(_repo.GetById(id));
            else
                return false;
        }

        public List<Meals> GetAll()
        {
            return _repo.GetAll();
        }

        public Meals GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<dynamic> GetByMeals(int id, DateTime dateTime1, DateTime dateTime2)
        {
            return _repo.GetByMeals(id, dateTime1, dateTime2);
        }

        public List<dynamic> MealFood(int id)
        {
            return _repo.MealFood(id);
        }

        public bool Update(int id, MealCategories name, DateTime createDate)
        {
            var meals = _repo.GetById(id);
            if (name > 0 && createDate > DateTime.MinValue)
            {
                meals.MealName = name;
                meals.CreateDate = createDate;
                return _repo.Update(meals);
            }
            else
                return false;
        }
    }
}
