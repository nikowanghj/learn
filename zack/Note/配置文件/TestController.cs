using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 配置文件
{
    public class TestController
    {
        private readonly IOptionsSnapshot<Config> _optConfig;

        public TestController(IOptionsSnapshot<Config> optConfig)
        {
            _optConfig = optConfig ?? throw new ArgumentNullException();
        }
        public void Test()
        {
            Console.WriteLine("name:{0}",_optConfig.Value.Name);
            Console.WriteLine("age:{0}",_optConfig.Value.Age);
            Console.WriteLine("ipAddress:{0}",string.Concat(_optConfig?.Value?.Proxy?.Address,":",_optConfig?.Value?.Proxy?.Port));
        }
    }
}
