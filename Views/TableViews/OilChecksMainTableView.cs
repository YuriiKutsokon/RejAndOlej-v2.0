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
        //public string StanPojazdu { get; set; }

        public OilChecksMainTableView()
        {

        }

        public OilChecksMainTableView(OilCheck oilCheck)
        {
            NumerRejestracyjny = oilCheck.FleetVechicle.RegistrationNumber;
            DataPrzegladu = oilCheck.DateOfOilCheck;
            PrzebiegNaMomentPrzegladu = oilCheck.MileageOnOilCheck.ToString();
        }

        public static ICollection<OilChecksMainTableView>GetOilChecksView(ICollection<OilCheck> checks)
        {
            ICollection<OilChecksMainTableView> CheckList = new List<OilChecksMainTableView>();
            foreach(OilCheck check in checks)
            {
                CheckList.Add(new OilChecksMainTableView(check));
            }
            return CheckList;
        }
    }
}
