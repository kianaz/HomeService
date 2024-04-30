using Homeservise.Domain.core.Account.Enum;
using Homeservise.Domain.core.Action.Entiti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Account.Entiti
{
    public class Customer
    {

       
        public int Id { get; set; }

        [Display(Name = "نام")]
        public string Firstname { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Lastname { get; set; }

        [Display(Name = "ایمیل")]
        [AllowNull]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "نام کاربری")]
        public string Username { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "شماره تماس الزامی است!!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "شماره تماس ناموجود یا نادرست است")]
        public string Phonenumber { get; set; }

        public Role Role { get; set; } = Role.Customer;

     

        public int LocationId { get; set; }

        public DateTime CreateTime { get; set; }
        
        public DateTime lasteChane { get; set; }

        //ارتباط با جدول درخواست
        public Request Request { get; set; }
       // public int RequestId { get; set; }

        //ارتباظ با جدول کامنت
        public List<Comment> Comment { get; set; }
       

        //ارتباط با جدول امتیاز
        public Rate Rate { get; set; }
        public int RateId { get; set; }

       
        

      


    }
}
