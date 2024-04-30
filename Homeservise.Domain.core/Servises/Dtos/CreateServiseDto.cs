using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Dtos
{
    public class CreateServiseDto
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string CategoriName { get; set; }
        public int CategoryId { get; set; }
        
    }
}
