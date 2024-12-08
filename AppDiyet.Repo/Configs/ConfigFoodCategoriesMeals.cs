using AppDiyet.Core.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDiyet.Repo.Configs
{
    public class ConfigFoodCategoriesMeals : IEntityTypeConfiguration<FoodCategoriesMeals>
    {
        public void Configure(EntityTypeBuilder<FoodCategoriesMeals> builder)
        {
            builder.HasKey(fm => new {fm.FoodCategoriesId, fm.MealsId});
        }
    }
}
