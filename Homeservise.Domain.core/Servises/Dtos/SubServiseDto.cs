using Homeservise.Domain.core.Account.Entiti;
using Homeservise.Domain.core.Servises.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Servises.Dtos
{
    public class SubServiseDto
    {
        public int Id { get; set; }
   
        public string Titel { get; set; }
        public string Describtion { get; set; }
        [Display(Name = "شروع قیمت")]
        public double MinPrice { get; set; }
        public string ServiseName { get; set; }
        public int ServiseId { get; set; }
        [Display(Name = "نام متخصص")]
        public List<string> ExpertFirstName { get; set; }
        [Display(Name = "نام خانوادگی متخصص")]
        public string ExpertlastName { get; set; }
    }
}
