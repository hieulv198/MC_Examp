using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0118
    {
        public static void DoSample()
        {
            string result = DownloadContentFake().Result; // This Will Block Main Thread!!!
            Console.WriteLine(result);
        }

        public static async void DoSampleDoubleAwait()
        {
            string result = await DownloadContentFake();
            Console.WriteLine(result);
        }

        private static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }

        private static async Task<string> DownloadContentFake()
        {
            string result = string.Empty;
            await Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    result = "result from CLient";
                });
            return result;
        }

        private static async Task<string> DownloadAwaitMany()
        {
            string result = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                await Task.Run(
                             async () =>
                                 {
                                     // don't do that because fist await can blocking???????
                                     Thread.Sleep(2000);
                                     string result1 = await client.GetStringAsync("http://www.google.commm");
                                     string result2 = await client.GetStringAsync("http://www.microsoft.com");
                                     result = result1 + result2;
                                 });
                return result;
            }
        }

        private static async Task<string> DownloadAwaiWhenAll()
        {
            string result = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                await Task.Run(
                    async () =>
                        {
                            Thread.Sleep(2000);
                            Task<string> t1 = client.GetStringAsync("http://www.google.commm");
                            Task<string> t2 = client.GetStringAsync("http://www.microsoft.com");
                            await Task.WhenAll(t1, t2);
                            result = t1.Result + t2.Result;
                        });
                return result;
            }
        }
    }
}
