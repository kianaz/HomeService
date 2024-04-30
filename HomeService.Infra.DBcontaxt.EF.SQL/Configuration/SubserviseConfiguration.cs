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
    public class SubserviseConfiguration : IEntityTypeConfiguration<Subservises>
    {
        public void Configure(EntityTypeBuilder<Subservises> builder)
        {
            

        }
    }
}
