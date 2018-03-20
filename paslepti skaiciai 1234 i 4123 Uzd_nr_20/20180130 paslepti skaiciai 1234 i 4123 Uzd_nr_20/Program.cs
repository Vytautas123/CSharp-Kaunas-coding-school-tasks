using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keturzenlis_skaicius_1234_i_4321
{
    class Program
    {

        static void Main(string[] args)
        {
            int vienetai = 0;
            int desimtis = 0;
            int simtai = 0;
            int tukstanciai = 0;

            Console.WriteLine("Iveskite keturzenkli skaicius: ");
            int keturi = Convert.ToInt32(Console.ReadLine());


            

            vienetai = (keturi % 100) % 10;
            desimtis = (keturi % 100) / 10;
            simtai = (keturi / 100) % 10;
            tukstanciai = ((keturi / 100) % 100) / 10;
            Console.WriteLine(vienetai  + "" + tukstanciai + "" +simtai+ "" + desimtis);
            Console.ReadKey();
    

        }
    }
}
