using System;
using System.Net.Http;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();

            Console.WriteLine("Téléchargement en cours");
            string url = "https://codeavecjonathan.com/res/dummy.txt";
            var task = httpClient.GetStringAsync(url);
            task.Wait();

            Console.WriteLine("OK");

            Console.WriteLine(task.Result); 

        }
    }
}
