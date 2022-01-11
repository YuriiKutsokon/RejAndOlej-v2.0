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

    }
}
