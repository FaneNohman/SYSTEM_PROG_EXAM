using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class MyAssembly
    {
       public static async Task WriteAssembly()
       {
            Console.WriteLine("<--------- Assembly info --------->");
            Console.WriteLine();
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
            }

            Console.ReadLine();
        }
    }
}
