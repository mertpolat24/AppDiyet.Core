using AppDiyet.Core.Concretes;
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
        bool Update(int id, Meals meals);
        bool Add(Meals meal);
        Meals GetById(int id);
        Meals GetByName(Meals meals);
        List<Meals> GetAll();
        List<Meals> GetByMeals(DateTime dateTime1, DateTime dateTime2);

    }
}
