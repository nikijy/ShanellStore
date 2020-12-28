using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.DataLayer.Entities.Orders
{
    public class UserOrder
    {
        public UserOrder()
        {

        }
        [Key]
        public int UO_Id { get; set; }
        public int UserId { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string LastName { get; set; }
        [Display(Name = "شماره همراه")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "شماره همراه معتبر نیست")]
        public string Phone { get; set; }
        [Display(Name = "آدرس کامل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(500, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Address { get; set; }
        [Display(Name = "کد پستی")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
       [RegularExpression(@"^\d{10}$",ErrorMessage = "کدپستی معتبر نیست")]
        public int PostCode { get; set; }

        #region relations

        public virtual User.User User { get; set; }

        #endregion
    }
}
