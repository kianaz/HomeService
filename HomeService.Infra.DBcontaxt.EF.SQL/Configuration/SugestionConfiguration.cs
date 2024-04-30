using Homeservise.Domain.core.Account.Entiti;
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
    public class SugestionConfiguration : IEntityTypeConfiguration<Sugestion>
    {
        public void Configure(EntityTypeBuilder<Sugestion> builder)
        {
            throw new NotImplementedException();
        }
    }
}
