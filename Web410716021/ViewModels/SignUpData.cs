using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410716021.ViewModels
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入性名")]
        [MinLength(2, ErrorMessage = "請輸入2-10個字")]
        [MaxLength(10, ErrorMessage = "請輸入2-10個字")]
        public string Name { get; set; }


        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        [EmailAddress(ErrorMessage = "請輸入正確的email格式")]
        public string Account { get; set; }


        [Display(Name = "密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [StringLength(12, MinimumLength = 6 ,ErrorMessage = "請輸入6-12個字" )]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}