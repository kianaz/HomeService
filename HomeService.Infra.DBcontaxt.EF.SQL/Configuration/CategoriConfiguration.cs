using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Account.Enum;
using Homeservise.Domain.core.Servises.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Infra.DBcontaxt.EF.SQL.Configuration
{
    public class CategoriConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Servises)
                .WithOne(c => c.Category).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Picture) 
            .WithOne(p => p.Category) 
            .HasForeignKey<Picture>(p => p.CategoryId);

            #region SealdData
            builder.HasData(new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name="نظافت ساختمان",
                },
                new Category()
                {
                    Id = 2,
                    Name="تاسیسات ساختمان",
                },
                new Category()
                {
                    Id = 3,
                    Name="اسباب کشی و بار بری",
                    
                }
            });
            #endregion
        }
    }
}
