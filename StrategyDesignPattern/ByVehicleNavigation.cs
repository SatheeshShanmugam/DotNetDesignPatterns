using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ByVehicleNavigation : INavigation
    {
        public void Navigate()
        {
            Console.WriteLine($"Navigating by vehicle.");
            // Logic for vehicle navigation
        }
       
    }
}
