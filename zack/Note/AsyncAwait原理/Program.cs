// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("开始线程:" + Thread.CurrentThread.ManagedThreadId);
await CalcAsync(500);
Console.WriteLine("结束线程：" + Thread.CurrentThread.ManagedThreadId);
static async Task<double> CalcAsync(int n)
{
    //Console.WriteLine("CalcaAsync," + Thread.CurrentThread.ManagedThreadId);
    //double result = 0;
    //Random random = new Random();
    //for(var i = 0;i < n * n; i++)
    //{
    //    result += random.NextDouble();
    //}
    //return result;


    //开新线程
    return await Task.Run(() =>
    {
        Console.WriteLine("CalcaAsync," + Thread.CurrentThread.ManagedThreadId);
        double result = 0;
        Random random = new Random();
        for (var i = 0; i < n * n; i++)
        {
            result += random.NextDouble();
        }
        return result;
    });
}
