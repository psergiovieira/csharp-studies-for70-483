using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace myFirstApp
{
    public static class ThreadSamples
    {
        public static async void TestAsyncAwait()
        {
            try
            {
                Console.WriteLine(await DownloadContent("https://nytimes.com"));
                Console.WriteLine(await DownloadContent("http://www.microsoft.com"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static async Task<string> DownloadContent(string url)
        {
            using (var client = new HttpClient())
            {
                string result = await client.GetStringAsync(url);
                return result;
            }
        }

        public static void TestingTask()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine("---");
                }
            });

            Console.WriteLine("task goes away");

            t.Wait();
            Console.WriteLine("The End");
        }

        public static void TestingThreads()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work");
                Thread.Sleep(0);
            }

            t.Join();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}