using AppDiyet.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Core.Concretes
{
    public class FoodMeals : BaseEntity
    {
        public int FoodId{ get; set; }
        public int? MealId{ get; set; }
        public Food Food { get; set; }
        public Meals Meals { get; set; }
    }
}
