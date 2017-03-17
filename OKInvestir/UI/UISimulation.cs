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
        

        public UISimulation()
        {
            InitializeComponent();
            isEditing = false;
            tbAmout.Text = "Amount of the simulation";

        }

        private void UISimulation_Load(object sender, EventArgs e)
        {

        }

        private void lboxListProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
/** Getters
 **/
        public decimal getTbAmount()
        {
            decimal amountEntered;
            if (decimal.TryParse(tbAmout.Text.Trim(), out amountEntered))
            {
                if (amountEntered > 10000000)
                {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amout entered can't not be greater than 10 millions, please enter it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
                }
 
            }
            else
            {
                    ViewModel.VMMain.UIMainForm.genMsgBox("Your amout entered is empty or it's not a integer, please enter it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    amountEntered = 0;
            }

            return amountEntered;
        }

        public Label getLbValueAmount()
        {
            return lbValueAmount;
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
        
       





        /**
         * Functions for button onclick
         */
        private void lbAmout_Click(object sender, EventArgs e)
        {
           
        }
        private void btSimulate_Click(object sender, EventArgs e)
        {
            decimal amountEntered = getTbAmount();
            DateTime StartTime = dtpStartDate.Value;
            DateTime EndTime = dtpEndDate.Value;
            int periode = (int)(EndTime - StartTime).TotalDays / 30;
            
            this.ViewModel.resultSimulation();
            
            /**
            ViewModel.VMMain.UIMainForm.genMsgBox(ViewModel.FindTimeInterestSection().Time.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ViewModel.VMMain.UIMainForm.genMsgBox(ViewModel.FindSillInterestSection().Sill.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            **/
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.MinDate = DateTime.Now;
            DateTime StartDate = dtpStartDate.Value.Date;
            dtpEndDate.MinDate = dtpStartDate.Value.Date;

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {   
           DateTime EndTime = dtpEndDate.Value.Date;
        }

       
        

        /**
         * Getters
         */





    }
}
