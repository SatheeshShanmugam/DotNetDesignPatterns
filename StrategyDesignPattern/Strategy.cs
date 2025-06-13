using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Strategy 
    {
        private INavigation _navigationStrategy;
        public Strategy(INavigation navigation)
        {
            _navigationStrategy = navigation;
        }
        public void Navigate()
        {
            _navigationStrategy.Navigate();
        }
        public void SetStrategy(INavigation navigation)
        {
            _navigationStrategy = navigation;
        }

    }
}
