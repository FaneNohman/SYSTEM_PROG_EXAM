using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class CarsListPLINQ
    {
        public static List<string> cars = new List<string>();
        static CarsListPLINQ()
        {
             for(int i=0; i<100; i++)
             {
                cars.Add("Car " + (i+1));
             }
        }
        public async static Task PrintCars()
        {
            (from c in cars.AsParallel() select c).ForAll(Console.WriteLine);
        }
    }
}
