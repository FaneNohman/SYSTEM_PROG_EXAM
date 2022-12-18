using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class DllCalc
    {
        const string dllUrl = @"C:\Users\User\source\repos\SystemPorgramExam\x64\Debug\MyDll.dll";

        [DllImport(dllUrl)]
        private static extern int my_sum(int a, int b);
        [DllImport(dllUrl)]
        private static extern int my_sub(int a, int b);
        [DllImport(dllUrl)]
        private static extern int my_mult(int a, int b);
        [DllImport(dllUrl)]
        private static extern int my_div(int a, int b);

        private static async Task Calc(int a, int b,char sign)
        {
            int result = 0;
            if(sign== '+') 
            { 
                result = my_sum(a, b);
            }
            else if (sign == '-')
            {
                result = my_sub(a, b);
            }else if (sign == '*')
            {
                result = my_mult(a, b);
            }
            else if (sign == '/'&&b!=0)
            {
                result = my_div(a, b);
            }
            else
            {
                Console.WriteLine("unforeseen error");
                return;
            }
            Console.WriteLine($"{a} {sign} {b} = {result}");
        }
        public static void CalcMenu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("<-------- SUB MENU dll import calc -------->");
                Console.WriteLine("input example: 1 2 +");
                Console.WriteLine("write 'exit' to back");
                Console.WriteLine("input your option:");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();
                switch (input)
                {
                    case "exit":
                        f = false;
                        break;
                    default:
                        var inputSplit = input.Split(' ');
                        if (inputSplit.Length == 3&& int.TryParse(inputSplit[0],out int a)&& int.TryParse(inputSplit[1],out int b))
                        {
                            Calc(a, b, char.Parse(inputSplit[2]));
                        }
                        else
                        {
                            Console.WriteLine("input error");
                        }
                        break;
                }
            }
        }
    }
}
