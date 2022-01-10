using RejAndOlej.DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    public class UsersMainTableView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }

        public UsersMainTableView(User user)
        {
            ID = user.UserId;
            Name = user.Name;
            Surname = user.Surname;
            Position = user.Position;
        }
    }
}
