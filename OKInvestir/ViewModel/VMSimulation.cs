using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;

namespace OKInvestir.ViewModel
{
    public class VMSimulation
    {
        private UISimulation View;
        public VMMain VMMain { get; set; }

        public VMSimulation(VMMain VMMain, UISimulation View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;
        }

        public Model.TimeInterest FindTimeInterestSection()
        {
            DateTime StartDate = View.getValueStartDate();
            DateTime EndDate = View.getValueEndDate();
            int periode = (int)(EndDate - StartDate).TotalDays / 30;
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {
                if ((timeI.Time <= periode) && (timeI.Time >= time.Time))
                {
                    time.Time = timeI.Time;
                    time.Interest = timeI.Interest;
                    time.Id = timeI.Id;
                    time.ProductID = timeI.ProductID;
                    time.Product = timeI.Product;
                }
            }
            return time;
        }

        public Model.SillInterest FindSillInterestSection(decimal Amount)
        {
            decimal amount = Amount;
            Model.SillInterest sill = new Model.SillInterest ();
            sill.Sill = 0;
            foreach(Model.SillInterest sillI in VMMain.Product.SillInterests)
            {
                if((sillI.Sill <= amount) && (sillI.Sill >= sill.Sill))
                {
                    sill.Sill = sillI.Sill;
                    sill.Id = sillI.Id;
                    sill.Interest = sillI.Interest;
                    sill.Product = sillI.Product;
                    sill.ProductID = sillI.ProductID;
                }
            }
            return sill;
        }

        public void resultSimulation()
        {

            decimal amountSimulation = View.getTbAmount();
            DateTime StartDateSimulation = View.getValueStartDate();
            DateTime EndDateSimulation = View.getValueEndDate();
            int periodeSimulation = (int)(EndDateSimulation - StartDateSimulation).TotalDays / 30;
            decimal InterestRateTime = FindTimeInterestSection().Interest;
            decimal InterestRateSill = FindSillInterestSection(amountSimulation).Interest;
            decimal InterestRateSimulation = ((InterestRateSill + 1) * (InterestRateTime + 1)) - 1;
            decimal SettlementPriceSimulation = amountSimulation * (1 + InterestRateSimulation);

            if (amountSimulation!= 0)
            {
                View.getLbValueAmount().Text = amountSimulation.ToString();
                View.getValuePeriode().Text = periodeSimulation.ToString()+" Months";

                View.getLbValueProductSelected().Text = VMMain.Product.Name;
                View.getLbValueInterestRate().Text = (InterestRateSimulation * 100).ToString()+" %";
                View.GetLbValueSettlementPrice().Text = SettlementPriceSimulation.ToString();
            }
        }

}
}
