using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Abstract;

namespace AppDiyet.Core.Concretes
{
    public class FoodCategories : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Food>  Foods { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
