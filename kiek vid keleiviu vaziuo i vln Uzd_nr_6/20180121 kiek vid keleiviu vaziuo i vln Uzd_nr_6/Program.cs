using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_kiek_vid_keleiviu_vaziuo_i_vln_Uzd_nr_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite traukinio keleivių skaičių");
            int kel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite traukinio keleivių skaičių vykstancių ne Vilnių");
            int vln = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite traukinio vagonų skaičių");
            int vag = Convert.ToInt32(Console.ReadLine());

            int vid = kel * vag / vln;

            Console.WriteLine("Vidutiniškai į Vilnių važiuja:  "+vid);
            Console.ReadKey();

        }
    }
}
