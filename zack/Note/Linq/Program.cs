// See https://aka.ms/new-console-template for more information

int[] nums = new int[] {12,43,67,445,898,343,454,565,434,322,90,45 };

IEnumerable<int> result = nums.Where(x => x > 500);
/*
  内部实现实现是使用lambda表达式实现的
  () => return x>500
 */
foreach (int num in result)
{
    Console.WriteLine(num);
}

Console.WriteLine("___________________________________");

foreach(var a in MyWhere1(nums,a => a> 500))
{
    Console.WriteLine(a);
}

Console.WriteLine("___________________________________________");

foreach(var b in MyWhere2(nums, a => a > 500))
{
    Console.WriteLine(b);
}
//使用lambda 表达式实现where方法
static IEnumerable<int> MyWhere1(IEnumerable<int> items, Func<int, bool> f)
{
    
    List<int> result = new List<int>();
    foreach (int item in items)
    {
        if (f(item))
        {
            result.Add(item);
        }
    }
    return result;
}

//使用yield return;
static IEnumerable<int> MyWhere2(IEnumerable<int> items, Func<int, bool> f)
{
    foreach(int item in items)
    {
        if (f(item))
        {
            yield return item;
        }
    }
}