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
        double GetByWeight(Users users); //Yusuf
        double GetByCalories(Users users); //Yusuf
        double GetByProteins(Users users); //Yusuf
        double CalculateCalories(Users users); //Mert
        double CalculateProteins(Users users); //Mert
        double ExceededCalories(Users users); //Mert
        List<Meals> GetByMeals(Users users); // Mustafa
        List<Users> GetByName(int Id); // Mustafa
    }
}
