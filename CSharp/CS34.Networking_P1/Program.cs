using System.Net;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Threading.Tasks;
using IOStream = System.IO.Stream;
using System.Net.Http.Headers;
using System.IO;

namespace CS34.Networking_P1
{
    class Program
    {
        static void ShowHeaders(HttpResponseHeaders headers){
            Console.WriteLine("Hiển thị các headers");
            foreach (var header in headers)
            {
                Console.WriteLine($"{header.Key} - {header.Value}");
            }
        }
        public static async Task<string> GetWebContent(string url)
        {
            using var httpClient = new HttpClient();
            try
            {
                //Add header 
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                ShowHeaders(httpResponseMessage.Headers);
                string html = await httpResponseMessage.Content.ReadAsStringAsync();
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Đã xảy ra lỗi !";
            }

        }

        public static async Task<byte[]> DownloadDataBytes(string url)
        {
            using var httpClient = new HttpClient();
            try
            {
                //Add header 
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                ShowHeaders(httpResponseMessage.Headers);
                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return bytes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        // static void Main(string[] args)
        // {
        // string url = "https://www.facebook.com/stories/create";
        // var uri = new Uri(url);
        // var uritype = typeof(Uri);
        // uritype.GetProperties().ToList().ForEach(property =>
        // {
        //     Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
        // });
        // Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

        // var hostname = System.Net.Dns.GetHostName();
        // Console.WriteLine(hostname); // LAPTOP-SQJOH6L4

        // string url1 = "https://www.bootstrapcdn.com/";
        // var uri1 = new Uri(url1);
        // Console.WriteLine(uri1.Host);
        // var iphostentry = Dns.GetHostEntry(uri1.Host);
        // Console.WriteLine(iphostentry.HostName);
        // iphostentry.AddressList.ToList().ForEach(ip => {
        //     Console.WriteLine(ip);
        // });

        // var ping = new Ping();
        // var pingReply = ping.Send("google.com.vn");
        // Console.WriteLine(pingReply.Status);
        // if (pingReply.Status == IPStatus.Success)
        // {
        //     Console.WriteLine(pingReply.RoundtripTime);
        //     Console.WriteLine(pingReply.Address);
        // }

        //     var url = "https://www.google.com/search?q=xuanthulab";
        //     var task = GetWebContent(url);
        //     task.Wait();
        //     var html = task.Result;
        //     Console.WriteLine(html);

        // }

        static async Task Main(string[] args)
        {
            // var url = "https://www.google.com/search?q=xuanthulab";
            // var html = await GetWebContent(url);
            // Console.WriteLine(html);

            var url1 = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
            var bytes = await DownloadDataBytes(url1);
            Console.WriteLine(bytes);
            string filename = "1.png";
            using var stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
