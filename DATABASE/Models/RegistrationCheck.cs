using System;
using System.Linq;
using System.Collections.Generic;
using RejAndOlej.DATABASE;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class RegistrationCheck
    {
        public int RegCheckId { get; set; }
        public int FleetVehicleId { get; set; }
        public DateTime? DateOfRegCheck { get; set; }
        public long? MileageOnRegCheck { get; set; }

        private BusFleet _FleetVehicle;
        public virtual BusFleet FleetVehicle
        {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _FleetVehicle = context.BusFleets.Where(bf => bf.FleetVehicleId == FleetVehicleId).FirstOrDefault();
                }
                return _FleetVehicle;
            }
        }
    }
}
