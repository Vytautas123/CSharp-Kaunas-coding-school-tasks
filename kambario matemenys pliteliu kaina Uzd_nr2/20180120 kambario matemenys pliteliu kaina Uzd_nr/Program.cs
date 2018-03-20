using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180120_kambario_matemenys_pliteliu_kaina_Uzd_nr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kambario ilgi");
            int ilgis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite kambario ploti");
            int plotis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite kvadrato kaina ");
            int kainai = Convert.ToInt32(Console.ReadLine());

            double sum = ilgis * plotis * kainai *0.5;

            Console.WriteLine("Viso reikes moketi: "+sum);
            Console.ReadKey();
        }
    }
}
