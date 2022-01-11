using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class UserPermission
    {
        public UserPermission()
        {
            Groups = new List<UserGroup>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }


        public ICollection<UserGroup> Groups { get; set; }
    }
}
