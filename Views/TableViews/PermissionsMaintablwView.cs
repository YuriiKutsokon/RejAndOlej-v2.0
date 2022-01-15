using RejAndOlej.DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    public class PermissionsMaintablwView
    {
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public PermissionsMaintablwView(UserPermission permission)
        {
            IsActive = permission.IsActive;
            Name = permission.Name;
            Text = permission.Text;
        }
    }
}
