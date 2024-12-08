using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDiyet.Core.Concretes;

namespace AppDiyet.Repo.Abstarcts
{
    public interface IFoodCategoriesRepo 
    {
        FoodCategories GetFoodCategories(string name);
    }
}
