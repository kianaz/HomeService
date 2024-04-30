using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.core.Servises.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Account.Entiti
{
    public class Picture
    {
        public int Id { get; set; }
        public string PictureUrl { get; set; }
        public int RequestId { get; set; }
        public Expert Expert { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
