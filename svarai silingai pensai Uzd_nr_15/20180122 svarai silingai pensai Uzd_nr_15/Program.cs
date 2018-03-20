using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180122_svarai_silingai_pensai_Uzd_nr_15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pencas = 1;
            double silingas = pencas *12;
            double svraras = silingas * 20;


            Console.WriteLine("Iveskite kiek pinigineje turite svaru:");
            double svaras_p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite kiek pinigineje turite silingu:");
            double silingu_p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite kiek pinigineje turite svaru:");
            double pensu_p = Convert.ToDouble(Console.ReadLine());

            
            double mazi = pensu_p+1;
            double vidutiniai = silingu_p + (mazi/12);
            double dideli = svaras_p + (vidutiniai / 20);


            
                Console.WriteLine("Pridejus viena pens turesite pinigu Pensu:  "  +Math.Round(mazi) + "  Silingu  " + Math.Round(vidutiniai)+ "  Svaru:    " + Math.Round(dideli));
            
                Console.WriteLine();

                

            Console.ReadKey();

        }
    }
}
