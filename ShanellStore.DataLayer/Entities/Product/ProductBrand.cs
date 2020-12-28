using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShanellStore.DataLayer.Entities.Orders;

namespace ShanellStore.DataLayer.Entities.Product
{
    public class ProductBrand
    {
        public ProductBrand()
        {

        }
        [Key]
        public int ProductBrandId { get; set; }
        [Display(Name = "برند محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string BrandName { get; set; }

        #region relations

        public virtual List<Product> Products { get; set; }
        public virtual List<UserBasket> UserBaskets { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        #endregion
    }


}
