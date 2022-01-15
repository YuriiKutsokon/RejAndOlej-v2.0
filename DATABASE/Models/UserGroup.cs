using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class UserGroup
    {
        public UserGroup()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }
        public string Name { get; set; }

        private ICollection<ConnectionGroupsPermissions> _connections;
        public ICollection<ConnectionGroupsPermissions> Connections
        {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _connections = context.ConnectionsGroupsPermissions.Where(c => c.groupId == GroupId).ToList();
                }
                return _connections;
            }
        }

        [NotMapped]
        public ICollection<UserPermission> Permissions
        {
            get
            {
                var permissions = new List<UserPermission>();

                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    permissions = context.UserPermissions.ToList();
                    foreach (var perm in permissions)
                    {
                        foreach (var con in Connections)
                        {
                            if (perm.PermissionId == con.permissionId)
                                perm.IsActive = true;
                        }
                    }
                }

                return permissions;
            }
        }
    }
}
