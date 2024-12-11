using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Concretes;
using AppDiyet.Repo.Context;
using AppDiyet.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Services
{
    public class UserService : IUserService
    {
        IUsersRepo repo = new UserRepo(new AppDbContext());
        public double CalculateCalories(int id)
        {
            return repo.CalculateCalories(id);
        }

        public double CalculateProteins(int id)
        {
            return repo.CalculateProteins(id);
        }

        public bool Create(string firstName, string lastName, string email, string password, int age, double lenght, double weight, Gender gender, Purpose purpose, Activities activities, int mealsCount, double targetWeight, string imagePath)
        {
            var userEmail = repo.GetByEmail(email);
            if (userEmail is null)
            {
                Users users = new Users()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    Age = age,
                    Lenght = lenght,
                    Weight = weight,
                    Gender = gender,
                    Purpose = purpose,
                    Activities = activities,
                    MealsCount = mealsCount,
                    TargetWeight = targetWeight,
                    ImagePath = imagePath

                };
                return repo.Create(users);
            }
            else
            {
                throw new Exception("Bu email ile kayıtlı olan bir kullanıcı mevcut!");
            }

        }

        public double DailyCaloriesLimit(int id)
        {
            return repo.DailyCaloriesLimit(id);
        }

        public bool Delete(int id)
        {
            var user = repo.GetById(id);
            return repo.Delete(user);

        }

        public List<Users> GetAll()
        {
            return repo.GetAll().ToList();
        }

        public double GetByCalories(int id)
        {
            return repo.GetByCalories(id);
        }

        public Users GetByEmail(string email)
        {
            return repo.GetByEmail(email);
        }

        public Users GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<MealCategories> GetByMeals(int id)
        {
            return repo.GetByMeals(id);
        }

        public List<Users> GetByName(int id)
        {
            return repo.GetByName(id);
        }

        public double GetByProteins(int id)
        {
            return repo.GetByProteins(id);
        }

        public double GetByWeight(int id)
        {
            return repo.GetByWeight(id);
        }

        public double RemainingCalories(int id)
        {
            return repo.RemainingCalories(id);
        }

        public bool Update(int id, string password, int age, double lenght, double weight, Activities activities, Purpose purpose, int mealCount, double targetWeight, string imagePath)
        {
            var user = repo.GetById(id);
            if (user is not null)
            {
                    user.Password = password;
                    user.Age = age;
                    user.Weight = weight;
                    user.Lenght = lenght;
                    user.Purpose = purpose;
                    user.TargetWeight = targetWeight;
                    user.ImagePath = imagePath;
                    user.Activities = activities;
                    user.MealsCount = mealCount;
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
