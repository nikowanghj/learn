// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");


int i = 5;
int j = 7;
int k = 10;

//int[] nums = new int[] { i,j,k};
//int Max = nums.Max();
int Max2 = (i > j ? i : j) > k ? (i > j ? i : j) : k ;
Console.WriteLine(Max2);

//计算用逗号分隔的字符串的平均值

var grade = "61,90,100,99,18,22,38,66,80,93,55,50,89";
var items = grade.Split(',');
List<int> aa = new List<int>();
foreach (var item in items)
{
    aa.Add(int.Parse(item));
}
Console.WriteLine("平均值为：" + aa.Average());
// 使用selelct 投影转换类型
IEnumerable<int> bb = items.Select(item => int.Parse(item));
Console.WriteLine("平均值为：" + bb.Average());

//统计字符串中出现的每个字母频率（忽略大小写），由高到低输出次数大于
//2的单词和其出现的频率

var str = "dsadhfjakfhajnfauidjjklsajdlajsdmmclajflaskfjalfj";
var numbs = str.Where(c => char.IsLetter(c)).Select(c => char.ToLower(c))
   .GroupBy(s => s).Select(s => new { s.Key, count = s.Count() }).OrderByDescending(s=>s.count).Where(s=>s.count > 2); 
    ;
foreach(var a in numbs)
{
    Console.WriteLine(a);
}