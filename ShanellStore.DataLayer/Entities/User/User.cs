using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShanellStore.DataLayer.Entities.Blog;
using ShanellStore.DataLayer.Entities.Orders;

namespace ShanellStore.DataLayer.Entities.User
{
    public class User
    {
        public User()
        {
            
        }
        [Key]
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
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Password { get; set; }
        [Display(Name = "کد فعالسازی")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string ActiveCode { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime? RegisterDate { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }

        #region relations

        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<UserDiscountCode> UserDiscountCodes { get; set; }
        public virtual List<Blog.Blog> Blogs { get; set; }
        public virtual List<BlogComment> BlogComments { get; set; }
        public virtual List<UserBasket> UserBaskets { get; set; }
        public virtual List<UserOrder> UserOrders { get; set; }

        #endregion
    }
}
