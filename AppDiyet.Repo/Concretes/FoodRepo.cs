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

        public double CalculatePortions(int id, Food weight)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == id);

            double calculatedCalori = food.Calories;
            double calculatedWeight = food.FoodWeight;

            if (calculatedWeight > weight.FoodWeight)
            {
                double oran = calculatedWeight / weight.FoodWeight;
                return calculatedCalori / oran;
            }
            else
            { 
                double oran2 = weight.FoodWeight / calculatedWeight;
                return calculatedCalori * oran2;
            }
            
        }
    }
}
