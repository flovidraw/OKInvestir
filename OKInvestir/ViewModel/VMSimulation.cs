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
                    //time.Product = timeI.Product;
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
                    //sill.Product = sillI.Product;
                    sill.ProductID = sillI.ProductID;
                }
            }
            return sill;
        }

        public int MinimumTimeSimulation()
        {
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            int i = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {  
                if(i == 0)
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

        public void printBalance()
        {
            if (VMMain.Client.AccountList.Count > 0)
            {
                this.View.getLbValueBalance().Text = this.VMMain.Client.AccountList[0].Balance.ToString();
            }
            else
            {
                this.View.getLbValueBalance().Text = "No account";
            }
        }





           
        public Model.Simulation resultSimulation()
        {
            Model.Simulation simulation = new Model.Simulation();

            simulation.ClientId = VMMain.Client.Id;
            simulation.ProductId = VMMain.Product.Id;
            simulation.Price = View.getTbAmount();
            simulation.StartDate = View.getValueStartDate();
            simulation.EndDate = View.getValueEndDate();
            int periodeSimulation = (int)(simulation.EndDate - simulation.StartDate).TotalDays / 30;
            decimal InterestRateTime = FindTimeInterestSection().Interest;
            decimal InterestRateSill = FindSillInterestSection(simulation.Price).Interest;
            simulation.InterestRate = ((InterestRateSill + 100) * (InterestRateTime + 100))/100 - 100;
            simulation.SettlementPrice = simulation.Price * (100 + simulation.InterestRate)/100;

            if (InterestRateTime == 0)
            {
                VMMain.UIMainForm.genMsgBox("For this product selected, the minimum holding periode have to be more than " + MinimumTimeSimulation() + " months.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                simulation.Price= 0;
            }

            if (simulation.Price!= 0)
            {
                View.getLbValueAmount().Text = simulation.Price.ToString();
                View.getValuePeriode().Text = periodeSimulation.ToString()+" Months";

                View.getLbValueProductSelected().Text = VMMain.Product.Name;
                View.getLbValueInterestRate().Text = (simulation.InterestRate).ToString()+" %";
                View.GetLbValueSettlementPrice().Text = simulation.SettlementPrice.ToString();
            }
            return simulation;
        }

        public void saveSimulation(Model.Simulation simulation)
        {
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);  // connect to db
                context.Simulations.Add(simulation);
                try
                {
                    context.SaveChanges();  // save change
                    VMMain.UIMainForm.genMsgBox("Simulation saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                }
                catch (Exception e)
                {
                    VMMain.HandleException(e, this.VMMain.UIMainForm);
                    VMMain.UIMainForm.genMsgBox("Fail to save the simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                }
            }
        }
        
        
}
}
