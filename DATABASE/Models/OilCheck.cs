using System;
using System.Collections.Generic;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class OilCheck
    {
        public int OilCheckId { get; set; }
        public int FleetVechicleId { get; set; }
        public long? MileageOnOilCheck { get; set; }
        public DateTime? DateOfOilCheck { get; set; }

        public virtual BusFleet FleetVechicle { get; set; }
    }
}
