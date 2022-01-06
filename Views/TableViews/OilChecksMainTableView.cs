using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class OilChecksMainTableView
    {
        public string NumerRejestracyjny { get; set; }
        public DateTime? DataPrzegladu { get; set; }
        public string PrzebiegNaMomentPrzegladu { get; set; }

        public OilChecksMainTableView()
        {

        }

        public OilChecksMainTableView(object model)
        {
            OilCheck oilCheck = model as OilCheck;

            NumerRejestracyjny = oilCheck.FleetVechicle.RegistrationNumber;
            DataPrzegladu = oilCheck.DateOfOilCheck;
            PrzebiegNaMomentPrzegladu = oilCheck.MileageOnOilCheck.ToString();
        }

    }
}
