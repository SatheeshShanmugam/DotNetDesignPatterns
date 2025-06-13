using BuilderDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Implementations
{
    public class ConfigurationBuilder : IConfigurationBuilder
    {
        public IConfiguration Build()
        {
            throw new NotImplementedException();
        }

        public IConfigurationBuilder SetConnectionString(string connectionString)
        {
            throw new NotImplementedException();
        }

        public IConfigurationBuilder SetUrlPath(string urlPath)
        {
            throw new NotImplementedException();
        }
    }


}
