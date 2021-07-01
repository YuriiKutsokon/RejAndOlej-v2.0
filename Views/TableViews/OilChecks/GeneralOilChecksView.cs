using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews.OilChecks
{
    class GeneralOilChecksView
    {
        public string BusModel { get; set; }

        public string RegistrationNumber { get; set; }

        public string Mileage { get; set; }

        public string DateOfOilCheck { get; set; }

        public GeneralOilChecksView()
        {

        }

        public GeneralOilChecksView(OilCheck check)
        {
            BusModel = check.FleetVechicle.Bus.ModelName;
            RegistrationNumber = check.FleetVechicle.RegistrationNumber;
            Mileage = Convert.ToString(check.MileageOnOilCheck);
            DateOfOilCheck = Convert.ToString(check.DateOfOilCheck);
        }

        public static ICollection<GeneralOilChecksView>GetGeneralOilChecksList(ICollection<OilCheck> checkList)
        {
            ICollection<GeneralOilChecksView> viewList = new List<GeneralOilChecksView>();

            foreach (OilCheck check in checkList)
            {
                viewList.Add(new GeneralOilChecksView(check));
            }

            return viewList;
        }


    }
}
