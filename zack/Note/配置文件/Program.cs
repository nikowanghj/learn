using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using 配置文件;

ServiceCollection service = new ServiceCollection();
service.AddScoped(typeof(TestController));
//使用 ConfigurationBuilder 类进行配置文件的读取
ConfigurationBuilder configuration = new ConfigurationBuilder();
//添加配置文件，设置属性
//json文件属性 设置为如果较新则复制，因为debugger状态下读取的是debug这个文件夹下的文件，如此设置可以复制json文件到debug文件夹下
configuration.AddJsonFile("config.json", true, true);
IConfigurationRoot root = configuration.Build();
var name = root["name"];
var address =  root.GetSection("proxy:address").Value;
Console.WriteLine(name);
Console.WriteLine(address);

//通过DI注册AddOptions方法，并把root绑定到config
service.AddOptions().Configure<Config>(e => root.Bind(e));

using (var sp = service.BuildServiceProvider())
{
    var testController = sp.GetService<TestController>();
    Console.WriteLine("________________________________");
    testController?.Test();
}



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