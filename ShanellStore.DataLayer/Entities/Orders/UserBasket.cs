using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.DataLayer.Entities.Orders
{
    public class UserBasket
    {
        public UserBasket()
        {

        }
        [Key]
        public int UB_Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int ProductBrandId { get; set; }
        public int ProductColorId { get; set; }
        public int ProductSizeId { get; set; }
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public int Count { get; set; }
        [Display(Name = "مبلغ کل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public int SumPrice { get; set; }
        public bool IsFinally { get; set; }
        [Display(Name = "تاریخ")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public DateTime? CreateDate { get; set; }

        #region relations

        public virtual User.User User { get; set; }
        
        public virtual Product.Product Product { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }

        #endregion
    }
}
