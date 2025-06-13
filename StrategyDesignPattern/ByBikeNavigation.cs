using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ByBikeNavigation : INavigation
    {
        public void Navigate()
        {
            Console.WriteLine($"Navigating to by bike.");
            // Implement bike navigation logic here
        }


    }
}
