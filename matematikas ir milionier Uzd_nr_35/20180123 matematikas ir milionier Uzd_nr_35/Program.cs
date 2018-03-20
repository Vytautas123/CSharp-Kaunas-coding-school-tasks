using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180123_matematikas_ir_milionier_Uzd_nr_35
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int matematikas = 2;
            int suma = 0;
            int milijonas = 100000;
            int dienos = 0;
            while (dienos++ < 31)
            {

               suma_m *= matematikas ;
                suma += milijonas;
                
                Console.WriteLine("Turtuolis gaus: " + suma+ "  Matematikas gaus:  " +suma_m);
            }
            Console.ReadKey();







        }
       
    }
}
