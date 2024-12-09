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
           var mealsList =  _context.Meals.Include(x => x.Food).Where(x => x.UserId == id && x.CreateDate.Day == DateTime.Now.Day).ToList();
            if(!mealsList.Any())
                return 0;

            double totalCalories = mealsList.Sum(x => x.Food.Calories);
            return totalCalories;
        }

        public double CalculateProteins(int id)
        {
            var mealsList = _context.Meals.Include(x => x.Food).Where(x => x.UserId == id && x.CreateDate.Day == DateTime.Now.Day).ToList();
            if (!mealsList.Any())
                return 0;

            double totalCalories = mealsList.Sum(x => x.Food.Proteins);
            return totalCalories;
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
                bmr = ((10 * weight) + (6.25 * lenght) - (5 * age + 5)) * activitiesMultiplier;



            if (purpose == Purpose.GainWeight)
            {
                if(gender == Gender.Male)
                {
                    return bmr += 500;
                }
                else
                {
                    return bmr += 300;
                }

            }
            else if(purpose == Purpose.LoseWeight)
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
            var remainCalories = limit -calculate;
            return remainCalories;
        }

        public double GetByCalories(int id)
        {
            throw new NotImplementedException();
        }

        public List<Meals> GetByMeals(int id)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetByName(int id)
        {
            throw new NotImplementedException();
        }

        public double GetByProteins(int id)
        {
            throw new NotImplementedException();
        }

        public double GetByWeight(int id)
        {
            throw new NotImplementedException();
        }
    }
}
