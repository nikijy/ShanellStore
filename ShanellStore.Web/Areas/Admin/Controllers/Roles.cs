using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class Roles : Controller
    {
        private IPermissionService _permissionService;

        public Roles(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public IActionResult Index()
        {
            return View(_permissionService.GetRoles());
        }

        public IActionResult CreateRole()
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(Role role, List<int> SelectedPermission)
        {
            role.IsDeleted = false;
            if (!ModelState.IsValid)
            {
                return View();
            }
            int roleId = _permissionService.AddRole(role);
            _permissionService.AddPermissionsToRole(roleId, SelectedPermission);
            return RedirectToAction("Index");

        }
        public IActionResult EditRole(int id)
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            ViewData["SelectedPermissions"] = _permissionService.PermissionsRole(id);
            return View(_permissionService.GetRoleById(id));
        }
        [HttpPost]
        public IActionResult EditRole(Role role, List<int> SelectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            role.IsDeleted = false;
            _permissionService.UpdateRole(role);
            _permissionService.UpdatePermissionsRole(role.RoleId, SelectedPermission);

            _permissionService.Save();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRole(int id)
        {
            return View(_permissionService.GetRoleById(id));
        }
        [HttpPost]
        public IActionResult DeleteRole(Role role)
        {
            _permissionService.DeleteRole(role);
            _permissionService.Save();
            return RedirectToAction("Index");
        }
    }
}
