// See https://aka.ms/new-console-template for more information

// 委托指向匿名方法
Action a1 = delegate ()
{
    Console.WriteLine("Hello, World!");
};
Func<int, string, string> f1 = delegate (int age, string name)
{
    return (name + " :" + age + "岁");
};

//匿名方法写成lambda表达式,省略delegate
Func<int, int, int> f2 = (int i, int j) =>
{
    return (i + 1) + j;
};
//可以根据委托类型推断lambda表达式类型，可以省略委托类型
Func<int, int, int> f3 = (i,j) =>
{
    return (i + 1) + j;
};
a1();
Console.WriteLine(f1(18, "niko"));
Console.WriteLine(f2(18, 17));
Console.WriteLine(f3(10, 7));