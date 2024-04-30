using Homeservise.Domain.core.Action.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Account.Entiti
{
    public class Location
    {
        
        public  int Id { get; set; }
        [Display(Name = "نام استان")]
        public string Province { get; set; }
        [Display(Name = "نام شهر")]
        public string City { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        ////ارتباط با جدول متخصص
        //public Expert Expert { get; set; }
        //ارتباط با جدول مشتری 
        public Customer Customer { get; set; }
        // ارتباط با جدول درخواست های مشتری
        public Request Request { get; set; }



    }
}
