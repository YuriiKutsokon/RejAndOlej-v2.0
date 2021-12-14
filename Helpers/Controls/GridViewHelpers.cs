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
        RejAndOlejModelsRegistrationCheck
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
                        returnObj = new OilCheck();
                        var str = nameof(OilChecksMainTableView.NumerRejestracyjny);
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
                                Convert.ToString(sender.SelectedRows[0].Cells[nameof(OilChecksMainTableView.NumerRejestracyjny)].Value) &&
                                v.MileageOnOilCheck == Convert.ToInt64(sender.SelectedRows[0].Cells[nameof(OilChecksMainTableView.PrzebiegNaMomentPrzegladu)].Value)).FirstOrDefault();
                        }
                        break;
                }

            }

            return (T)returnObj;
        }
    }
}


