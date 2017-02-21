using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKInvestir.View
{
    public interface IView
    {
        void setViewModel(ViewModel.IViewModel IViewModel);
    }
}
