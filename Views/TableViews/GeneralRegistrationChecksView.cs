using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class GeneralRegistrationChecksView
    {
        public string BusModel { get; set; }

        public string RegistrationNumber { get; set; }

        public string Mileage { get; set; }

        public string DateOfRegistrationCheck { get; set; }

        public GeneralRegistrationChecksView()
        {

        }

        public GeneralRegistrationChecksView(RegistrationCheck check)
        {
            BusModel = check.FleetVehicle.Bus.ModelName;
            RegistrationNumber = check.FleetVehicle.RegistrationNumber;
            Mileage = Convert.ToString(check.MileageOnRegCheck);
            DateOfRegistrationCheck = Convert.ToString(check.DateOfRegCheck);
        }

        public static ICollection<GeneralRegistrationChecksView> GetGeneralRegistrationChecksList(ICollection<RegistrationCheck> checkList)
        {
            ICollection<GeneralRegistrationChecksView> viewList = new List<GeneralRegistrationChecksView>();

            foreach (RegistrationCheck check in checkList)
            {
                viewList.Add(new GeneralRegistrationChecksView(check));
            }

            return viewList;
        }
    }
}
