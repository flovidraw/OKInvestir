using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.ViewModel;

namespace OKInvestir.View
{

    public partial class VSimulationResult : ExtendedForm, IView
    {
        private ViewModel.VMSimulationResult ViewModel;

        public VSimulationResult()
        {
            InitializeComponent();
        }
        public void setViewModel(IViewModel IViewModel)
        {
            this.ViewModel = (VMSimulationResult)IViewModel;
        }
    }
}
