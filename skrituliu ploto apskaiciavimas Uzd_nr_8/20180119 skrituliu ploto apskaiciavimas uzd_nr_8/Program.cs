using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180119_skrituliu_ploto_apskaiciavimas_uzd_nr_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite maziausio skritulio spinduli r");
            double r = Convert.ToDouble(Console.ReadLine());
            double s1 =  Math.Pow(r,2) * Math.PI;
            double s2 = Math.Pow((r* 2) ,2) * Math.PI;
            double s3 = Math.Pow((r * 4), 2) * Math.PI;
            Console.WriteLine("Maziausio skritulio plotas " + s1 + "  Antro skritulio plotas   "+ s2 +"  Trecio skritulio plotas   " +s3);
            Console.ReadKey();

        }
    }
}
