using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.core.Action.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Dtos
{
    public class SuggestionDto
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

        public string RequestsTitel { get; set; }

           
    }
}
