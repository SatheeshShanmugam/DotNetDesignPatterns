using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class ByWalkNavigation : INavigation
    {
        public void Navigate()
        {
            Console.WriteLine("Navigating by walking...");
        }
    }  
}
