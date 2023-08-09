using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class whenall
    {
        static async Task Main()
        {
            List<string> list = new List<string>();
            "https://www.example.com",
                "https://www.google.com",
                "https://www.microsoft.com"
        };
        try{
        List<Task<string>> downloadTasks = new List<Task<string>>();
        foreach(string url in urls){
            downloadTasks.Add(DownloadDataAsync(url));
    }
    string[] results = await Task.WhenAll(downloadTasks);
    Console.WriteLine("Downloaded Tasks");
        foreach(string result in results){
        Console.WriteLine(result);
        }
}
catch(Exception e){
    Console.WriteLine("An error Occured :{ex.Message}");
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();
static async Task<string>DownloadDataAsync(string url)
{
    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string data=await response.Content.ReadAsStringAsync();
        return data;
    }
}


}
