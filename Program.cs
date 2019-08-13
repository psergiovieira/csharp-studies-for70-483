using System;
using System.IO;

namespace myFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DriverTest();
            Console.ReadKey();
        }

        private static void DynamicTest()
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SameProperty);
        }

        private static void DriverTest()
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive {0}", driveInfo.Name);
                Console.WriteLine(" File type: {0}", driveInfo.DriveType);
                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine(" Volume label: {0}", driveInfo.VolumeLabel);
                    Console.WriteLine(" File system: {0}", driveInfo.DriveFormat);
                    Console.WriteLine(" Available space to current user:{0} bytes", driveInfo.AvailableFreeSpace);
                    Console.WriteLine("Total available space: {0} bytes", driveInfo.TotalFreeSpace);
                    Console.WriteLine(" Total size of drive:  {0} bytes", driveInfo.TotalSize);
                }
            }
        }
    }
}
