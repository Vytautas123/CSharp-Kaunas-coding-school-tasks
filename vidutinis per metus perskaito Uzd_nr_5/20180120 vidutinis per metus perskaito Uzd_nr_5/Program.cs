using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180120_vidutinis_per_metus_perskaito_Uzd_nr_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite vidutiniškai per mėnesi perskaititų knygų skaičių");
            int persk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vidutiniškai per metus apsilankisiu bibliotekoje skaičių");
            int aspi = Convert.ToInt32(Console.ReadLine());

            double x =12* persk  / aspi;
            Console.WriteLine("persk:  " + x);
            Console.ReadLine();
        }
    }
}
