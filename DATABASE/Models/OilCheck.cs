using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class OilCheck
    {
        public int OilCheckId { get; set; }
        public int FleetVechicleId { get; set; }
        public long? MileageOnOilCheck { get; set; }
        public DateTime? DateOfOilCheck { get; set; }

        private BusFleet _vehicle; 

        public virtual BusFleet FleetVechicle {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _vehicle = context.BusFleets.Where(v => v.FleetVehicleId == FleetVechicleId).FirstOrDefault();
                }
                return _vehicle; 
            }
            set { }
        }
    }
}

