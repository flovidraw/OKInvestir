using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKInvestir.Model
{
    public interface IModel
    {
        void attachController(ViewModel.IViewModel IViewModel);
    }
}
