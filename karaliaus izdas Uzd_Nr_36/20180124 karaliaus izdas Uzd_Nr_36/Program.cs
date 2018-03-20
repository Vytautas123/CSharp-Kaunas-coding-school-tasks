using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180124_karaliaus_izdas_Uzd_Nr_36
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite kiek auksiniu turite");
            int auksas = Convert.ToInt32(Console.ReadLine());
            int pinigai = 0;
            int suma = 0;
            int auksinis = 2;
           // int dienos = 0;

            while (suma <= 0)
            {

                
                pinigai += auksinis;
                suma = auksas - pinigai;  
                Console.WriteLine("Karalius atiduos: " + suma);

            }
            
            Console.ReadKey();

        }
    }
}
