﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Interfaces
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
