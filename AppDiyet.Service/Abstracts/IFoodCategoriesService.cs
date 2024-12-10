using AppDiyet.Core.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Service.Abstracts
{
    public interface IFoodCategoriesService
    {
        FoodCategories GetById(int id);
        List<FoodCategories> GetAll();
      
    }

}
