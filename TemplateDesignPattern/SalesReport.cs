using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class SalesReport : ReportGenerator
    {

        protected override void LoadData()
        {

            Console.WriteLine("Datas are loaded");
        }
        protected override void ProcessData()
        {
            Console.WriteLine("Datas are manipulated");

        }

        protected override void SaveReport()
        {
            Console.WriteLine("Report is Saved");

        }
    }
}
