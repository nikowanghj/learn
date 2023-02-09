using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService
{
    public class IniConfigService : IConfigService
    {
        public string FilePath { get; set; }
        public string GetValue(string name)
        {
            var kv = File.ReadAllLines(FilePath).Select(s =>
             new { Name = s.Split("=")[0].Trim(), Value = s.Split("=")[1].Trim() })
                .FirstOrDefault(kv => kv.Name == name);

            return kv.Value;
        }
    }
}
