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
    public class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.
                HasData(
                new Picture() 
                {
                    Id=1 ,
                  // ExpertId=1,
                   PictureUrl= "https://th.bing.com/th/id/OIP.DLHhRiRhIpjzEjOYgGuFowHaKn?w=202&h=290&c=7&r=0&o=5&dpr=1.3&pid=1.7"
                }, 
                new Picture()
                {
                    Id = 2,
                    PictureUrl="https://th.bing.com/th/id/OIP.2tgDgJDGwPFnBIvFEvPNgwHaHa?w=165&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    CategoryId=1
                },
                new Picture() 
                {
                    Id = 3,
                    PictureUrl="https://pearllemonproperties.com/wp-content/uploads/2021/03/house-construction.jpg",
                    CategoryId = 2
                },
                new Picture() 
                {
                    Id = 4,
                    PictureUrl="https://th.bing.com/th/id/OIP.7uW-NQKW4ExV4rAYUHzP3QHaF3?w=198&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7",
                    CategoryId = 3
                });
            
        }
    }
}
