using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Implementation
{
    public class Textbox : ITextBox
    {
        public string GetTextBoxColor()
        {
            return "Red";
        }
    }
}
