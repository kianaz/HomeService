using Homeservise.Domain.core.Account.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Entiti
{
    public class Category
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }

        public Picture Picture { get; set; }
        //public int PictureId { get; set; }
        //ارتباط با جدول سرویس
        public List<Servise> Servises { get; set; }

        //ارتباط با جدول ادمین
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
    }
}
