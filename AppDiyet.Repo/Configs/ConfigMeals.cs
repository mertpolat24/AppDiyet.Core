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
    public class ConfigMeals : IEntityTypeConfiguration<Meals>
    {
        public void Configure(EntityTypeBuilder<Meals> builder)
        {
            builder.Ignore(x => x.FoodMealsId);
            builder.Property(x => x.MealName).IsRequired().HasConversion<int>();
            builder.HasMany(x => x.FoodMeals).WithOne(x => x.Meals).HasForeignKey(x => x.MealId);
        }
    }
}
