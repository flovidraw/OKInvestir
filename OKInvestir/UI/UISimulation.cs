using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.ViewModel;
using OKInvestir.Util;

namespace OKInvestir.UI
{
    public partial class UISimulation : UserControl
    {
        public VMSimulation ViewModel { get; set; }// ViewModel of this view
        public bool isSimulate;// boolean to check if client has simulated a product
        public Model.Simulation SimulationToSave = new Model.Simulation();// The result of the latest simulation

        // Constructor
        public UISimulation()
        {
            InitializeComponent();
            dtpStartDate.MinDate = DateTime.Today;
            isSimulate = false;

        }

       
        /**
         * Getters
         **/
        public decimal getTbAmount()
        {
            decimal amountEntered;

            if (decimal.TryParse(tbAmout.Text.Trim(), out amountEntered))
            {
                if (amountEntered > 10000000)
                {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amount entered can't not be greater than 10 millions, please enter it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
                    isSimulate = false;
                }
                else if (amountEntered <= 0)
                {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amount entered can't not be equals or less than 0, please enter it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
                    isSimulate = false;
                }

            }
            else
            {
                ViewModel.VMMain.UIMainForm.genMsgBox("Your amount entered is empty or it's not a integer, please enter it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amountEntered = 0;
                isSimulate = false;
            }

            return amountEntered;
        }

        public TextBox getTextBAmount()
        {
            return tbAmout;
        }



        public Label getLbValueAmount()
        {
            return lbValueAmount;
        }

        public Label getLbValueBalance()
        {
            return lbValueBalance;
        }

        public DateTime getValueStartDate()
        {
            return dtpStartDate.Value;
        }

        public DateTime getValueEndDate()
        {
            return dtpEndDate.Value;
        }
        public Label getValuePeriode()
        {
            return lbValuePeriode;
        }
        public Label getLbValueProductSelected()
        {
            return lbValueProductSelected;
        }
        public Label getLbValueInterestRate()
        {
            return lbValueInterestRate;
        }
        public Label GetLbValueSettlementPrice()
        {
            return lbValueSettlementPrice;
        }

        public DateTimePicker getDTPS()
        {
            return dtpStartDate;
        }

        public DateTimePicker getDTPE()
        {
            return dtpEndDate;
        }
        public ListBox getLboxSim()
        {
            return lboxSimulation;
        }





        /**
         * Functions for button onclick
         */

        // Function onclick of the simulate button
        private void btSimulate_Click(object sender, EventArgs e)
        {
            if (this.ViewModel.VMMain.Product != null)
            {
                this.SimulationToSave = this.ViewModel.resultSimulation();
               
            }
            else
            {
                isSimulate = false;
                this.ViewModel.VMMain.UIMainForm.genMsgBox("You haven't chose a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // Function while selecting the start date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.Date;
            isSimulate = false;

        }

        // Function while selecting the end date
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime EndTime = dtpEndDate.Value.Date;
            isSimulate = false;

        }

        // Function onclick of the save button
        private void btSave_Click(object sender, EventArgs e)
        {
            if (isSimulate == true)
            { 
                this.ViewModel.saveSimulation(this.SimulationToSave);
                this.ViewModel.getSimulation();
            }
            else
            {
                this.ViewModel.VMMain.UIMainForm.genMsgBox("You haven't simulated yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function for when the amount has been changed 
        private void tbAmout_TextChanged(object sender, EventArgs e)
        {
            isSimulate = false;
        }

        // Function to select and show a simulation
        private void btSimulationChosen_Click(object sender, EventArgs e)
        {
            Model.Simulation sim = (Model.Simulation)lboxSimulation.SelectedItem;
            if (sim != null)
            {
                this.ViewModel.chooseSimulation(sim);
            }
            else
            {
                ViewModel.VMMain.UIMainForm.genMsgBox("Please choose a simulation first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Function to delect a simulation
        private void btDelete_Click(object sender, EventArgs e)
        {
            Model.Simulation Sim = (Model.Simulation)lboxSimulation.SelectedItem;
            this.ViewModel.delectSimulaion(Sim);
            this.ViewModel.getSimulation();
        }

        //Function to execute a simulation
        private void btExecute_Click(object sender, EventArgs e)
        {
            Model.Simulation sim = (Model.Simulation)lboxSimulation.SelectedItem;
            this.ViewModel.ExecuteSimulation(sim);
        }

        // Function onclick of button export PDF
        private void exportPdf_Click(object sender, EventArgs e)
        {
            ExportPDF.writePdf(ViewModel.VMMain.Client, ViewModel.VMMain.UIMainForm);
        }

        // Function onclick of button export CSV
        private void exportCsv_Click(object sender, EventArgs e)
        {
            ExportCsv.writeCsv(this.ViewModel.VMMain.Client, this.ViewModel.VMMain.UIMainForm);
        }

        // Function onclick of button export XLSX
        private void exportXlsx_Click(object sender, EventArgs e)
        {
            ExportXlsx.exportXlsx(ViewModel.VMMain.Client, ViewModel.VMMain.UIMainForm);
        }
    }
}
