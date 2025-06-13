using AbstractFactoryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Renderer
    {
        readonly IThemeFactory _themeFactory;
        public Renderer(IThemeFactory themeFactory)
        {
            _themeFactory = themeFactory;
        }

        public void render()
        {
            var button = _themeFactory.CreateButton();
            var textBox = _themeFactory.CreateTextBox();
            button.GetButtonColor();
            textBox.GetTextBoxColor();
        }
    }
}
