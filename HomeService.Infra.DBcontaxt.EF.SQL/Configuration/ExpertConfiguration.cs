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
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            //builder.HasOne(x => x.Pictures).
            //    WithOne(x => x.Expert);
            //builder.HasOne(x => x.Sugestion)
            //    .WithOne(x => x.Expert);
            //builder.HasOne(x => x.Location)
            //    .WithOne(x => x.Expert);


            builder.HasMany(a => a.Subservises)
           .WithMany(a => a.Experts);

            builder.HasMany(a => a.Comments)
           .WithOne(a => a.Expert);

            builder.HasMany(a => a.Rates)
          .WithOne(a => a.Expert);

            #region SealdData
            builder.HasData(new List<Expert>()
            {
                new Expert()
                {
                    Id = 1,
                    Firstname="baran",
                    Lastname="barani",
                    Email="b.b@gmail.com",
                    Password="11bb22",
                    Phonenumber="09578964255",
                    Role=Role.Expert,
                    Username="Expert",
                    PictureId=1,
                    BanckAccuntNO="4444 5656 7777 1645",
                    LocationId=2

                }
            });
            #endregion



        }
    }
}
