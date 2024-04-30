using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Action.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Entiti
{
    public class Request
    {
        public int Id { get; set; }
        [MaxLength(70)]
        [Display(Name ="عنوان درخواست")]
        public string Titel { get; set; }
        [MaxLength(200)]
        [Display(Name = "شرح درخواست")]
        public string Describtion { get; set; }
        public List<Picture> Pictures { get; set; }
        public Status RequestStatus { get; set; }
        public List<Location> Location { get; set; }
        //ارتباط با جدول مشتری 
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        //ارتباط با جدول پیشنهاد متخصص
        public List<Sugestion> Sugestions { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }

        


    }
}
