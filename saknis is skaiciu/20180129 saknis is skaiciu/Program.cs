using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180129_saknis_is_skaiciu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=-5; i <= 5; i++)
            {
                double y = Math.Sqrt(i * i + 3 * i + 5);
                Console.WriteLine("{0:0.00}",y); // "{0:0.00}" suapvalina skaicius 

            }
            Console.ReadKey();
        }
    }
}
