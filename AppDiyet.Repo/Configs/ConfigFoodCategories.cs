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
    public class ConfigFoodCategories : IEntityTypeConfiguration<FoodCategories>
    {
        public void Configure(EntityTypeBuilder<FoodCategories> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Foods).WithOne(x => x.FoodCategories).HasForeignKey(x => x.FoodCategoriesId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
