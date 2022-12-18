using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using SystemPorgramExam;

namespace SystemProgramExam
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            MainMenu();
            
        }

        private static async void MainMenu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("<-------- MAIN MENU -------->");
                Console.WriteLine("1. Dll import;");
                Console.WriteLine("2. Process;");
                Console.WriteLine("3. List of Assembly;");
                Console.WriteLine("4. Registry;");
                Console.WriteLine("5. Show image;");
                Console.WriteLine("6. List of Cars;");
                Console.WriteLine("7. Print 'Hi itstep';");
                Console.WriteLine("0. exit.");
                Console.WriteLine("input your option:");
              
                Console.WriteLine();
                switch (Console.ReadLine())
                {
                    case "0":
                        f = false;
                        break;
                    case "1":
                        DllCalc.CalcMenu();
                        break;
                    case "2":
                        ProcessChrome.ProcessMenu();
                        break;
                    case "3":
                        //sync assembly list
                       await MyAssembly.WriteAssembly();
                        break;
                    case "4":
                        MyRegistry.RegistryMenu();
                        break;
                    case "5":
                        MulitThreadImage.ImageMenu();
                        break;
                    case "6":
                        //sync plinq
                        await CarsListPLINQ.PrintCars();
                        break;
                    case "7":
                        ParallelHi.SayHello();
                        break;
                    default:
                        Console.WriteLine("no such option");
                        break;

                }
            }
        }
        
    }
}