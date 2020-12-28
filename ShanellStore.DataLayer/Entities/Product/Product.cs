using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShanellStore.DataLayer.Entities.Orders;

namespace ShanellStore.DataLayer.Entities.Product
{
    public class Product
    {
        public Product()
        {

        }
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "دسته بندی")]
        public int CategoryId { get; set; }
        [Display(Name = "برند محصول")]
        public int ProductBrandId { get; set; }
        [Display(Name = "رنگ محصول")]
        public int ProductColorId { get; set; }
        [Display(Name = "سایز محصول")]
        public int ProductSizeId { get; set; }
        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
       
        public int Price { get; set; }
        [Display(Name = "موجود است؟")]
        public bool IsAvailable { get; set; }
        [Display(Name = "تعداد")]
        public int  AvailableCount { get; set; }
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
      
        public string ShortDescription { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(800, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "تصویر")]
        //[Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(800, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string ImageName { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }
        [Display(Name = "تصویر")]
        public int? Visit { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int? DiscountPercent { get; set; }
        [Display(Name = "قیمت با تخفیف")]
        public int? DiscountedPrice { get; set; }

        #region relations

        public virtual Category Category { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        public virtual List<UserBasket> UserBaskets { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
