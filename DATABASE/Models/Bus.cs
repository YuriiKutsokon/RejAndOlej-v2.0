using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class Bus
    {
        public Bus()
        {
            BusFleets = new HashSet<BusFleet>();
        }

        public int BusId { get; set; }
        public int? BusMakerId { get; set; }
        public string ModelName { get; set; }
        public int? DefaultDaysToRegistrationReview { get; set; }
        public long? DefaultKmToOilInspection { get; set; }

        private BusMaker _busMaker;
        public virtual BusMaker BusMaker
        {   
            get
            {
                RejAndOlejContext context = new RejAndOlejContext();
                _busMaker = context.BusMakers.Where(bm => bm.BusMakerId == this.BusMakerId).FirstOrDefault();
                return _busMaker;
            }

            set
            {
            }
        }
        public virtual ICollection<BusFleet> BusFleets { get; set; }
    }
}
