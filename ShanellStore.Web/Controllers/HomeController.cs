using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ShanellStore.Core.Convertors;
using ShanellStore.Core.DTOs.User;
using ShanellStore.Core.Security;
using ShanellStore.Core.Senders;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Entities.User;
using TopLearn.Core.Generator;
using ZarinpalSandbox;


namespace ShanellStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        private IUserService _userService;
        private IOrderService _orderService;
        private IViewRenderService _viewRender;

        public HomeController(IProductService productService, IUserService userService, IOrderService orderService, IViewRenderService viewRender)
        {
            _productService = productService;
            _userService = userService;
            _orderService = orderService;
            _viewRender = viewRender;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Contact")]
        [HttpPost]
        public IActionResult Contact([Bind("UM_Id,Name,Email,Website,Text,CreateDate,IsDeleted")] UserMessage userMessage)
        {
           
            userMessage.CreateDate = DateTime.Now;
            userMessage.IsDeleted = false;
            if (ModelState.IsValid)
            {
                _userService.InsertUserMessage(userMessage);
                _productService.Save();
                ViewBag.success = "پیام شما با موفقیت ارسال شد";

                return View("Contact");
            }
            return View();
        }
        [Route("Services")]
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Search(string q)
        {
            if (q == "")
            {
                ViewBag.message = "موردی یافت نشد";
            }
            return View(_productService.SearchProducts(q));

        }
        [HttpPost]
        public IActionResult AddEmailForNewsLetter(NewsLetter news)
        {
           
            if (ModelState.IsValid)
            {
                if (_userService.IsExistEmailForNewsLetter(news.Email))
                {
                    TempData["error"] = "این ایمیل قبلا ثبت شده است";
                    return View("Index");
                }

                news.Active = true;
                _userService.AddEmail(news);
                _userService.Save();
                TempData["message"] = "ایمیل شما با موفقیت ثبت شد";
            }
            return RedirectToAction("Index");
        }

       
        public IActionResult OnlinePayment(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var order = _orderService.GetUserOrderById(id);
                var payment = new Payment(order.Sum);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    order.IsFinally = true;
                    _orderService.UpdateOrder(order);
                    _orderService.Save();
                    ViewBag.code = res.RefId;
                    return View();
                }

            }

            return NotFound();
        }
    }
}
