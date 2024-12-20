﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IUsersRepo : IBaseRepo<Users>
    {
        Users GetByEmail(string email);
        double GetByWeight(int id); 
        double GetByCalories(int id); 
        double GetByProteins(int id); 
        double CalculateCalories(int id); 
        double CalculateProteins(int id); 
        double DailyCaloriesLimit(int id); 
        double RemainingCalories(int id);
        List<MealCategories> GetByMeals(int id); 
        List<Users> GetByName(int id); 
    }
}
