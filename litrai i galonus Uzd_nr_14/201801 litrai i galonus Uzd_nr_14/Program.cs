using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_litrai_i_galonus_Uzd_nr_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double g = 4.54069;
            double b = 8;
            

            Console.WriteLine("Iveskite pirma skyscio kieki litrais");
            double pirma = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite antros skyscio kieki litrais");
            double antra = Convert.ToDouble(Console.ReadLine());

            double abi = pirma + antra;

            double galonas  = abi / g;
            double busetas = galonas / b;
            
            double litrai = (galonas / g) +(busetas / b / g );
            



            Console.WriteLine("Galonu:  " + galonas + " Busetu : " + busetas + " Litrai:  "+litrai );

            Console.ReadKey();
        }
    }
}
