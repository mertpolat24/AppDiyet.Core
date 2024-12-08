using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;

namespace AppDiyet.Core.Concretes
{
    public class FoodCategories 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Food>  Foods { get; set; }
    }
}
