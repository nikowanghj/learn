// See https://aka.ms/new-console-template for more information
using Microsoft.Azure.Search.Common;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

//DI 降低模块耦合，只要实现了类的对象就行，可以使系统更加灵活
ServiceCollection  services= new ServiceCollection();
services.AddScoped<ILog, LogTest>();
services.AddScoped<IStorage, Storage>();
services.AddSingleton<IConfigura, Configura>();

using (var sp = services.BuildServiceProvider())
{
    sp.GetService<IStorage>();
    sp.GetService<ILog>();
    sp.GetService<IConfigura>();

}





class Controller
{

}

interface ILog
{
    public void Log(string message);
}


class LogTest : ILog
{
    public void Log(string msg)
    {
        Console.WriteLine("AAAAAAAAAAAAAAAAAA" + msg);
    }
}

interface IConfigura
{
    public string GetValue(string path, string value);
}

class Configura : IConfigura
{
    public string GetValue(string path, string value)
    {
        return "setting";
    }
}

interface IStorage
{
    public void save(string name, string pwd);
}

class Storage : IStorage
{
    private readonly IConfigura _configura;

    public Storage(
        IConfigura configura
        )
    {
        Throw.IfArgumentNull(configura, nameof(configura));

        _configura = configura;
    }
    public void save(string name, string pwd)
    {
        _configura.GetValue(name, pwd);
    }
}
