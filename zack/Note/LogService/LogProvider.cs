using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService
{
    public class LogProvider: ILogProvider
    {
        public LogProvider() { }

        public void LogError(string msg)
        {
            Console.WriteLine("Error:{0}",msg);
        }
        public void LogInfo(string msg)
        {
            var timeStamp = DateTime.Now;
            Console.WriteLine("时间：{0},信息：{1}",timeStamp,msg);
        }
    }
}
