using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.Core.DTOs.User
{
   public class UsersViewModel
    {
        public int UserId { get; set; }
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string Email { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime? RegisterDate { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }
    }
   public class EditUserViewModel
   {
       public int UserId { get; set; }
       public string UserName { get; set; }

       [Display(Name = "ایمیل")]
       [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
       [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
       [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
       public string Email { get; set; }

       [Display(Name = "کلمه عبور")]
       [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
       public string Password { get; set; }

       public List<int> UserRoles { get; set; }

   }
  
}
