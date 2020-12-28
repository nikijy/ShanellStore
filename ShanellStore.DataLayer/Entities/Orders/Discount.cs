using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.DataLayer.Entities.Orders
{
    public class Discount
    {
        public Discount()
        {

        }

        [Key]
        public int DiscountId { get; set; }
        [Display(Name = "کد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150)]
        public string DiscountCode { get; set; }
        [Display(Name = "درصد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int DiscountPercent { get; set; }
        public int? UsableCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Display(Name = "حذف شده؟")]
        public bool? IsDeleted { get; set; }

        #region relations

        public virtual List<UserDiscountCode> UserDiscountCodes { get; set; }

        #endregion

    }
}
