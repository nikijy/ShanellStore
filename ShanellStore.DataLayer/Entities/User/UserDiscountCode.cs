using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShanellStore.DataLayer.Entities.Orders;

namespace ShanellStore.DataLayer.Entities.User
{
   public class UserDiscountCode
    {
        public UserDiscountCode()
        {
            
        }
        [Key]
        public int UDCode_Id { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }

        #region relations

        public virtual User User { get; set; }
        public virtual Discount Discount { get; set; }

        #endregion

    }

}
