using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Implementation
{
    public class Button : IButton
    {
        public string GetButtonColor()
        {
            return "Blue";
        }
    }
    
}
