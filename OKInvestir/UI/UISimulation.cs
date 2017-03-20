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

namespace OKInvestir.UI
{
    public partial class UISimulation : UserControl
    {
        public VMSimulation ViewModel { get; set; }
        public bool isEditing { get; set; }
        bool isSimulate;

        public UISimulation()
        {
            
            InitializeComponent();
            isEditing = false;
            dtpStartDate.MinDate = DateTime.Today;
            isSimulate = false;

        }

        private void UISimulation_Load(object sender, EventArgs e)
        {

        }

        private void lboxListProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                }
                else if (amountEntered <= 0)
                {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amount entered can't not be equals or less than 0, please enter it again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
                }
                
            }
            else
            {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amount entered is empty or it's not a integer, please enter it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
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






        /**
         * Functions for button onclick
         */
        private void lbAmout_Click(object sender, EventArgs e)
        {
           
        }

        private void btSimulate_Click(object sender, EventArgs e)
        {
            

            if (this.ViewModel.VMMain.Product != null)
            {
               this.ViewModel.resultSimulation();
                isSimulate = true;

            }
            else
            {
                this.ViewModel.VMMain.UIMainForm.genMsgBox("You haven't chose a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime StartDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.Date;
            isSimulate = false;

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {   
           DateTime EndTime = dtpEndDate.Value.Date;
            isSimulate = false;
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isSimulate == true)
            {
                this.ViewModel.saveSimulation(this.ViewModel.resultSimulation());
            }
            else
            {
                this.ViewModel.VMMain.UIMainForm.genMsgBox("You haven't simulated yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAmout_TextChanged(object sender, EventArgs e)
        {
            isSimulate = false;
        }

        /**
         * Getters
         */





    }
}
