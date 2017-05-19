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
        public static void exportXlsx(Client client, UIMainForm form)
        {
            string pdfname = string.Empty;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "simulations";
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Text documents (.xlsx)|*.xlsx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<Simulation> ListSimulation = client.getSimulationList();

                DataTable dt = new DataTable();
                DataColumn column;
                DataRow row;
                
                column = new DataColumn();
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
                
                
                foreach (Simulation sim in ListSimulation)
                {
                    row = dt.NewRow();
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
                    if (File.Exists(dlg.FileName))
                    {
                        File.Delete(dlg.FileName);
                    }

                    using (ExcelPackage pck = new ExcelPackage(new FileInfo(dlg.FileName)))
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
