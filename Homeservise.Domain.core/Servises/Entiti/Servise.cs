using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Entiti
{
    public class Servise
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        //ارتباط با جدول کتگوری
        public Category  Category{ get; set; }
        public int CategoryId { get; set; }

        //ارتباط با جدول سابسرویس
        public List<Subservises> Subservises { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }
        public int AdminId { get; set; }

        ////ارتباط با جدول متخصص
        //public List<Expert> Experts { get; set; }



    }
}
