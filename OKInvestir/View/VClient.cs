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
    public partial class VClient : ExtendedForm, IView
    {
        private ViewModel.VMClient ViewModel;

        public VClient()
        {
            InitializeComponent();
        }
        public void setViewModel(IViewModel IViewModel)
        {
            this.ViewModel = (VMClient)IViewModel;
        }

        public TextBox getTbClientName() { return tbClientName; }
        public TextBox getTbIDClient() { return tbIDClient; }
        public TextBox getTbIdCardNumber() { return tbIdCardNumber; }
        public TextBox getTbBalance() { return tbBalance; }
    }
}
