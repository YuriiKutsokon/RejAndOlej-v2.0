using Microsoft.EntityFrameworkCore;
using RejAndOlej.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Helpers
{
    class ContextHelpers
    {
        public static void SaveModelObject(object model)
        {
            using (RejAndOlejContext context = new RejAndOlejContext())
            {
                context.Update(model);
                context.SaveChanges();
            }
        }
        
    }
}
