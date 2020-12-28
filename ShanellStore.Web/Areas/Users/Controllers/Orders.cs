using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ShanellStore.Core.DTOs.User;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Orders;
using ShanellStore.DataLayer.Entities.Product;
using ZarinpalSandbox;


namespace ShanellStore.Web.Areas.Users.Controllers
{
    [Authorize]
    [Area("Users")]
    public class Orders : Controller
    {

        private IOrderService _orderService;
        private IUserService _userService;
        private IProductService _productService;

        public Orders(IOrderService orderService, IUserService userService, IProductService productService)
        {
            _orderService = orderService;
            _userService = userService;
            _productService = productService;
        }
        public IActionResult ShowOrders()
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var basket = _orderService.GetUserBasket(userId, User.Identity.Name);

            return View(basket);
        }

        public IActionResult ShowPaidOrders()
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            return View(_orderService.GetPaidOrders(User.Identity.Name));
        }
        public IActionResult AddOrdersToBasket(int id)
        {
            var product = _productService.GetProductById(id);
            product.AvailableCount -= 1;
            if (product.AvailableCount == 0)
            {
                product.IsAvailable = false;
            }
            _productService.UpdateProduct(product);

             _orderService.AddOrder(User.Identity.Name, id);
          
            return RedirectToAction("ShowOrders", "Orders");
        }


        public IActionResult Delete(int id)
        {
            var orderDetail = _orderService.GetOrderDetail(id);

            var product = _orderService.GetProductIdByOrderDetailId(id);
            product.AvailableCount += orderDetail.Count;
            _productService.UpdateProduct(product);
            _orderService.DeleteOrderDetail(orderDetail);
            _orderService.Save();
            return RedirectToAction("ShowOrders");
        }
        public IActionResult Payment()
        {
            // var order = _ctx.Orders.SingleOrDefault(o => !o.IsFinaly);
            var order = _orderService.GetUserOrderForPayment();
            if (order == null)
            {
                return NotFound();
            }

            //order.SumPrice = sumPrice;
            //_orderService.UpdateUserBasket(order);
            //_orderService.Save();
            var payment = new Payment(order.Sum);
            var res = payment.PaymentRequest($"پرداخت فاکتور شماره {order.OrderId}",
                "https://localhost:44314/Home/OnlinePayment/" + order.OrderId, "nikitmb2@gmail.com", "09356821874");
            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            else
            {
                return BadRequest();
            }

            //  return null;
        }
        public IActionResult Command(int id, string command)
        {
            var product = _orderService.GetProductIdByOrderDetailId(id);

            var orderDetail = _orderService.GetOrderDetail(id);
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var orderId = _orderService.GetOrderId(userId);
            switch (command)
            {
                case "up":
                    {
                        orderDetail.Count += 1;
                        _orderService.UpdateOrderDetail(orderDetail);
                        product.AvailableCount -= 1;
                        if (product.AvailableCount == 0)
                        {
                            product.IsAvailable = false;
                        }

                        break;
                    }
                case "down":
                    {
                        orderDetail.Count -= 1;
                        product.AvailableCount += 1;
                        product.IsAvailable = true;
                        if (orderDetail.Count == 0)
                        {
                            _orderService.DeleteOrderDetail(orderDetail);

                        }
                        else
                        {
                            _orderService.UpdateOrderDetail(orderDetail);

                        }

                        break;
                    }
            }

            _productService.UpdateProduct(product);
            _orderService.Save();
            _orderService.UpdateSumOrder(orderId);
            return RedirectToAction("ShowOrders");
        }


    }
}
