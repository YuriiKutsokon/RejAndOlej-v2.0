using RejAndOlej.DATABASE;
using RejAndOlej.Enums;
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
        public EnChecks.CheckStatuses? OilCheckStatus { get; set; }
        public EnChecks.CheckStatuses? RegCheckStatus { get; set; }

        private Bus _bus;
        private ICollection<OilCheck> _oilChecks;
        private ICollection<RegistrationCheck> _registrationChecks;

        public virtual Bus Bus {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _bus = context.Buses.Where(b => b.BusId == this.BusId).FirstOrDefault();
                }
                return _bus;
            }
            set { }
        }

        public virtual ICollection<OilCheck> OilChecks {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _oilChecks = context.OilChecks.Where(c => c.FleetVechicle.RegistrationNumber == this.RegistrationNumber).ToList();
                }
                return _oilChecks;
            }
            set { }
        }

        public virtual ICollection<RegistrationCheck> RegistrationChecks {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    _registrationChecks = context.RegistrationChecks.Where(c => c.FleetVehicle.RegistrationNumber == this.RegistrationNumber).ToList();
                }
                return _registrationChecks;
            }
            set { }
        }
    }
}
