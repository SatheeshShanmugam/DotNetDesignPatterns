using BuilderDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Implementations
{
    public class Configuration : IConfiguration
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UrlPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
