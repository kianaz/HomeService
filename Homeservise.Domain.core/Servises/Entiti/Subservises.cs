using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Entiti
{
    public class Subservises
    {

        public int Id { get; set; }
        public string Titel { get; set; }
        public string Describtion { get; set; }
        [Display(Name = "شروع قیمت")]
        public double MinPrice { get; set; }

        public Picture Picture { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }
        public int AdminId { get; set; }

        //ارتباط با جدول متخصص
        public List<Expert> Experts { get; set; }

        //ارتباط با دجدول خدمات
        public Servise Servise { get; set; }
        public int ServiseId { get; set; }



    }
}
