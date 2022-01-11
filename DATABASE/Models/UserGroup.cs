using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class UserGroup
    {
        public UserGroup()
        {
            Permissions = new List<UserPermission>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }

        public ICollection<UserPermission> Permissions { get; set; }
    }
}
