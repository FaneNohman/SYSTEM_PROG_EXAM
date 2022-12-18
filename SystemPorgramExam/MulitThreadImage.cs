using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class MulitThreadImage
    {
        private static object _lock= new object();
        public static void ImageMenu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("<-------- SUB MENU MultiThread Image -------->");
                Console.WriteLine("1. open Image through new thread;");
                Console.WriteLine("0. back.");
                Console.WriteLine("input your option:");

                Console.WriteLine();
                switch (Console.ReadLine())
                {
                    case "0":
                        f = false;
                        break;
                    case "1":
                         new Thread(ShowImage).Start();
                        break;
                    default:
                        Console.WriteLine("no such option");
                        break;
                }
            }
        }
        private static void ShowImage()
        {
            //sync through lock
            lock(_lock){
                Process.Start(new ProcessStartInfo(@"C:\Users\User\source\repos\SystemPorgramExam\8f3.jpg") { UseShellExecute = true });
                Thread.Sleep(10000);
            }
        }
    }
}
