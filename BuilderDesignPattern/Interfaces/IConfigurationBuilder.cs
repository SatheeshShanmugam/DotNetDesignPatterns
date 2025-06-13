using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Interfaces
{
    public interface IConfigurationBuilder
    {
        IConfigurationBuilder SetConnectionString(string connectionString);
        IConfigurationBuilder SetUrlPath(string urlPath);
        IConfiguration Build();
    }
}
