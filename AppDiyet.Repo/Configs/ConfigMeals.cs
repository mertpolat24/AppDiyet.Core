﻿using AppDiyet.Core.Concretes;
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
        
            builder.Property(x => x.MealName).IsRequired().HasConversion<int>();
            builder.HasOne(x => x.Food).WithMany().HasForeignKey(x => x.FoodId);
        }
    }
}
