using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class BusMakersMainTableView
    {
        public int ID { get; set; }

        public string BusMakerName { get; set; }

        public string BusMakerNation { get; set; }

        public BusMakersMainTableView(object model)
        {
            BusMaker busMaker = model as BusMaker;

            ID = busMaker.BusMakerId;
            BusMakerName = busMaker.Name;
            BusMakerNation = busMaker.Nation;
        }

        public BusMakersMainTableView()
        {

        }


    }
}