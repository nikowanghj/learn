using LogService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    //扩展方法命名空间与需要扩展的接口的命名空间保持一致
    public static class ServiceClooectionExtisen
    {
        public static void AddLogService(this IServiceCollection service)
        {
            service.AddScoped<ILogProvider, LogProvider>();
        }
    }
}
