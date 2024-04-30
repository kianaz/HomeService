using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeservise.Domain.core.Action.Enum
{
    public enum Status
    {
        [Display(Name="درحال انتظار پاسخ متخصصان")]
        WaitingbyExpert = 1,
        [Display(Name = "درحال انتظار پاسخ مشتری")]
        WaitingbyCustomer ,
        [Display(Name = "پذیرش درخواست توسط متخصص")]
        AcceptebyExpert,
        [Display(Name = "پذیرش درخواست توسط متخصص")]
        AcceptebyCustomer,
        [Display(Name = " عدم پذیرش درخواست توسط متخصص")]
        RejectbyExpert,
        [Display(Name = " عدم پذیرش درخواست توسط مشتری")]
        RejectbyCustomer,
        [Display(Name = "در حال انجام کار")]
        DuringProcess,
        [Display(Name = "لغو عملیات توسط متخصص")]
        CancelProssesByExpert,
        [Display(Name = "لغو عملیات توسط مشتری")]
        CancelProssesByCustomer,
        [Display(Name = "پایان عملیات")]
        EndOfprocess

    }
}
