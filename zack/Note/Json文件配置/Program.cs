


using JsonConfig;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();
//services.AddScoped<TestController>();
services.AddScoped(typeof(TestController));
ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("Config.json",true,true);
IConfigurationRoot root = configurationBuilder.Build();
//首先通过DI注册options方法
//把Config对象绑定到根节点(config)
services.AddOptions().Configure<Config>(e => root.Bind(e));

using (var sp = services.BuildServiceProvider())
{
    var c =  sp.GetService<TestController>();
    c.Test();

}

    //var myName = root["name"];
    //Console.WriteLine("Name is {0}",myName);
    //var address = root.GetSection("proxy:address").Value;
    //Console.WriteLine("address is {0}", address);
    //Console.ReadKey();

// Proxy proxy = root.GetSection("proxy").Get<Proxy>();
//Console.WriteLine("地址:{0},端口{1}",proxy?.Address,proxy?.Port);

//Config config =  root.Get<Config>();
//Console.WriteLine("姓名：{0},年龄:{1},IP:{2}",config?.Name,config?.Age,string.Concat(config?.Proxy?.Address,":",
// config?.Proxy?.Port));



public class Config
{
    public string? Name { get; set; }
    public string? Age { get; set; }
    public Proxy? Proxy { get; set; }
}
public class Proxy
{
    public string? Address { get; set; }
    public string? Port { get; set; }
}