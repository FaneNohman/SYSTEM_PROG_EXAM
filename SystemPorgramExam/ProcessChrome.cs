using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class ProcessChrome
    {
        public static void ProcessMenu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("<-------- SUB MENU PROCESS -------->");
                Console.WriteLine("1. open new Chrome process;");
                Console.WriteLine("2. wirte all Chrome porcess;");
                Console.WriteLine("0. back.");
                Console.WriteLine("input your option:");
                int input = -1;
                if(int.TryParse(Console.ReadLine(), out int id))
                {
                    input = id;
                }
                Console.WriteLine();
                switch (input)
                {
                    case 0:
                        f= false;
                        break;
                    case 1:
                        OpenChrome();
                        break;
                    case 2:
                        GetChromeProcess();
                        break;
                    default:
                        Console.WriteLine("no such option");
                        break;

                }
            }
        }
        private static async Task GetChromeProcess()
        {
            Process[] Chrome = Process.GetProcessesByName("chrome");

            for (int i = 0; i < Chrome.Length; i++)
            {
                Console.WriteLine($"{i}: {Chrome[i].ProcessName}  {Chrome[i].Handle}");
            }
        }
        private static async Task OpenChrome()
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "https://github.com/");
        }
    }
}
