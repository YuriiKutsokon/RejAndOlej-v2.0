using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace RejAndOlej.Models
{
    public partial class BusMaker
    {
        public BusMaker()
        {
            Buses = new HashSet<Bus>();
        }

        public int BusMakerId { get; set; }
        public string Name { get; set; }
        public string Nation { get; set; }

        public virtual ICollection<Bus> Buses {
            get
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    return context.Buses.Where(b => b.BusMakerId == BusMakerId).ToList();
                }
            }
            set
            { }
        }
    }
}
