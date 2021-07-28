using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejAndOlej.Views.TableViews
{
    class BusMakersMainTAbleView
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string BusMakerNation { get; set; }

        public BusMakersMainTAbleView(BusMaker busMaker)
        {
            ID = busMaker.BusMakerId;
            Name = busMaker.Name;
            BusMakerNation = busMaker.Nation;
        }

        public BusMakersMainTAbleView()
        {

        }

        public static List<BusMakersMainTAbleView> GetBusMakerViewList(List<BusMaker> busMakers)
        {
            List<BusMakersMainTAbleView> viewList = new List<BusMakersMainTAbleView>();

            foreach(BusMaker busMaker in busMakers)
            {
                viewList.Add(new BusMakersMainTAbleView(busMaker));
            }

            return viewList;
        }
    }
}