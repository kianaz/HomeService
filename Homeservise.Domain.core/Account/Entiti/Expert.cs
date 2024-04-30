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
    public class Expert
    {

       
        public int Id { get; set; }
        [Display(Name = "نام")]
        public string Firstname { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Lastname { get; set; }
        [Display(Name = "ایمیل")]
        [DataType(DataType.EmailAddress)]
        [AllowNull]
        public string Email { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "نام کاربری")]
        [AllowNull]
        public string Username { get; set; }
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "شماره تماس الزامی است!!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "شماره تماس ناموجود یا نادرست است")]
        public string Phonenumber { get; set; }

        [Display(Name = "شماره حساب بانکی")]
        public string BanckAccuntNO { get; set; }

        public Role Role { get; set; } = Role.Expert;

        //public Location Location { get; set; }

        public int LocationId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime lasteChane { get; set; }

        //public Picture Picture { get; set; }
        public int PictureId { get; set; }
        ////ارتباط با جدول ادمین
        //[AllowNull]
        //public Admin Admin{ get; set; }
        //public int AdminId { get; set; }

        //ارتباط با جدول کامنت
        public List<Comment> Comments { get; set; }
        public int CommentsId { get; set; }

        //ارتباط با جدول امتیاز
        public List<Rate> Rates { get; set; }
        public int RateId { get; set; }

        //ارتباط با دجدول خدمات
        public List<Subservises> Subservises { get; set; }
        public int SubservisesId { get; set; }

        //ارتباط با جدول پیشنهادات متخصص
        public Sugestion Sugestion { get; set; }
       // public int SugestionId { get; set; }
    }
}
