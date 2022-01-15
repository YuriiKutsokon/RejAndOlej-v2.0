using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class ConnectionGroupsPermissions
    {
        public int ConnectionId { get; set; }
        public int permissionId { get; set; }
        public int groupId { get; set; }

        private UserPermission _permission;
        public UserPermission Permission
        { 
            get => _permission;

            set
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _permission = context.UserPermissions.Where(p => p.PermissionId == permissionId).FirstOrDefault();
                }
            }
        }

        private UserGroup _userGroup;
        public UserGroup Group
        {
            get => _userGroup;

            set
            { 
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _userGroup = context.UserGroups.Where(g => g.GroupId == groupId).FirstOrDefault();
                }
                
            }
        }


    }
}
