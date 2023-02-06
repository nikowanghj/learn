// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Threading;

Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
StringBuilder sb = new StringBuilder();
for(int i =0;i <1000; i++)
{
    sb.Append(i.ToString());
}
await File.WriteAllTextAsync(@"1.txt", sb.ToString());
Console.WriteLine(Thread.CurrentThread.ManagedThreadId);