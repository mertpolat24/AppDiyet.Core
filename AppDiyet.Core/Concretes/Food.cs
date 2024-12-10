using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;
using AppDiyet.Core.Enums;

namespace AppDiyet.Core.Concretes
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double FoodAmount { get; set; }
        public string? Description { get; set; }

        //public BinaryData BinaryData { get; set; } Resim eklenecek dokunmayın.
        public PortionType PortionType { get; set; }
        public int FoodCategoriesId { get; set; }
        public FoodCategories FoodCategories { get; set; }
        public ICollection<FoodMeals> FoodMeals { get; set; }
    }
}
