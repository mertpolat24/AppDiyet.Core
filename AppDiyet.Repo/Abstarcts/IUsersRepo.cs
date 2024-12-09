using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IUsersRepo : IBaseRepo<Users>
    {
        //teslim öğlen 12 
        double GetByWeight(int id); //Yusuf
        double GetByCalories(int id); //Yusuf
        double GetByProteins(int id); //Yusuf
        double CalculateCalories(int id); 
        double CalculateProteins(int id); 
        double DailyCaloriesLimit(int id); 
        double RemainingCalories(int id); 
        List<Meals> GetByMeals(int id); // Mustafa
        List<Users> GetByName(int id); // Mustafa
    }
}
