using Homeservise.Domain.core.Account.Enum;
using Homeservise.Domain.core.Action.Entiti;
using Homeservise.Domain.core.Servises.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Account.Entiti
{
    public class Admin
    {
       
        public int Id { get; set; }

        [Display(Name = "نام")]
        public string Firstname { get; set; }

        [Display(Name = "نام خانوادگی")]
        
        public string Lastname { get; set; }

        [Display(Name = "ایمیل")]
        [AllowNull]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "نام کاربری")]
        [AllowNull]
        public string Username { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "شماره تماس الزامی است!!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "شماره تماس ناموجود یا نادرست است")]
        public string Phonenumber { get; set; }

        public Role Role { get; set; } = Role.Admin;
      
        public DateTime CreateTime { get; set; }

        public DateTime lasteChage { get; set; }

        //// ارتباط با جدول متخخصص
        //public List<Expert> Expert { get; set; }
        //public int ExpertId { get; set; }

        //ارتباط باسرویس
        public List<Servises.Entiti.Servise> Servises { get; set; }
        public int ServisesId { get; set; }

        //ارتباط باکتگوری
        public List<Category> Categories { get; set; }
        public int CategoriesId { get; set; }

        //ارتباط با ساب سرویس
        public List<Subservises> Subservises { get; set; }
        public int SubservisesId { get; set; }

        //ارتباط با امتیاز
        public List<Rate> Rates { get; set; }
        

        //ارتباط با کامنت ها
        public List<Comment> Comments { get; set; }

       





    }
}
