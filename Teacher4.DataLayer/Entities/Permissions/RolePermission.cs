using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Teacher4.DataLayer.Entities.User;

namespace Teacher4.DataLayer.Entities.Permissions
{
    public class RolePermission
    {
        [Key]
        public int RP_Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        #region Relations
        public Role Role { get; set; }
        public Permission Permission { get; set; }
        #endregion


    }
}
