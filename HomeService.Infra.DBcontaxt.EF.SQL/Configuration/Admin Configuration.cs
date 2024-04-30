using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Account.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Infra.DBcontaxt.EF.SQL.Configuration
{
    public class Admin_Configuration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasMany(a => a.Servises)
                .WithOne(a => a.Admin);
            builder.HasMany(a => a.Subservises)
                .WithOne(a => a.Admin);
            builder.HasMany(a => a.Categories)
               .WithOne(a => a.Admin);
            builder.HasMany(a => a.Rates)
              .WithOne(a => a.Admin);
            builder.HasMany(a => a.Comments)
             .WithOne(a => a.Admin);
            builder.HasMany(a => a.Expert)
            .WithOne(a => a.Admin);
            #region SealdData
            builder.HasData(new List<Admin>()
            {
                new Admin()
                {
                    Id = 1,
                    Firstname="Ali",
                    Lastname="Abasi",
                    Email="a.a@gmail.com",
                    Password="11aa22",
                    Phonenumber="093877592881",
                    Role=Role.Admin,
                    Username="admin",
                  
                }
            });
            #endregion

        }
    }
}
