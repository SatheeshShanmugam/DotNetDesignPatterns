﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Interfaces
{
    public interface IConfiguration
    {
        string ConnectionString { get; set; }
        string UrlPath { get; set; }
    }
}
