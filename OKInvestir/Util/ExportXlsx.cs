using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OKInvestir.Model;
using OKInvestir.UI;

namespace OKInvestir.Util
{
    public class ExportXlsx
    {
        // Function to exoprt the given client's simulation list in to format Xlsx
        public static void exportXlsx(Client client, UIMainForm form)
        {
            string xlsxname = string.Empty;//  Name of file

            SaveFileDialog dlg = new SaveFileDialog();// Create a save file dialog
            dlg.FileName = "simulations";
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Text documents (.xlsx)|*.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<Simulation> ListSimulation = client.getSimulationList();// Get clients' simulation list

                DataTable dt = new DataTable(); // Create table of simulations
                DataColumn column;
                DataRow row;
                
                column = new DataColumn(); // Add columns
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Simulation Id";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Product name";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Decimal");
                column.ColumnName = "Price";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.DateTime");
                column.ColumnName = "Start date";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.DateTime");
                column.ColumnName = "End date";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Decimal");
                column.ColumnName = "Interest rate";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Decimal");
                column.ColumnName = "Settlement price";
                dt.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "Total months";
                dt.Columns.Add(column);
                
                
                foreach (Simulation sim in ListSimulation) // Add rows
                {
                    row = dt.NewRow(); // Add cells in each row
                    row["Simulation Id"] = sim.Id;
                    row["Product name"] = sim.Product.Name;
                    row["Price"] = sim.Price;
                    row["Start date"] = sim.StartDate;
                    row["End date"] = sim.EndDate;
                    row["Interest rate"] = sim.InterestRate;
                    row["Settlement price"] = sim.SettlementPrice;
                    row["Total months"] = (int)(((sim.EndDate - sim.StartDate).TotalDays) / 30);
                    dt.Rows.Add(row);
                }
                try
                {
                    if (File.Exists(dlg.FileName)) // Delect file if file already exist
                    {
                        File.Delete(dlg.FileName);
                    }

                    using (ExcelPackage pck = new ExcelPackage(new FileInfo(dlg.FileName))) // Open the excel file
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Simulation list ");

                        ws.Cells["A1"].Value = "Simulation list of " + client.FullName;
                        ws.Cells["A4"].LoadFromDataTable(dt, true);
                        pck.Save();
                    }
                }
                catch (IOException e)
                {
                    form.genMsgBox("Fail to export xlsx file.", "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }





    }
}
