using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class MyRegistry
    {
        private static async Task DeleteValue()
        {
            Console.WriteLine();
            Console.WriteLine("input path and name.");
            Console.WriteLine("Example: someKey\\neededKey");
            string path = Console.ReadLine();
            if (path == "")
            {
                Console.WriteLine("input error");
                return;
            }
            Console.WriteLine("input value name");
            string key = Console.ReadLine();
            if (key == "")
            {
                Console.WriteLine("input error");
                return;
            }
            using (RegistryKey my = Registry.CurrentUser.OpenSubKey(path, true))
            {
                if (my != null)
                {
                    my.DeleteValue(key);
                }
            }

        }
        private static async Task DeleteKey()
        {
            Console.WriteLine();
            Console.WriteLine("input path and name.");
            Console.WriteLine("Example: someKey\\keyForDeletion");
            string path = Console.ReadLine();
            if (path == "")
            {
                Console.WriteLine("input error");
                return;
            }
            Registry.CurrentUser.DeleteSubKey(path);
        }
        private static async Task AddNewSub()
        {
            Console.WriteLine();
            Console.WriteLine("input path and name.");
            Console.WriteLine("Example: oldkey\\newKey");
            string path = Console.ReadLine();
            if (path == "")
            {
                Console.WriteLine("input error");
                return;
            }
            Registry.CurrentUser.CreateSubKey(path).Close();
        }
        private static async Task AddValue()
        {
            Console.WriteLine();
            Console.WriteLine("input path and name.");
            Console.WriteLine("Example: someKey\\NeededKey");
            string path = Console.ReadLine();
            if (path == "")
            {
                Console.WriteLine("input error");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("input value name");
            string key = Console.ReadLine();
            Console.WriteLine("input new value");
            string value = Console.ReadLine();
            if (key.Equals("")|| value.Equals(""))
            {
                Console.WriteLine("input error");
                return;
            }
            using(RegistryKey my = Registry.CurrentUser.OpenSubKey(path, true))
            {
                if(my != null) 
                {
                    my.SetValue(key, value);
                }
            }
        }
        public static async Task RegistryMenu()
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("<-------- SUB MENU Registry(HKEY_CURRENT_USER) -------->");
                Console.WriteLine("1. Create new key;");
                Console.WriteLine("2. add value to key;");
                Console.WriteLine("3. delete key;");
                Console.WriteLine("4. delete value;");
                Console.WriteLine("0. exit.");
                Console.WriteLine("input your option:");

                Console.WriteLine();
                switch (Console.ReadLine())
                {
                    case "0":
                        f = false;
                        break;
                    case "1":
                        AddNewSub();
                        break;
                    case "2":
                        AddValue();
                        break;
                    case "3":
                        DeleteKey();
                        break;
                    case "4":
                        DeleteValue();
                        break;
                    default:
                        Console.WriteLine("no such option");
                        break;

                }
            }
        }
    }
}
