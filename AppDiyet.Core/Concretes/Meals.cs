using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;
using AppDiyet.Core.Enums;

namespace AppDiyet.Core.Concretes
{
    public class Meals : BaseEntity
    {
        public string Name { get; set; }
        public DateTime MealDate { get; set; }
        public MealCategories MealCategories { get; set; }
        public int UserId { get; set; }
    }
}
