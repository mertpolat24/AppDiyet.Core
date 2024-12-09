﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IMealsRepo : IBaseRepo<Meals>
    {
        DateTime GetByMeals(DateTime dateTime1, DateTime dateTime2); // Ümit
    }
}
