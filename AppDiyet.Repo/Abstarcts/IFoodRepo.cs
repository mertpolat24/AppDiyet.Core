using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IFoodRepo : IBaseRepo<Food>
    {
        double CalculatePortionsCalories(int id, Food amount, Food portionType); 
        double CalculatePortionsProteins(int id, Food amount, Food portionType); 
    }
}
