// See https://aka.ms/new-console-template for more information

//委托指向方法的类型；
D1 d = f1;
f1();

D2 d2 = Add;
Console.WriteLine(d2(7,8));

//.net 定义好的两个泛型委托 Action - 无参数， Func - 有参数
Action a1 = f1;
a1();

Func<int, int,int> f = Add;
Console.WriteLine(f(4,90));

static void f1()
{
    Console.WriteLine("我是f1");
}
static int Add(int i,int j)
{
    return i + j;
}

delegate void D1();

delegate int D2(int i,int j);