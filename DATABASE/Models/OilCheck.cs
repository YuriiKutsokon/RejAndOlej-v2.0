using System;
using System.Linq;
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

        private BusFleet _FleetVechicle;
        public virtual BusFleet FleetVechicle
        {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _FleetVechicle = context.BusFleets.Where(bf => bf.FleetVehicleId == this.FleetVechicleId).FirstOrDefault();
                }
                return _FleetVechicle;
            }
        }
    }
}
