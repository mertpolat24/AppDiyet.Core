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
            builder.Ignore(x => x.CreateDate);
            builder.Ignore(x => x.UpdateDate);
            builder.Ignore(x => x.DeleteDate);
            builder.HasMany(x => x.Foods).WithOne(x => x.FoodCategories).HasForeignKey(x => x.FoodCategoriesId).OnDelete(DeleteBehavior.NoAction);
            builder.HasData(
                new FoodCategories() {Id = 1, Name = "Sebze yemekleri"},
                new FoodCategories() {Id = 2, Name = "Et yemekleri" },
                new FoodCategories() {Id = 3, Name = "Kızartmalar" },
                new FoodCategories() {Id = 4, Name = "Kızartmalar" },
                new FoodCategories() {Id = 5, Name = "Hamur işleri" },
                new FoodCategories() {Id = 6, Name = "Meyveler" },
                new FoodCategories() {Id = 7, Name = "Sebzeler" },
                new FoodCategories() {Id = 8, Name = "Hayvansal gıdalar" },
                new FoodCategories() {Id = 9, Name = "Kuruyemişler" },
                new FoodCategories() {Id = 10, Name = "Tatlılar" },
                new FoodCategories() {Id = 11, Name = "İçecekler" },
                new FoodCategories() {Id = 12, Name = "Atıştırmalıklar" }
                );                    
        }
    }
}
