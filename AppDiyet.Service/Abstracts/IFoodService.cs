using AppDiyet.Core.Concretes;
using AppDiyet.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Abstracts
{
    public interface IFoodService
    {
        bool Create(string name, double calories, double proteins, double foodAmount, string description, string imagePath, PortionType portionType);
        bool Update(int id, string name, double calories, double proteins, double foodAmount, string description, string imagePath);
        bool Delete(int id);
        List<Food> GetAll();
        Food GetById(int id);
        double CalculatePortionsCalories(int id, double amount, PortionType portionType);
        double CalculatePortionsProteins(int id, double amount, PortionType portionType);
        //test hebele
    }
}
