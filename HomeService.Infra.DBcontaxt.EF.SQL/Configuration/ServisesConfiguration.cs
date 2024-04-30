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
    public class ServisesConfiguration : IEntityTypeConfiguration<Servise>
    {
        public void Configure(EntityTypeBuilder<Servise> builder)
        {
            builder.HasMany(x => x.Subservises)
                .WithOne(x => x.Servise).OnDelete(DeleteBehavior.Restrict);
            #region SealdData
            builder.HasData(new List<Servise>()
            {
                new Servise()
                {
                    Id = 1,
                    Titel="خدمات دوره ای نظافتی",
                    CategoryId=1,
                },
                new Servise()
                {
                    Id = 2,
                    Titel="سرمایش و گرمایش",
                    CategoryId=2,
                },
                 new Servise()
                 {
                     Id = 3,
                     Titel="اسباب کشی",
                     CategoryId=3,
                 }
            });
            #endregion
        }
    }
}
