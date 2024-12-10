using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;
using AppDiyet.Core.Enums;

namespace AppDiyet.Core.Concretes
{
    public class Meals : BaseEntity
    {
        public MealCategories MealName { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public int FoodMealsId { get; set; }
        public ICollection<FoodMeals>  FoodMeals{ get; set; }
    }
}
