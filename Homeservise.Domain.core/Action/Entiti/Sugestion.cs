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
    public class Sugestion
    {
        public int Id { get; set; }
        [MaxLength(70)]
        [Display(Name = "عنوان پیشنهاد")]
        public string Titel { get; set; }
        [MaxLength(200)]
        [Display(Name = "شرح پیشنهاد به درخواست مشتری")]
        public string Describtion { get; set; }
        [Display(Name = "قیمت پیشنهادی")]
        public double Price { get; set; }

        public NotDesidedPrice NotDesidedPrice { get; set; }

        public bool IsAcceptByCustomer { get; set; }

        public Status SuggestionStatus { get; set; }

        // ارتباط با جدول درخواست های مشتری
        public Request Requests { get; set; }

        //ارتباط با جدول متخصص 
        public int ExpertId { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }







    }
}
