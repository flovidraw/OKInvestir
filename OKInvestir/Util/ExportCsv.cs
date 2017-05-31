using OKInvestir.Model;
using OKInvestir.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKInvestir.Util
{
    public class ExportCsv
    {
        // Function to exoprt the given client's simulation list in to format csv
        public static void writeCsv(Client clt, UIMainForm form)
        {
            string csvname = string.Empty;//  Name of file

            SaveFileDialog dlg = new SaveFileDialog();// Create a save file dialog
            dlg.FileName = "simulations";
            dlg.DefaultExt = ".csv";
            dlg.Filter = "Text documents (.csv)|*.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<Simulation> simus = clt.getSimulationList();// Get clients' simulation list

                // Write headers 
                StringBuilder str = new StringBuilder();
                str.Append("\"sep=;\"\n");
                str.Append("Client: ");
                str.Append(clt.FullName);
                str.Append(";\n");
                str.Append("ID: ");
                str.Append(clt.Id);
                str.Append(";\n");
                str.Append(DateTime.Now);
                str.Append(";\n");

                str.Append("Simulations: ;\n");
                str.Append("Simulation Id;Product name;Price;Start date;End date;Interest rate;Settlement price;Total months;\n");

                // build text
                foreach (Simulation simu in simus)
                {
                    str.Append(simu.Id);
                    str.Append(";");
                    str.Append(simu.Product.Name);
                    str.Append(";");
                    str.Append(simu.Price);
                    str.Append(";");
                    str.Append(simu.StartDate.ToShortDateString());
                    str.Append(";");
                    str.Append(simu.EndDate.ToShortDateString());
                    str.Append(";");
                    str.Append(simu.InterestRate);
                    str.Append(";");
                    str.Append(simu.SettlementPrice);
                    str.Append(";");
                    str.Append((int)((simu.EndDate - simu.StartDate).TotalDays) / 30);
                    str.Append(";");
                    str.Append("\n");
                }
                try
                {
                    using (StreamWriter file = new StreamWriter(@dlg.FileName))
                    {
                        file.Write(str);
                        file.Close();
                    }
                }
                catch (IOException e)
                {
                    form.genMsgBox("Cannot write file, maybe file is openned", "Error",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }

            }
        }
    }
}
