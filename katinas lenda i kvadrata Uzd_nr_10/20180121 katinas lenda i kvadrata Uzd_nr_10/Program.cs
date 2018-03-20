using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_katinas_lenda_i_kvadrata_Uzd_nr_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite katino galvos spinduli");
            double katin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite kvadrato krastines ilgis");
            double krast = Convert.ToDouble(Console.ReadLine());

            double galva = katin * 2;

            if (galva > krast)
            {
                Console.WriteLine("Katinas pralysti negali");
            }

            else if (galva < krast) 
            {
                Console.WriteLine("Katinas pralysti gali" );
            }
            else if (galva == krast)
            {
                Console.WriteLine("Katinas pralysti gali");
            }

            Console.ReadKey();
        }
    }
}
