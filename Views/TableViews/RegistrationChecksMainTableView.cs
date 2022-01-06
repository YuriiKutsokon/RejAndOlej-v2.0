using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class RegistrationChecksMainTableView
    {
        public string NumerRejestracyjny { get; set; }
        public DateTime? DataPrzegladu { get; set; }
        public string PrzebiegNaMomentPrzegladu { get; set; }

        public RegistrationChecksMainTableView()
        {

        }

        public RegistrationChecksMainTableView(object model)
        {
            RegistrationCheck regCheck = model as RegistrationCheck;

            NumerRejestracyjny = regCheck.FleetVehicle.RegistrationNumber;
            DataPrzegladu = regCheck.DateOfRegCheck;
            PrzebiegNaMomentPrzegladu = regCheck.MileageOnRegCheck.ToString();
        }

        public static ICollection<RegistrationChecksMainTableView> GetRegistrationChecksListView(ICollection<RegistrationCheck> checks)
        {
            ICollection<RegistrationChecksMainTableView> listView = new List<RegistrationChecksMainTableView>();
            foreach (RegistrationCheck check in checks)
            {
                listView.Add(new RegistrationChecksMainTableView(check));
            }
            return listView;
        }
    }
}
