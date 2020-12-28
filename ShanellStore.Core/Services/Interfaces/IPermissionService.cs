using System;
using System.Collections.Generic;
using System.Text;
using ShanellStore.DataLayer.Entities.Permission;
using ShanellStore.DataLayer.Entities.User;


namespace ShanellStore.Core.Services.Interfaces
{
   public interface IPermissionService
    {
        #region permission

        List<Permission> GetAllPermission();
        void AddPermissionsToRole(int roleId, List<int> permission);
        List<int> PermissionsRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permissions);

        bool CheckPermission(int permissionId, string userName);

        #endregion

        #region rolepermission

        List<RolePermission> GetAllRolePermissions();
        RolePermission GetRolePermissionById(int rolePermissionId);
        bool InsertRolePermission(RolePermission rolePermission);
        bool UpdateRolePermission(RolePermission rolePermission);
        bool DeleteRolePermission(RolePermission rolePermission);

        #endregion

        #region role
        List<Role> GetRoles();
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);

        #endregion

        void Save();

    }
}
