using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace myFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadKey();
        }

        private static void DynamicTest()
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);
        }
    }
}
