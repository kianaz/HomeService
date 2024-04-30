using Homeservise.Domain.core.Account.Entiti;
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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(new Location()
            {
                Id=1,
                City="Tehran",
                Province="Tehran",
                Address=".......",
               
            });
            builder.HasData(new Location()
            {
                Id = 2,
                City = "Kerman",
                Province = "Kerman",
                Address = "*****",

            });
        }
    }
}
