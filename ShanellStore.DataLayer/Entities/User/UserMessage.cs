using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.DataLayer.Entities.User
{
   public class UserMessage
    {
        public UserMessage()
        {
            
        }
        [Key]
        public int UM_Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر نیست")]
        public string Email { get; set; }
        [Display(Name = "وبسایت")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Website { get; set; }
        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(700, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Text { get; set; }
        [Display(Name = "تاریخ")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }

        #region relations

     

        #endregion
    }
}
