using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;
using OKInvestir.Model;

namespace OKInvestir.ViewModel
{
    public class VMDashboard
    {
        private UIDashboard View;
        private VMMain VMMain;

        public VMDashboard(VMMain VMMain, UIDashboard View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;

            loadDataInDashboard();
        }


        /**
         * Load data from db and change labels
         */
        public void loadDataInDashboard()
        {
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db

                View.getLbNbClient().Text = context.Clients.Count().ToString();
                View.getLbNbPdt().Text = context.Products.Where(p => p.ProductStatus == 1).Count().ToString();
                View.getLbNbPdtSold().Text = context.BoughtProducts.Count().ToString();

                
                decimal turnover = 0;
                foreach (BoughtProduct bp in context.BoughtProducts.ToList())
                {
                    turnover += bp.Price;
                }
                View.getLbTurnover().Text = turnover.ToString();

                Cursor.Current = Cursors.Arrow;             // get back to normal cursor

                generateChart();
            }
        }

        public void generateChart()
        {
            Dictionary<DateTime, decimal> chartData = new Dictionary<DateTime, decimal>();

            // get list of bought product
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db

                /*List<BoughtProduct> bpList = context.BoughtProducts.ToList();
                foreach (BoughtProduct bp in bpList)
                {
                    chartData.Add(bp.BuyingDate, bp.Price);
                }*/

                DateTime last3Day = DateTime.Today.AddMonths(-3).AddDays(-3);
                foreach (DateTime day in EachDay(DateTime.Today.AddMonths(-3), DateTime.Today))
                {
                    List<BoughtProduct>bps = context.BoughtProducts
                        .Where(bp => bp.BuyingDate > last3Day && bp.BuyingDate < day).ToList();
                    decimal sum = 0;
                    foreach(BoughtProduct bp in bps)
                    {
                        sum = sum + bp.Price;
                    }
                    chartData.Add(day, sum);
                    Console.WriteLine("day = " + day + "sum = " + sum);

                    last3Day = day;
                }


                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }

            // sort dictionary by date
            // ref: http://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value
            var sortedDict = from entry in chartData orderby entry.Key ascending select entry;
            // convert IEnumerable to dictionary
            // ref: http://stackoverflow.com/questions/3066182/convert-an-iorderedenumerablekeyvaluepairstring-int-into-a-dictionarystrin
            Dictionary<DateTime, decimal> sortedChartData = sortedDict.ToDictionary(pair => pair.Key, pair => pair.Value);

            System.Windows.Forms.DataVisualization.Charting.Chart chartTA = View.getChartTA();
            // binding data
            chartTA.Series[0].Points.DataBindXY(sortedChartData.Keys, sortedChartData.Values);

            // reset linetension property to make line not too smooth
            // ref: http://stackoverflow.com/questions/38080022/spline-chart-smooth-corners
            chartTA.Series[0].SetCustomProperty("LineTension", "0.3");
        }


        /**
         * IEnumerable to help foreach date in range
         * ref: http://stackoverflow.com/questions/1847580/how-do-i-loop-through-a-date-range
         * 
         * change day.AddDays(x) to change step
         */
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(3))
                yield return day;
        }
    }
}
