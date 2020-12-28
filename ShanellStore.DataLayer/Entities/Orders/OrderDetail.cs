using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.DataLayer.Entities.Orders
{
   public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ProductBrandId { get; set; }
        [Required]
        public int ProductColorId { get; set; }
        [Required]
        public int ProductSizeId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Price { get; set; }
        public int? DiscountedPrice { get; set; }

        #region relations
        public Order Order { get; set; }
        public Product.Product Product { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        #endregion

    }
}
