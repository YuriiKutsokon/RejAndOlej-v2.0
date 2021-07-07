using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class FleetMainTableView
    {
        public int ID { get; set; }
        public string RegistrationNumber { get; set; }
        public string RaceNumber { get; set; }
        public long? Mileage { get; set; }
        public DateTime? DateOfEnterToFleet { get; set; }
        public string BusModel { get; set; }
        public DateTime? LastOilCheckDate { get; set; }
        public long? MileageOnOilCheck { get; set; }

        public FleetMainTableView()
        {

        }

        public FleetMainTableView(BusFleet fleet)
        {
            ID = fleet.FleetVehicleId;
            RegistrationNumber = fleet.RegistrationNumber;
            RaceNumber = fleet.RaceNumber;
            Mileage = fleet.Mileage;
            DateOfEnterToFleet = fleet.DateOfEnterToFleet;
            BusModel = fleet.Bus.BusMaker.Name + " " + fleet.Bus.ModelName;
            LastOilCheckDate = fleet.OilChecks.Last().DateOfOilCheck;
            MileageOnOilCheck = fleet.OilChecks.Last().MileageOnOilCheck;
        }

        public static ICollection<FleetMainTableView> GetFleetView(ICollection<BusFleet> fleet)
        {
            ICollection<FleetMainTableView> fleetList = new List<FleetMainTableView>();
            foreach (BusFleet vehicle in fleet)
            {
                fleetList.Add(new FleetMainTableView(vehicle));
            }

            return fleetList;
        }
    }

}
