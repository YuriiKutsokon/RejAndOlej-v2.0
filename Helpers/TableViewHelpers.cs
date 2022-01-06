using RejAndOlej.DATABASE;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Helpers
{
    class TableViewHelpers
    {
        public static List<T> GetView<T>(object modelList)
        {
            var busMakersList = modelList as ICollection<BusMaker>;
            var busModelsList = modelList as ICollection<Bus>;
            var vehiclesList = modelList as ICollection<BusFleet>;
            var oilChecksList = modelList as ICollection<OilCheck>;
            var regChecksList = modelList as ICollection<RegistrationCheck>;

            if (busMakersList != null)
            {
                List<BusMakersMainTableView> viewList = new List<BusMakersMainTableView>();

                foreach(var model in busMakersList)
                {
                    viewList.Add(new BusMakersMainTableView(model));
                }

                return viewList as List<T>;
            }
            else if (busModelsList != null)
            {
                List<BusModelsMainTableView> viewList = new List<BusModelsMainTableView>();

                foreach (var model in busModelsList)
                {
                    viewList.Add(new BusModelsMainTableView(model));
                }

                return viewList as List<T>;
            }
            else if (vehiclesList != null)
            {
                List<FleetMainTableView> viewList = new List<FleetMainTableView>();

                foreach (var model in vehiclesList)
                {
                    viewList.Add(new FleetMainTableView(model));
                }

                return viewList as List<T>;
            }
            else if (oilChecksList != null)
            {
                List<OilChecksMainTableView> viewList = new List<OilChecksMainTableView>();

                foreach (var model in oilChecksList)
                {
                    viewList.Add(new OilChecksMainTableView(model));
                }

                return viewList as List<T>;
            }
            else if (regChecksList != null)
            {
                List<RegistrationChecksMainTableView> viewList = new List<RegistrationChecksMainTableView>();

                foreach (var model in regChecksList)
                {
                    viewList.Add(new RegistrationChecksMainTableView(model));
                }

                return viewList as List<T>;
            }



            return null;
        }

        public static object GetModelObjectList<T>(T viewList)
        {
            var busMakersView = viewList as ICollection<BusMakersMainTableView>;
            var busModelsView = viewList as ICollection<BusModelsMainTableView>;
            var fleetView = viewList as ICollection<FleetMainTableView>;
            var oilChecksView = viewList as ICollection<OilChecksMainTableView>;
            var regChecksView = viewList as ICollection<RegistrationChecksMainTableView>;

            if (busMakersView != null)
            {
                using(RejAndOlejContext context = new RejAndOlejContext())
                {
                    List<BusMaker> returnList = new List<BusMaker>();

                    foreach (var view in busMakersView)
                    {
                        returnList.Add(context.BusMakers.Where(b => b.BusMakerId == view.ID).FirstOrDefault());
                    }

                    return returnList;
                }
            }
            else if (busModelsView != null)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    List<Bus> returnList = new List<Bus>();

                    foreach (var view in busModelsView)
                    {
                        returnList.Add(context.Buses.Where(b => b.BusId == view.ID).FirstOrDefault());
                    }

                    return returnList;
                }
            }
            else if (fleetView != null)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    List<BusFleet> returnList = new List<BusFleet>();

                    foreach (var view in fleetView)
                    {
                        returnList.Add(context.BusFleets.Where(b => b.FleetVehicleId == view.ID).FirstOrDefault());
                    }

                    return returnList;
                }
            }
            else if (oilChecksView != null)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    List<OilCheck> returnList = new List<OilCheck>();

                    foreach (var view in oilChecksView)
                    {
                        returnList.Add(context.OilChecks.Where(b => b.DateOfOilCheck == view.DataPrzegladu && b.FleetVechicle.RegistrationNumber == view.NumerRejestracyjny).FirstOrDefault());
                    }

                    return returnList;
                }
            }
            else if (regChecksView != null)
            {
                using (RejAndOlejContext context = new RejAndOlejContext())
                {
                    List<RegistrationCheck> returnList = new List<RegistrationCheck>();

                    foreach (var view in regChecksView)
                    {
                        returnList.Add(context.RegistrationChecks.Where(b => b.DateOfRegCheck == view.DataPrzegladu && b.FleetVehicle.RegistrationNumber == view.NumerRejestracyjny).FirstOrDefault());
                    }

                    return returnList;
                }
            }

            return null;
        }
    }
}
