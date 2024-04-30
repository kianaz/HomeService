using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Account.Enum;
using Homeservise.Domain.core.Action.Entiti;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.Infra.DBcontaxt.EF.SQL.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(x => x.Rate)
                .WithOne(x => x.Customer);

            builder.HasOne(x => x.Request)
                .WithOne(x => x.Customer).
                HasForeignKey<Request>(x => x.CustomerId);
            builder.HasOne(x => x.Request)
                .WithOne(x => x.Customer).
                OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(x => x.Location)
            //   .WithOne(x => x.Customer);

            builder.HasMany(x => x.Comment)
                .WithOne(x => x.Customer);



            #region SealdData
            builder.HasData(new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    Firstname="diana",
                    Lastname="didari",
                    Email="d.d@gmail.com",
                    Password="11dd22",
                    Phonenumber="09775588442",
                    Role=Role.Customer,
                    Username="Customer",
                    LocationId=2
            
                }
            });
            #endregion
        }
    }
}
