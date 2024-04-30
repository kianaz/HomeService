using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Action.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Dtos
{
    public class CreaterequestDTO
    {
        public int Id { get; set; }
        [MaxLength(70)]
        [Display(Name = "عنوان درخواست")]
        public string Titel { get; set; }
        [MaxLength(200)]
        [Display(Name = "شرح درخواست")]
        public string Describtion { get; set; }

        public List<string> Pictures { get; set; }
        [Display(Name = "شهر")]
        public string LocationCity { get; set; }
        [Display(Name = "استان")]
        public string LocationProvinc { get; set; }
        [Display(Name = "آدرس ")]
        public string Adress { get; set; }

    }
}
