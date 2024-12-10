using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppDiyet.Repo.Concretes
{
    public class UserRepo : BaseRepo<Users>, IUsersRepo
    {
        private readonly AppDbContext _context;
        public UserRepo(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public double CalculateCalories(int id)
        {
            var mealsList = _context.Meals.Join(_context.FoodMeals, m => m.Id, fm => fm.MealId,(m, fm) => new {m.UserId, m.CreateDate, fm.FoodId}).Join(_context.Foods, fm => fm.FoodId, f => f.Id, (fm,f) => new {fm.CreateDate, fm.UserId,f.Calories}).Where(x => x.UserId == id && x.CreateDate.Day == DateTime.Now.Day).Select(x=> new {x.Calories}).ToList();

            if (!mealsList.Any())
                return 0;

            

            double totalCalories = 0;

            foreach (var meal in mealsList)
            {
                totalCalories += meal.Calories;
            }

            return totalCalories;

        }

        public double CalculateProteins(int id)
        {
            var mealsList2 = _context.Meals.Join(_context.FoodMeals, m => m.Id, fm => fm.MealId, (m, fm) => new { m.UserId, m.CreateDate, fm.FoodId }).Join(_context.Foods, fm => fm.FoodId, f => f.Id, (fm, f) => new { fm.CreateDate, fm.UserId, f.Proteins }).Where(x => x.UserId == id && x.CreateDate.Day == DateTime.Now.Day).Select(x => new { x.Proteins }).ToList();
            if (!mealsList2.Any())
                return 0;


            double totalCalories2 = 0;

            foreach (var meal in mealsList2)
            {
                totalCalories2 += meal.Proteins;
            }

            return totalCalories2;
        }

        public double DailyCaloriesLimit(int id)
        {
            var weight = _context.Users.Find(id).Weight;
            var lenght = _context.Users.Find(id).Lenght;
            var age = _context.Users.Find(id).Age;
            var gender = _context.Users.Find(id).Gender;
            var purpose = _context.Users.Find(id).Purpose;
            var activites = _context.Users.Find(id).Activities;
            double bmr;
            double activitiesMultiplier;

            if (activites == Activities.Sedentary)
                activitiesMultiplier = 1.2;
            else if (activites == Activities.LightlyActive)
                activitiesMultiplier = 1.375;
            else if (activites == Activities.ModeratelyActive)
                activitiesMultiplier = 1.55;
            else if (activites == Activities.VeryActive)
                activitiesMultiplier = 1.725;
            else
                activitiesMultiplier = 1.9;


            if (gender == Gender.Male)
                bmr = ((10 * weight) + (6.25 * lenght) - (5 * age + 5)) * activitiesMultiplier;
            else
                bmr = ((10 * weight) + (6.25 * lenght) - (5 * age - 121)) * activitiesMultiplier;



            if (purpose == Purpose.GainWeight)
            {
                if (gender == Gender.Male)
                {
                    return bmr += 500;
                }
                else
                {
                    return bmr += 300;
                }

            }
            else if (purpose == Purpose.LoseWeight)
            {
                if (gender == Gender.Male)
                {
                    return bmr -= 700;
                }
                else
                {
                    return bmr -= 500;

                }

            }
            else
            {
                if (gender == Gender.Male)
                {
                    return bmr;
                }
                else
                {
                    return bmr;
                }

            }

        }

        public double RemainingCalories(int id)
        {
            var limit = DailyCaloriesLimit(id);
            var calculate = CalculateCalories(id);
            var remainCalories = limit - calculate;
            return remainCalories;
        }

        public double GetByCalories(int id)
        {
            return _context.Foods.Where(f=>f.Id==id).Select(f=>f.Calories).FirstOrDefault();
        }

        public List<Meals> GetByMeals(int id)
        {
            return _context.Meals.Where(m=>m.Id == id).ToList();
        }

        public List<Users> GetByName(int id)
        {
            return _context.Users.Where(u=>u.Id == id).ToList();
        }

        public double GetByProteins(int id)
        {
            return _context.Foods.Where(f=>f.Id == id).Select(f=>f.Proteins).FirstOrDefault();
        }

        public double GetByWeight(int id)
        {
            return _context.Foods.Where(f => f.Id == id).Select(f => f.FoodAmount).FirstOrDefault();
        }

        public Users GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email ==email);
        }
    }
}
