using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class BusFleet
    {
        public BusFleet()
        {
            OilChecks = new HashSet<OilCheck>();
            RegistrationChecks = new HashSet<RegistrationCheck>();
        }

        public int FleetVehicleId { get; set; }
        public int? BusId { get; set; }
        public long? Mileage { get; set; }
        public string RegistrationNumber { get; set; }
        public string RaceNumber { get; set; }
        public DateTime? DateOfEnterToFleet { get; set; }

        private Bus _bus;
        public virtual Bus Bus
        {   get 
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _bus = context.Buses.Where(b => b.BusId == this.BusId).FirstOrDefault();
                }
                return _bus;
            }
            set { }
        }
        public virtual ICollection<OilCheck> OilChecks { get; set; }
        public virtual ICollection<RegistrationCheck> RegistrationChecks { get; set; }
    }
}
