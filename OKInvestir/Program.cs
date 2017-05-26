using System;
using System.Windows.Forms;
using OKInvestir.ViewModel;

namespace OKInvestir
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VMMain VMMain = new VMMain();
            Application.Run(VMMain.UIMainForm);
        }
    }
}
