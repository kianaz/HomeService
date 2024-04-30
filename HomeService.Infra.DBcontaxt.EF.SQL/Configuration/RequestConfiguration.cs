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
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasMany(x => x.Sugestions)
                .WithOne(x => x.Requests);
            //builder.HasMany(x => x.Pictures)
            //   .WithOne(x => x.RequestId);
            builder.HasMany(x => x.Location)
               .WithOne(x => x.Request);
        }
    }
}
