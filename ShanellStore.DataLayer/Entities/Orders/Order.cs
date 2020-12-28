using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShanellStore.DataLayer.Entities.Orders
{
   public class Order
    {
        public Order()
        {
            
        }
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public int Sum { get; set; }

        public bool IsFinally { get; set; }



        public List<OrderDetail> OrderDetails { get; set; }
    }
}
