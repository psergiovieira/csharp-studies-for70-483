using System;
using System.Threading;

namespace myFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestingThreads();
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
