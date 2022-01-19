using System.Collections.Generic;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace CS34.Networking_P2
{
    class Program
    {
        public static async Task DowloadStream(string url, string filename)
        {
            using var httpClient = new HttpClient();
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();
                using var streamwrite = File.OpenWrite(filename);
                int SIZEBUFFER = 500;
                var buffer = new byte[SIZEBUFFER];
                bool endread = false;

                do
                {
                    int numBytes = await stream.ReadAsync(buffer, 0, SIZEBUFFER);
                    if(numBytes == 0){
                        endread = true;
                    }else{
                       await streamwrite.WriteAsync(buffer, 0, numBytes);
                    }
                } while (!endread);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

        }
        static async Task Main(string[] args)
        {
            // var url = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
            // await DowloadStream(url, "2.png");

            using var httpClient = new HttpClient();
            var httpMessageRequest = new HttpRequestMessage();
            httpMessageRequest.Method = HttpMethod.Post;
            httpMessageRequest.RequestUri = new Uri("https://postman-echo.com/post");
            httpMessageRequest.Headers.Add("User-Agent", "Mozilla/5.0");
            var data = @"{
                ""key1"": ""giatri1"",
                ""key2"": ""giatri2""
                }";
            // Console.WriteLine(data);

            // var content = new StringContent(data, Encoding.UTF8, "application/json");

            var content = new MultipartFormDataContent();

            Stream fileStream = File.OpenRead("1.txt");
            var fileUpload = new StreamContent(fileStream);
            //Upload file
            content.Add(fileUpload, "fileupload", "abc.xyz");
            content.Add(new StringContent("Value1"), "Key1");

            // var parameters = new List<KeyValuePair<string, string>>();
            // parameters.Add(new KeyValuePair<string, string>("key1", "value1"));
            // parameters.Add(new KeyValuePair<string, string>("key2", "value2-1"));
            // parameters.Add(new KeyValuePair<string, string>("key2", "value2-2"));

            // var content = new FormUrlEncodedContent(parameters);

            httpMessageRequest.Content = content;
            var httpResponseMessage = await httpClient.SendAsync(httpMessageRequest);
            var html = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(html);
        }
    }
}
