using AppDiyet.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Core.Concretes
{
    public class FoodCategoriesMeals
    {
        public int FoodCategoriesId { get; set; }
        public int MealsId { get; set; }
        public FoodCategories FoodCategories { get; set; }
        public Meals Meals { get; set; }

    }
}
