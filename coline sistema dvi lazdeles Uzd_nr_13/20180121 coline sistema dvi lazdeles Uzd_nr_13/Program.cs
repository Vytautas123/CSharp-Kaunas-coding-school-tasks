using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_coline_sistema_dvi_lazdeles_Uzd_nr_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double colis = 25.4;
            double peda = 12;
            double jardas = 3;

            Console.WriteLine("Iveskite pirmos lazedles ilgi coliais");
            double pirma = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite antros lazedles ilgi coliais");
            double antra = Convert.ToDouble(Console.ReadLine());

            double abi = pirma + antra;

            double abi_mm = abi / colis;
            double abi_peda = abi_mm / peda;
            double abi_jardas = abi_peda / jardas;

            Console.WriteLine("Coliu:  " + abi_mm + " Pedu : " + abi_peda + " Jardu:  " + abi_jardas);

            Console.ReadKey();
        }
    }
}
