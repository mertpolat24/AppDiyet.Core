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
    public class ConfigFood : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
           builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");
           builder.Property(x => x.Calories).IsRequired().HasColumnType("decimal(7,2)");
           builder.Property(x => x.Proteins).IsRequired().HasColumnType("decimal(7,2)");
           builder.Property(x => x.FoodWeight).IsRequired().HasColumnType("decimal(7,2)");
           builder.Property(x => x.Description).IsRequired(false).HasColumnType("nvarchar(250)");
        }
    }
}
