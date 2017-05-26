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

    public partial class VSimulation : ExtendedForm, IView
    {
        private ViewModel.VMSimulation ViewModel;

        public VSimulation()
        {
            InitializeComponent();
        }
        public void setViewModel(IViewModel IViewModel)
        {
            this.ViewModel = (VMSimulation)IViewModel;
        }

        private void VSimulation_Load(object sender, EventArgs e)
        {

        }
    }
}
