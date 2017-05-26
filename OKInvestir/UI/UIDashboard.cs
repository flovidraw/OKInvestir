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
    public partial class UIDashboard : UserControl
    {
        public VMDashboard ViewModel { get; set; }

        public UIDashboard()
        {
            InitializeComponent();
        }


        /**
         * Functions for button onclick
         */


        



        /**
         * Getters
         */
        public Label getLbNbClient() { return lbNbClient; }
        public Label getLbNbPdt() { return lbNbPdt; }
        public Label getLbNbPdtSold() { return lbNbPdtSold; }
        public Label getLbTurnover() { return lbTurnover; }
        public System.Windows.Forms.DataVisualization.Charting.Chart getChartTA() { return chartTA; }
        
    }
}
