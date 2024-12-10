using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
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
    public class FoodService : IFoodService
    {
        IFoodRepo _foodRepo = new FoodRepo(new AppDbContext());
        public bool Create(string name, double calories, double proteins, double foodAmount, string description, string imagePath, PortionType portionType)
        {
            if (name is not null && calories > 0 && proteins > 0 && foodAmount > 0 && imagePath is not null && portionType > 0)
            {
                Food food = new Food()
                {
                    Name = name,
                    Calories = calories,
                    Proteins = proteins,
                    FoodAmount = foodAmount,
                    Description = description,
                    ImagePath = imagePath,
                    PortionType = portionType
                };
                _foodRepo.Create(food);
                return true;
            }
            else
                return false;
        }

        public bool Delete(int id)
        {
            if (id > 0)
            {
                var food = _foodRepo.GetById(id);
                _foodRepo.Delete(food);
                return true;
            }
            else
                return false;
        }

        public List<Food> GetAll()
        {
            return _foodRepo.GetAll().ToList();
        }

        public Food GetById(int id)
        {
            return _foodRepo.GetById(id);
        }

        public bool Update(int id, string name, double calories, double proteins, double foodAmount, string description, string imagePath)
        {
            var food = _foodRepo.GetById(id);
            if (name is not null && calories > 0 && proteins > 0 && foodAmount > 0 && imagePath is not null && description is not null)
            {
                food.Name = name;
                food.Calories = calories;
                food.Proteins = proteins;
                food.FoodAmount = foodAmount;
                food.Description = description;
                food.ImagePath = imagePath;

                _foodRepo.Update(food);
                return true;
            }
            else
                return false;
        }

        public double CalculatePortionsCalories(int id, Food amount, Food portionType)
        {
            return _foodRepo.CalculatePortionsCalories(id, amount, portionType);
        }

        public double CalculatePortionsProteins(int id, Food amount, Food portionType)
        {
            return _foodRepo.CalculatePortionsProteins(id, amount, portionType);
        }
    }

}
