using System;
using System.Collections.Generic;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class RegistrationCheck
    {
        public int RegCheckId { get; set; }
        public int FleetVehicleId { get; set; }
        public DateTime? DateOfRegCheck { get; set; }
        public long? MileageOnRegCheck { get; set; }

        public virtual BusFleet FleetVehicle { get; set; }
    }
}
