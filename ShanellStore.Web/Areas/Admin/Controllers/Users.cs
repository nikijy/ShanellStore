using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ShanellStore.Core.DTOs.User;
using ShanellStore.Core.Security;
using ShanellStore.Core.Senders;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Entities.User;
using TopLearn.Core.Generator;

namespace ShanellStore.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class Users : Controller
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public Users(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
       // [PermissionChecker(1)]
        public IActionResult Index(int pageId = 1)
        {
            int Count = _userService.UserCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;
            return View(_userService.GetAllUsers(12, pageId));
        }

        public IActionResult CreateUser()
        {
            ViewData["Roles"] = _permissionService.GetRoles();
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User user, List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int userId = _userService.AddUserForAdmin(user);

            //Add Roles
            _permissionService.AddRolesToUser(SelectedRoles, userId);


            return RedirectToAction("Index");
        }

       
        public IActionResult EditUser(int id)
        {
            ViewData["Roles"] = _permissionService.GetRoles();
            return View(_userService.GetUserByIdForEditInAdmin(id));
        }

        [HttpPost]
        public IActionResult EditUser(EditUserViewModel editUser, List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _userService.EditUserFromAdmin(editUser);

            //Edit Roles
            _permissionService.EditRolesUser(editUser.UserId, SelectedRoles);
            return RedirectToAction("Index");
        }

       
        public IActionResult DeleteUser(int id)
        {
            ViewData["UserId"] = id;
            return View(_userService.GetUserInformation(id));
        }
        [HttpPost]
        public IActionResult FinalDelete(int userId)
        {
            _userService.DeleteUser(userId);
            return RedirectToAction("Index");
        }

        public IActionResult GetDeletedUsers(int pageId = 1)
        {
            int Count = _userService.UserCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;
            return View(_userService.GetDeleteUsers(pageId));
        }

        #region usermessages

        public IActionResult UserMessages(int pageId = 1)
        {
            int Count = _userService.UserMessageCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 10;
            return View(_userService.GetAllUserMessages(10,pageId));
        }

        public IActionResult UserMessagesDetails(int id)
        {
            return View(_userService.GetUserMessageById(id));
        }

        [Route("DeleteUserMessage/{id}")]
        public IActionResult DeleteUserMessage(int id)
        {
            return View(_userService.GetUserMessageById(id));
        }
        [HttpPost]
        public IActionResult DeleteUserMessageFinal(int UM_Id)
        {
            _userService.DeleteUserMessage(UM_Id);
            _userService.Save();
            return RedirectToAction("UserMessages");
        }

        #endregion

        public IActionResult NewsLetter()
        {
            return View();
        }
        public IActionResult SendEmailForNewsLetter(string bodyText)
        {
            var newsLetters = _userService.GetAllEmails();
            string emails = null;
            foreach (var item in newsLetters)
            {
                emails = item.Email;
                //  string body = _viewRender.RenderToStringAsync("_NewsLetterEmail", newsLetters);
                string body = bodyText;
                SendEmail.Send(emails, "خبرنامه", body);
            }

            TempData["success"] = "با موفقیت ارسال شد";
            return View("NewsLetter");

        }

    }
}
