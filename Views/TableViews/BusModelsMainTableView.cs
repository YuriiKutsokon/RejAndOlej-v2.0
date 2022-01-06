using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class BusModelsMainTableView
    {
        public int ID { set; get; }

        public string BusMakerName { set; get;  }

        public string ModelName { set; get; }

        public int? DefaultDaysToCheck { set; get; }

        public long? DefaultKmToCheck { set; get; }


        public BusModelsMainTableView(object model)
        {
            Bus busModel = model as Bus;

            ID = busModel.BusId;
            BusMakerName = busModel.BusMaker.Name;
            ModelName = busModel.ModelName;
            DefaultDaysToCheck = busModel.DefaultDaysToRegistrationReview;
            DefaultKmToCheck = busModel.DefaultKmToOilInspection;
        }

        public BusModelsMainTableView()
        {

        }

        
    }
}
