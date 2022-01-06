using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Enums
{
    public class EnChecks
    {
        public enum CheckTypes
        {
            Oil = 1,
            Registration = 2
        }

        public enum CheckStatuses
        {
            HasNoCheck = 0,
            Nearby = 1, 
            Valid = 2,
            NotValid = 3
        }
    }


}
