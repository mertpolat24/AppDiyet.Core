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
        double GetByWeight(Users users);
        double GetByCalories(Users users);
        double GetByProteins(Users users);
        double CalculateCalories(Users users);
        double CalculateProteins(Users users);
        double ExceededCalories(Users users);
        Meals GetByMeals(Meals meals);
        Users GetByName(int Id);
    }
}
