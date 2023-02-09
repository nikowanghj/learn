using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService
{
    public class ConfigServiceProvider:IConfigService
    {
        public ConfigServiceProvider() { }

        public string GetValue(string name)
        {

            return Environment.GetEnvironmentVariable(name);
           
        }

    }
}
