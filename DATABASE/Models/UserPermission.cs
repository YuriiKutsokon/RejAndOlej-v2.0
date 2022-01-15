using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class UserPermission
    {
        public UserPermission()
        {
            Connections = new List<ConnectionGroupsPermissions>();
        }


        public int PermissionId { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }

        private bool _isActive;
        [NotMapped]
        public bool IsActive { get => _isActive; set => _isActive = value; }


        public ICollection<ConnectionGroupsPermissions> Connections { get; set; }
    }
}
