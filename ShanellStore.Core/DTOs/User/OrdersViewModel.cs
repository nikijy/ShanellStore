using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.Core.DTOs.User
{
    public class OrdersViewModel
    {
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public int Numbers { get; set; }
        [Display(Name = "مبلغ کل")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public int SumPrice { get; set; }
        public bool IsFinally { get; set; }
        [Display(Name = "تاریخ")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]

        public int Price { get; set; }
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1}کاراکتر باشد")]
        public string Name { get; set; }
    }

    public class ShowOrderViewModel
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Sum { get; set; }
        public int DiscountedPrice { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsFinally { get; set; }
        public bool IsAvailable { get; set; }

    }
}
