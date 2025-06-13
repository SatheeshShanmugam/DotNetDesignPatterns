using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Implementation
{
    public class LightThemeFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            throw new NotImplementedException();
        }

        public ITextBox CreateTextBox()
        {
            throw new NotImplementedException();
        }
    }
}
