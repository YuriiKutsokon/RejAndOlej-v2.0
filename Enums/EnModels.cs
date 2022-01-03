using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Enums
{
    public class EnModels
    {
        public enum Models
        {
            BusMakers = 1,
            BusModels = 2,
            BusFleet = 3,
            OilChecks = 4,
            RegistrationChecks = 5
        }

        public enum ModelActions
        {
            Edit,
            Insert,
            Delete
        }
    }
}
