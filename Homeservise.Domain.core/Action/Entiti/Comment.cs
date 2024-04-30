using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Entiti
{
    public class Comment
    {
        
        public int Id { get; set; }
        [MaxLength(200)]
        public string Text { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Createdtime { get; set; }

        //ارتباط با جدول مشتری
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        //ارتباط با جدول متخصص
        public Expert Expert { get; set; }
        public int ExpertId { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }
    }
}
