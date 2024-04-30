using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Text { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Createdtime { get; set; }
        public String CustomerName { get; set; }
    }
}
