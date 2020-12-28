using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShanellStore.DataLayer.Entities.Orders;
using ShanellStore.DataLayer.Entities.Product;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.DataLayer.Entities.Blog
{
    public class BlogComment
    {
        public BlogComment()
        {

        }
        [Key]
        public int BC_Id { get; set; }

        public int BlogId { get; set; }
        public int UserId { get; set; }
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
        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(800, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Comment { get; set; }
        [Display(Name = "")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "")]
        public bool? IsDeleted { get; set; }

        #region relations
        [ForeignKey("UserId")]
        public virtual User.User User { get; set; }
        public virtual Blog Blog { get; set; }

        #endregion
       
    }
}
