using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Servises.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Dtos
{
    public class CategoriDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PictureUrl { get; set; }

    }
}
