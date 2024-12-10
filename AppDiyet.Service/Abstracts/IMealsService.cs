﻿using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Abstracts
{
    public interface IMealsService
    {
        bool Delete(int id);
        bool Update(int id, MealCategories name, DateTime createDate);
        bool Add(MealCategories meals);
        Meals GetById(int id);
        Meals GetByName(MealCategories meals);
        List<Meals> GetAll();
        List<Meals> GetByMeals(DateTime dateTime1, DateTime dateTime2);

    }
}