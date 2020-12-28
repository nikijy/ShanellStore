using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.Core.DTOs.Blog
{
   public class BlogViewModel
    {
        public int BlogId { get; set; }
        [Display(Name = "نویسنده")]
        public string UserName { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "توضیح کوتاه")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string ShortDescription { get; set; }
        [Display(Name = "تصویر")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string ImageName { get; set; }
    }
}
