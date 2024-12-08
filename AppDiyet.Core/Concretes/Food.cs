using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;

namespace AppDiyet.Core.Concretes
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double FoodWeight { get; set; }
        public string? Description { get; set; }
        public int FoodCategoriesId { get; set; }
        public FoodCategories FoodCategories { get; set; }
    }
}
