using AppDiyet.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Abstracts
{
    public interface IUserService
    {
        bool Create(string firstName, string lastName, string email, string password, int age, double lenght, double weight);
        bool Update(int id, string email, string password, int age, double lenght, double weight);
        bool Delete(int id);
        List<Users> GetAll();
        Users GetById(int id);
        Users GetByEmail(string email);
        double GetByWeight(int id);
        double GetByCalories(int id);
        double GetByProteins(int id);
        double CalculateCalories(int id);
        double CalculateProteins(int id);
        double DailyCaloriesLimit(int id);
        double RemainingCalories(int id);
        List<Meals> GetByMeals(int id);
        List<Users> GetByName(int id);
    }
}
