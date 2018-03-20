using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180130_staciakampis_ar_kvadratas_Uzd_nr_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma krastine: ");
            double krastine_a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite antra krastine: ");
            double krastine_b = Convert.ToDouble(Console.ReadLine());

            if (krastine_a == krastine_b)
            {
                Console.WriteLine("Galima sudaryti kvadrata :)" );
            }
            else if (krastine_a > krastine_b && krastine_b > krastine_a)
            {
                Console.WriteLine("Galima sudaryti staciakampi :)");
            }
            else if(krastine_a==0 || krastine_b == 0)
            {
                Console.WriteLine("Negalima sudaryte nei kvadrato nei staciakampio :(");
            }
            Console.ReadKey();
        }
    }
}
