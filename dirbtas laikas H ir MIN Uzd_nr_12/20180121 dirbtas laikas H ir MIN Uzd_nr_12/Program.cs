using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_dirbtas_laikas_H_ir_MIN_Uzd_nr_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laka kada mokinys pradejo dirbti");
            TimeSpan valandos = TimeSpan.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite laka kada mokinys baige dirbti");
            TimeSpan minutes = TimeSpan.Parse(Console.ReadLine());

            TimeSpan skirtumas = valandos.Subtract(minutes);

            Console.WriteLine("Mokinys dirbo:   "+skirtumas.Duration());
            Console.ReadKey();
           



        }
    }
}
