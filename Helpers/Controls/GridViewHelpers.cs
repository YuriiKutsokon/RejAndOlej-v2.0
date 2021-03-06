using RejAndOlej.DATABASE;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Helpers.Controls
{
    enum ModelTypes
    {
        RejAndOlejModelsBus,
        RejAndOlejModelsBusMaker,
        RejAndOlejModelsBusFleet,
        RejAndOlejModelsOilCheck,
        RejAndOlejModelsRegistrationCheck,
        RejAndOlejDATABASEModelsUser,
        RejAndOlejDATABASEModelsUserGroup,
        RejAndOlejDATABASEModelsUserPermission,
        RejAndOlejDATABASEModelsConnectionGroupsPermissions
    }

    class GridViewHelpers
    {
        public static T GetObjectFromDataGridViewRow<T>(DataGridView sender, string searchingColumnName)
        {
            string type = typeof(T).ToString().Replace(".", string.Empty);
            var returnObj = default(object);
            using (RejAndOlejContext context = new RejAndOlejContext())
            {
                switch (type)
                {
                    case nameof(ModelTypes.RejAndOlejModelsBusMaker):
                        returnObj = new BusMaker();
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.BusMakers.Where(b => b.Name ==
                                Convert.ToString(sender.SelectedRows[0].Cells[nameof(BusMakersMainTableView.BusMakerName)].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.BusMakers.Where(b => b.Name ==
                                Convert.ToString(sender.SelectedCells[0].OwningRow.Cells[nameof(BusMakersMainTableView.BusMakerName)].Value)).FirstOrDefault();
                        }
                        break;

                    case nameof(ModelTypes.RejAndOlejModelsBus):
                        returnObj = new Bus();
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.Buses.Where(b => b.ModelName ==
                                Convert.ToString(sender.SelectedRows[0].Cells[searchingColumnName].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.Buses.Where(b => b.ModelName ==
                                Convert.ToString(sender.SelectedCells[0].OwningRow.Cells[searchingColumnName].Value)).FirstOrDefault();
                        }
                    break;

                    case nameof(ModelTypes.RejAndOlejModelsBusFleet):
                        returnObj = new BusFleet();
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.BusFleets
                                .Where(v => v.RegistrationNumber ==
                                Convert.ToString(sender.SelectedRows[0].Cells[searchingColumnName].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.BusFleets
                                .Where(v => v.RegistrationNumber ==
                                Convert.ToString(sender.SelectedCells[0].OwningRow.Cells[searchingColumnName].Value)).FirstOrDefault();
                        }
                    break;

                    case nameof(ModelTypes.RejAndOlejModelsOilCheck):
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.OilChecks
                                .Where(v => v.FleetVechicle.RegistrationNumber ==
                                Convert.ToString(sender.SelectedRows[0].Cells[nameof(OilChecksMainTableView.NumerRejestracyjny)].Value) &&
                                v.MileageOnOilCheck == Convert.ToInt64(sender.SelectedRows[0].Cells[nameof(OilChecksMainTableView.PrzebiegNaMomentPrzegladu)].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.OilChecks
                                .Where(v => v.FleetVechicle.RegistrationNumber ==
                                Convert.ToString(sender.SelectedCells[0].OwningRow.Cells[nameof(OilChecksMainTableView.NumerRejestracyjny)].Value) &&
                                v.MileageOnOilCheck == Convert.ToInt64(sender.SelectedCells[0].OwningRow.Cells[nameof(OilChecksMainTableView.PrzebiegNaMomentPrzegladu)].Value)).FirstOrDefault();
                        }
                        break;

                    case nameof(ModelTypes.RejAndOlejModelsRegistrationCheck):
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.RegistrationChecks
                                .Where(v => v.FleetVehicle.RegistrationNumber ==
                                Convert.ToString(sender.SelectedRows[0].Cells[nameof(RegistrationChecksMainTableView.NumerRejestracyjny)].Value) &&
                                v.MileageOnRegCheck == Convert.ToInt64(sender.SelectedRows[0].Cells[nameof(RegistrationChecksMainTableView.PrzebiegNaMomentPrzegladu)].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.RegistrationChecks
                                .Where(v => v.FleetVehicle.RegistrationNumber ==
                                Convert.ToString(sender.SelectedCells[0].OwningRow.Cells[nameof(RegistrationChecksMainTableView.NumerRejestracyjny)].Value) &&
                                v.MileageOnRegCheck == Convert.ToInt64(sender.SelectedCells[0].OwningRow.Cells[nameof(RegistrationChecksMainTableView.PrzebiegNaMomentPrzegladu)].Value)).FirstOrDefault();
                        }
                        break;

                    case nameof(ModelTypes.RejAndOlejDATABASEModelsUser):
                        if (sender.SelectedRows != null && sender.SelectedRows.Count != 0)
                        {
                            returnObj = context.Users.Where(e => e.UserId == Convert.ToInt32(sender.SelectedRows[0].Cells[nameof(UsersMainTableView.ID)].Value)).FirstOrDefault();
                        }
                        else if (sender.SelectedCells != null && sender.SelectedCells.Count != 0)
                        {
                            returnObj = context.Users.Where(e => e.UserId == Convert.ToInt32(sender.SelectedRows[0].Cells[nameof(UsersMainTableView.ID)].Value)).FirstOrDefault();
                        }
                        break;
                }

            }

            return (T)returnObj;
        }
    }
}


