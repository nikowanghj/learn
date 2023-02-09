// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

//Console.WriteLine("Hello, World!");

//ITestService ts1 = new TestServiceImp1();
//ts1.Name = "Niko";
//ts1.SayHi();
//ITestService ts2 = new TestServiceImp2();
//ts2.Name = "王海军";
//ts2.SayHi();

ServiceCollection services = new ServiceCollection();
//services.AddTransient<TestServiceImp1>();
//services.AddTransient<TestServiceImp2>();
//services.AddSingleton<TestServiceImp1>();
services.AddScoped<TestServiceImp1>();
using (ServiceProvider sp = services.BuildServiceProvider())
{
    //TestServiceImp1 t1 = sp.GetService<TestServiceImp1>();
    //t1.Name = "Niko";
    //t1.SayHi();
    //TestServiceImp1 t2 = sp.GetService<TestServiceImp1>();
    //Console.WriteLine(object.ReferenceEquals(t1, t2));
    //t2.Name = "Lily";
    //t2.SayHi();


    //Scope 范围由程序员自己确定
    IServiceScope scope = sp.CreateScope();
    TestServiceImp1 t1 = scope.ServiceProvider.GetService<TestServiceImp1>();
    t1.Name = "Niko";
    t1.SayHi();
    TestServiceImp1 t2 = scope.ServiceProvider.GetService<TestServiceImp1>();
    Console.WriteLine(object.ReferenceEquals(t1, t2));
}

public interface ITestService
{
    public string Name { get; set; }
    public void SayHi();
}

public class TestServiceImp1 : ITestService
{
    public string Name { get; set; }

    public TestServiceImp1(
        string Name
        )
    {
        this.Name = Name;
    }
    public void SayHi()
    {
        Console.WriteLine($"Hi,my name is {Name}");
    }
}

public class TestServiceImp2 : ITestService
{
    public string Name { get; set; }

    public void SayHi()
    {
        Console.WriteLine($"嗨，我是{Name}");
    }
}
