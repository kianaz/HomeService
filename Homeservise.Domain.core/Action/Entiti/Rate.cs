using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Entiti
{
    public class Rate
    {
        
        public int ExpertId { get; set; }
       
        public int CustomerId { get; set; }
        [AllowNull]
        [MaxLength(5)]
        public int Stare { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }

        //ارتباط با جدول متخصص
        public Expert Expert { get; set; }

        //ارتباط با جدول مشتری
        public Customer Customer { get; set; }





    }
}
