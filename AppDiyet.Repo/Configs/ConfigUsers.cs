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
    public class ConfigUsers : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.LastName).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.Lenght).IsRequired().HasColumnType("decimal(5,2)");
            builder.Property(x => x.Weight).IsRequired().HasColumnType("decimal(5,2)");
            builder.Property(x => x.TargetWeight).IsRequired().HasColumnType("decimal(5,2)");
            builder.Property(x => x.Age).IsRequired().HasColumnType("int");
            builder.Property(x => x.Activities).IsRequired().HasConversion<int>();
            builder.Property(x => x.Purpose).IsRequired().HasConversion<int>();
            builder.Property(x => x.Gender).IsRequired().HasConversion<int>();
            builder.Property(x => x.MealsCount).IsRequired().HasColumnType("int");
            builder.Property(x => x.ImagePath).IsRequired().HasColumnType("nvarchar(350)");
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Password).IsUnique();
            builder.HasMany(x => x.Meals).WithOne(x => x.Users).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
