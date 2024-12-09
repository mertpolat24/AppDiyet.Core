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
    public class ConfigFoodMeals : IEntityTypeConfiguration<FoodMeals>
    {
        public void Configure(EntityTypeBuilder<FoodMeals> builder)
        {

            builder.Ignore(x => x.CreateDate);
            builder.Ignore(x => x.DeleteDate);
            builder.Ignore(x => x.UpdateDate);
            builder.HasOne(x => x.Food).WithMany(x => x.FoodMeals).HasForeignKey(x => x.FoodId);
            builder.HasOne(x => x.Meals).WithMany(x => x.FoodMeals).HasForeignKey(x => x.MealId);
        }
    }
}
