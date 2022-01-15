using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.DATABASE.Models
{
    public class User
    {
        public User()
        {

        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? _userGroup { get; set; }
        public string? Position { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        private UserGroup userGroup;
        public UserGroup UserGroup
        {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    userGroup = context.UserGroups.Where(ug => ug.GroupId == _userGroup).FirstOrDefault();
                }
                return userGroup;
            }
        }
    }
}
