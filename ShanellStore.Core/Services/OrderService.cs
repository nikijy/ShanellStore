using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShanellStore.Core.DTOs.User;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Orders;
using ShanellStore.DataLayer.Entities.Product;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.Core.Services
{
    public class OrderService : IOrderService
    {
        private ShanellStoreContext _context;
        private IUserService _userService;
        private IProductService _productService;

        public OrderService(ShanellStoreContext context, IUserService userService, IProductService productService)
        {
            _context = context;
            _userService = userService;
            _productService = productService;
        }

        public List<ShowOrderViewModel> GetUserBasket(int userId, string userName)
        {
            int userIdForOrder = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders.SingleOrDefault(o => o.UserId == userIdForOrder && !o.IsFinally);

            List<ShowOrderViewModel> _list = new List<ShowOrderViewModel>();
            if (order != null)
            {
                var details = _context.OrderDetails
                    .Include(c => c.ProductColor)
                    .Include(s => s.ProductSize)
                    .Include(b => b.ProductBrand)
                    .Where(d => d.OrderId == order.OrderId).ToList();
                foreach (var item in details)
                {
                    var product = _context.Products.Find(item.ProductId);
                    if (item.DiscountedPrice != null)
                    {
                        _list.Add(new ShowOrderViewModel()
                        {
                            OrderId = item.OrderId,
                            Count = item.Count,
                            OrderDetailId = item.OrderDetailId,
                            Price = item.Price,
                            Sum = item.Count * item.DiscountedPrice.Value,
                            DiscountedPrice = item.DiscountedPrice.Value,
                            Name = product.Name,
                            IsFinally = order.IsFinally,
                            Color = item.ProductColor.Color,
                            Size = item.ProductSize.Size,
                            Brand = item.ProductBrand.BrandName,
                            CreateDate = order.CreateDate,
                            IsAvailable = product.IsAvailable
                        });
                    }
                    else
                    {
                        _list.Add(new ShowOrderViewModel()
                        {
                            OrderId = item.OrderId,
                            Count = item.Count,
                            OrderDetailId = item.OrderDetailId,
                            Price = item.Price,
                            Sum = item.Count * item.Price,
                            DiscountedPrice = 0,
                            Name = product.Name,
                            IsFinally = order.IsFinally,
                            Color = item.ProductColor.Color,
                            Size = item.ProductSize.Size,
                            Brand = item.ProductBrand.BrandName,
                            CreateDate = order.CreateDate,
                            IsAvailable = product.IsAvailable
                        });
                    }
                }
            }

            return _list.ToList();
        }

        public List<ShowOrderViewModel> GetPaidOrders(string userName)
        {
            var userId = _userService.GetUserIdByUserName(userName);
            var details = _context.OrderDetails
                  .Include(c => c.ProductColor)
                  .Include(s => s.ProductSize)
                  .Include(b => b.ProductBrand)
                  .Where(d => d.Order.IsFinally == true && d.Order.UserId == userId)
                  .Select(d => new ShowOrderViewModel()
                  {
                      DiscountedPrice = d.DiscountedPrice.Value,
                      Price = d.Price,
                      Name = d.Product.Name,
                      Count = d.Count,
                      Color = d.ProductColor.Color,
                      IsFinally = d.Order.IsFinally,
                      Size = d.ProductSize.Size,
                      Brand = d.ProductBrand.BrandName,
                      CreateDate = d.Order.CreateDate,
                      Sum = d.Order.Sum
                  }).ToList();

            return details.ToList();

        }


        public bool InsertOrdersToBasket(UserBasket userBasket)
        {
            try
            {
                _context.UserBaskets.Add(userBasket);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int AddOrder(string userName, int productId)
        {
          
            int userId = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders.SingleOrDefault(o => o.UserId == userId && !o.IsFinally);
            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    CreateDate = DateTime.Now,
                    IsFinally = false,
                    Sum = 0,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                            {
                               // OrderId = order.OrderId,
                                Count = 1,
                                Price = _context.Products.Find(productId).Price,
                                DiscountedPrice = _context.Products.Find(productId).DiscountedPrice,
                                ProductId = productId,
                                ProductBrandId = _context.Products.Find(productId).ProductBrandId,
                                ProductColorId = _context.Products.Find(productId).ProductColorId,
                                ProductSizeId = _context.Products.Find(productId).ProductSizeId,
                            }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                var details = _context.OrderDetails.SingleOrDefault(d => d.OrderId == order.OrderId && d.ProductId == productId);
                if (details == null)
                {
                    _context.OrderDetails.Add(new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        Price = _context.Products.Find(productId).Price,
                        DiscountedPrice = _context.Products.Find(productId).DiscountedPrice,
                        ProductId = productId,
                        ProductBrandId = _context.Products.Find(productId).ProductBrandId,
                        ProductColorId = _context.Products.Find(productId).ProductColorId,
                        ProductSizeId = _context.Products.Find(productId).ProductSizeId,
                    });
                }
                else
                {
                    details.Count += 1;
                    _context.Update(details);
                }

                _context.SaveChanges();
            }
            UpdateSumOrder(order.OrderId);
            return order.OrderId;
        }

        public int GetOrderId(int userId)
        {
            return _context.Orders.SingleOrDefault(o => o.UserId == userId && !o.IsFinally).OrderId;
        }

        public Order GetUserOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public Order GetUserOrderForPayment()
        {
            return _context.Orders.SingleOrDefault(o => !o.IsFinally);
        }

        public void UpdateSumOrder(int orderId)
        {
            
            var order = GetOrderById(orderId);
            var OrderDetail = _context.OrderDetails.Where(o => o.OrderId == order.OrderId);
            var resDetail = 0;
            var res = 0;

            foreach (var orderDetail in OrderDetail)
            {
                if (orderDetail.DiscountedPrice != null)
                {
                    resDetail = _context.OrderDetails.Where(o => o.OrderId == order.OrderId).Select(d => d.Count * d.DiscountedPrice.Value).Sum();
                }
                else
                {
                    res = _context.OrderDetails.Where(o => o.OrderId == order.OrderId && o.DiscountedPrice == null || o.DiscountedPrice.Value == 0).Select(d => d.Count * d.Price).Sum();
                }
            }

            order.Sum = res + resDetail;
            _context.Update(order);
            Save();

        }



        public OrderDetail GetOrderDetail(int orderDetailId)
        {
            return _context.OrderDetails.Find(orderDetailId);
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Remove(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
        }

        public Product GetProductIdByOrderDetailId(int orderId)
        {
            var orders = _context.OrderDetails.Find(orderId);
            return _context.Products.SingleOrDefault(p => p.ProductId == orders.ProductId);
        }


        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}
