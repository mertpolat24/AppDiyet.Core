using AppDiyet.Core.Concretes;
using AppDiyet.Repo.Abstarcts;
using AppDiyet.Repo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Repo.Concretes
{
    public class FoodRepo : BaseRepo<Food>, IFoodRepo
    {
        private readonly AppDbContext _context;
        public FoodRepo(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public double CalculatePortionsCalories(int id, Food amount, Food portionType)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == id);

            double calculatedCalori = food.Calories;
            double calculatedWeight = food.FoodAmount;

            if (calculatedWeight > amount.FoodAmount)
            {
                double oran = calculatedWeight / amount.FoodAmount;
                return calculatedCalori / oran;
            }
            else
            {
                double oran2 = amount.FoodAmount / calculatedWeight;
                return calculatedCalori * oran2;
            }
        }

        public double CalculatePortionsProteins(int id, Food amount, Food portionType)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == id);

            double calculatedProteins = food.Proteins;
            double calculatedWeight = food.FoodAmount;

            if (calculatedWeight > amount.FoodAmount)
            {
                double oran = calculatedWeight / amount.FoodAmount;
                return calculatedProteins / oran;
            }
            else
            {
                double oran2 = amount.FoodAmount / calculatedWeight;
                return calculatedProteins * oran2;
            }
        }
    }
}
