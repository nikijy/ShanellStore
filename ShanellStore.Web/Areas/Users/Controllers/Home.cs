using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShanellStore.Core.DTOs.User;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Entities.Orders;

namespace ShanellStore.Web.Areas.Users.Controllers
{
    [Authorize]
    [Area("Users")]
    public class Home : Controller
    {
        private IUserService _userService;

        public Home(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserByUserName(User.Identity.Name));
        }

        public IActionResult EditUser()
        {
            return View(_userService.GetUserByUserName(User.Identity.Name));
        }

        [Route("Users/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [Route("Users/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            string currentUserName = User.Identity.Name;

            if (!ModelState.IsValid)
                return View(change);

            if (!_userService.CompareOldPassword(change.OldPassword, currentUserName))
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمیباشد");
                return View(change);
            }

            _userService.ChangeUserPassword(currentUserName, change.Password);
            ViewBag.IsSuccess = true;

            return View();
        }


        #region userInfo

        public IActionResult ShowUserInfo()
        {

            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var userInfo = _userService.GetUserInformationForOrder(userId);
            if (userInfo != null)
            {
                return View(userInfo);
            }
            return View("CreateUserInfo");
        }

        public IActionResult CreateUserInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUserInfo(UserOrder userInfo)
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            userInfo.UserId = userId;
            if (ModelState.IsValid)
            {
                _userService.CreateUserInfo(userInfo);
                _userService.Save();
                return RedirectToAction("ShowUserInfo");
            }

            return View(userInfo);
        }

        public IActionResult EditInformation(int? id)
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            return View(_userService.GetUserInformationForOrder(userId));
        }

        [HttpPost]
        public IActionResult EditInformation(UserOrder userInfo)
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            userInfo.UserId = userId;
            if (!ModelState.IsValid)
            {
                return View();
            }
           
            _userService.EditUserInfo(userInfo);
            return RedirectToAction("ShowUserInfo");
        }

        #endregion
    }
}
