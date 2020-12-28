using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Permission;
using ShanellStore.DataLayer.Entities.User;

namespace ShanellStore.Core.Services
{
   public class PermissionService:IPermissionService
   {
       private ShanellStoreContext _context;

       public PermissionService(ShanellStoreContext context)
       {
           _context = context;
       }
       public List<Permission> GetAllPermission()
       {
           return _context.Permissions.ToList();
       }

       public void AddPermissionsToRole(int roleId, List<int> permission)
       {
           foreach (var p in permission)
           {
               _context.RolePermissions.Add(new RolePermission()
               {
                   PermissionId = p,
                   RoleId = roleId
               });
           }

           _context.SaveChanges();
       }

       public List<int> PermissionsRole(int roleId)
       {
           return _context.RolePermissions
               .Where(r => r.RoleId == roleId)
               .Select(r => r.PermissionId).ToList();
       }

       public void UpdatePermissionsRole(int roleId, List<int> permissions)
       {
           _context.RolePermissions.Where(p => p.RoleId == roleId)
               .ToList().ForEach(p => _context.RolePermissions.Remove(p));

           AddPermissionsToRole(roleId, permissions);
       }

       public bool CheckPermission(int permissionId, string userName)
       {
           int userId = _context.Users.Single(u => u.UserName == userName).UserId;

           List<int> UserRoles = _context.UserRoles
               .Where(r => r.UserId == userId).Select(r => r.RoleId).ToList();

           if (!UserRoles.Any())
               return false;

           List<int> RolesPermission = _context.RolePermissions
               .Where(p => p.PermissionId == permissionId)
               .Select(p => p.RoleId).ToList();

           return RolesPermission.Any(p => UserRoles.Contains(p));


       }
        public List<RolePermission> GetAllRolePermissions()
        {
            return _context.RolePermissions.ToList();
        }

        public RolePermission GetRolePermissionById(int rolePermissionId)
        {
            return _context.RolePermissions.Find(rolePermissionId);
        }

        public bool InsertRolePermission(RolePermission rolePermission)
        {
            try
            {
                _context.RolePermissions.Add(rolePermission);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateRolePermission(RolePermission rolePermission)
        {
            try
            {
                _context.RolePermissions.Update(rolePermission);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRolePermission(RolePermission rolePermission)
        {
            //rolePermission.IsDeleted = true;
            //  UpdateRolePermission(rolePermission);
            try
            {
                _context.Entry(rolePermission).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void DeleteRole(Role role)
        {
            role.IsDeleted = true;
            UpdateRole(role);
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach (int roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });
            }

            _context.SaveChanges();
        }

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //Delete All Roles User
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));

            //Add New Roles
            AddRolesToUser(rolesId, userId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
   }
}
