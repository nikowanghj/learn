// See https://aka.ms/new-console-template for more information
string[] files = Directory.GetFiles(@"d:\learn\zack\Note\temp");
List<Task<int>> counts = new List<Task<int>>();

foreach(var file in files)
{
    var result = ReadCharCount(file);
    counts.Add(result);
}
// when all 多个异步方法都执行结束后这个Task结束
var allTask = await Task.WhenAll(counts);
var sum = allTask.Sum();
Console.WriteLine(sum.ToString());

Console.WriteLine("______________________");
foreach(var s in Test())
{
    Console.WriteLine(s);
}
Console.WriteLine("______________________");
//yield 在异步方法中，添加await 修饰调用
await foreach (var s in Test2())
{
    Console.WriteLine(s);
}


static async Task<int> ReadCharCount(string fileName)
{
    var s = await File.ReadAllTextAsync(fileName);
    return s.Length;
}
//yield 也是拆分成状态机的方式执行
static IEnumerable<string> Test()
{
    yield return "1";
    yield return "2";
    yield return "3";

}

static async IAsyncEnumerable<string> Test2()
{
    yield return "1";
    yield return "2";
    yield return "3";

}
