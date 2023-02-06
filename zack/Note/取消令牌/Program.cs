// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var url = "https://www.taobao.com";
CancellationTokenSource cancellationToken = new CancellationTokenSource();
cancellationToken.CancelAfter(5000);
await DownLoad2Async(url,1000,cancellationToken.Token);
await DownLoadAsync(url, 1000);

static async Task DownLoadAsync(string url,int n)
{
    using (HttpClient client = new HttpClient())
    {
        for(int i = 0;i< n; i++)
        {
            var html = await client.GetStringAsync(url);
            Console.WriteLine("__________________________________");
        }
    }
}

static async Task DownLoad2Async(string url, int n,CancellationToken cancellationToken)
{
    using (HttpClient client = new HttpClient())
    {
        for (int i = 0; i < n; i++)
        {
            var html = await client.GetStringAsync(url);
            Console.WriteLine(html);
            //cancellationToken.ThrowIfCancellationRequested();
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("请求被取消");
                break;
            }
        }
    }
}
