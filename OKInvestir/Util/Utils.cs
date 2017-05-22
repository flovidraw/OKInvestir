using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.Model;

namespace OKInvestir.Util
{
    class Utils
    {
        public static Model.TimeInterest FindTimeInterestSection(DateTime StartDate, DateTime EndDate, List<TimeInterest> TimeInterest)
        {
            // DateTime StartDate = View.getValueStartDate();
            //DateTime EndDate = View.getValueEndDate();
            int periode = (int)(EndDate - StartDate).TotalDays / 30;
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            foreach (Model.TimeInterest timeI in TimeInterest)
            {
                if ((timeI.Time <= periode) && (timeI.Time >= time.Time))
                {
                    time.Time = timeI.Time;
                    time.Interest = timeI.Interest;
                    time.Id = timeI.Id;
                    time.ProductID = timeI.ProductID;
                    //time.Product = timeI.Product;
                }
            }
            return time;
        }

        public static int MinimumTimeSimulation(List<TimeInterest> TimeInterest)
        {
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            int i = 0;
            foreach (Model.TimeInterest timeI in TimeInterest)
            {
                if (i == 0)
                {
                    time.Time = timeI.Time;
                }
                else
                {
                    if (timeI.Time < time.Time)
                    {
                        time.Time = timeI.Time;
                    }
                }
                i++;
            }
            return time.Time;
        }

        public static Model.SillInterest FindSillInterestSection(decimal Amount, List<SillInterest> SillInterest)
        {
            decimal amount = Amount;
            Model.SillInterest sill = new Model.SillInterest();
            sill.Sill = 0;
            foreach (Model.SillInterest sillI in SillInterest)
            {
                if ((sillI.Sill <= amount) && (sillI.Sill >= sill.Sill))
                {
                    sill.Sill = sillI.Sill;
                    sill.Id = sillI.Id;
                    sill.Interest = sillI.Interest;
                    //sill.Product = sillI.Product;
                    sill.ProductID = sillI.ProductID;
                }
            }
            return sill;
        }

    }
}
