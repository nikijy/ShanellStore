using System;
using System.Collections.Generic;
using System.Text;
using ShanellStore.Core.DTOs.User;
using ShanellStore.DataLayer.Entities.Orders;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.Core.Services.Interfaces
{
   public interface IOrderService
    {
        #region userOrders

        List<ShowOrderViewModel> GetUserBasket(int userId, string userName);
        List<ShowOrderViewModel> GetPaidOrders(string userName);
        bool InsertOrdersToBasket(UserBasket userBasket);
        int AddOrder(string userName, int productId);
        int GetOrderId(int userId);
        Order GetUserOrderById(int orderId);
        Order GetUserOrderForPayment();
        void UpdateSumOrder(int orderId);
        OrderDetail GetOrderDetail(int orderDetailId);
        Order GetOrderById(int orderId);
        void DeleteOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void UpdateOrder(Order order);

        Product GetProductIdByOrderDetailId(int orderId);
       
        void Save();
     
       
        #endregion

    }
}
