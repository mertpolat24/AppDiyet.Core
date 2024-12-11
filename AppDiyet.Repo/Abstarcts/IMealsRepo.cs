using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IMealsRepo : IBaseRepo<Meals>
    {
        List<dynamic> GetByMeals(int id, DateTime dateTime1, DateTime dateTime2);
        List<dynamic> MealFood(int id);
    }
}
