﻿using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
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

        public double CalculatePortionsCalories(int id, double amount, PortionType portionType)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == id);

            double calculatedCalori = food.Calories;
            double calculatedWeight = food.FoodAmount;

            if (calculatedWeight > amount)
            {
                double oran = calculatedWeight / amount;
                return calculatedCalori / oran;
            }
            else
            {
                double oran2 = amount / calculatedWeight;
                return calculatedCalori * oran2;
            }
        }

        public double CalculatePortionsProteins(int id, double amount, PortionType portionType)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == id);

            double calculatedProteins = food.Proteins;
            double calculatedWeight = food.FoodAmount;

            if (calculatedWeight > amount)
            {
                double oran = calculatedWeight / amount;
                return calculatedProteins / oran;
            }
            else
            {
                double oran2 = amount/ calculatedWeight;
                return calculatedProteins * oran2;
            }
        }
        
    }
}
