using Microsoft.Azure.Search.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JsonConfig
{
     class TestController
    {
        private readonly IOptionsSnapshot<Config> _optConfig;
         TestController(
            IOptionsSnapshot<Config> optConfig
            ) 
            {
            Throw.IfArgumentNull(optConfig, nameof(optConfig));
            
            _optConfig= optConfig;
            }
        public void Test()
        {
            Console.WriteLine("age:{0}",_optConfig.Value.Age);
            Console.WriteLine("________________________________");
            Console.WriteLine("name:{0}:",_optConfig.Value.Name);

        }
    }
}
