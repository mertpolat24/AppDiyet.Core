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
    internal class MealsService : IMealsService
    {
        IMealsRepo _repo = new MealsRepo(new AppDbContext());
        public bool Add(Meals meals)
        {
            return _repo.Create(new Meals() { CreateDate = DateTime.Now, MealName = meals.MealName });
        }

        public bool Delete(int id)
        {
            return _repo.Delete(_repo.GetById(id));
        }

        public List<Meals> GetAll()
        {
            return _repo.GetAll();
        }

        public Meals GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Meals> GetByMeals(DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1 < dateTime2)
                throw new ArgumentException("Lütfen Tarih Seçimini Kontrol Ediniz");
            else
                return _repo.GetAll().Where(m=>m.CreateDate >= dateTime1 && m.CreateDate<= dateTime2).ToList();
        }
        public Meals GetByName(Meals meals)
        {
            Meals meal = _repo.GetAll().FirstOrDefault(m => m.MealName == meals.MealName);
            return meal;
        }

        public bool Update(int id, Meals meal)
        {
            var meals = _repo.GetById(id);
            return _repo.Update(meals);
        }
    }
}
