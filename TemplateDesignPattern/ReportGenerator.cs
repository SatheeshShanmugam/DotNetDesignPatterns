using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class ReportGenerator 
    {
        //Template method
        public void GenerateReport()
        {
            LoadData();
            ProcessData();
            SaveReport();
        }

        protected abstract void LoadData();
        protected abstract void ProcessData();
        protected abstract void SaveReport();
    }
}
