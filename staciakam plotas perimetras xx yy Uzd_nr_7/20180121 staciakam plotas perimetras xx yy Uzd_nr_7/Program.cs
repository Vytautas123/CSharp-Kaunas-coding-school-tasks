using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_staciakam_plotas_perimetras_xx_yy_Uzd_nr_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio virsutinio kairiojio tasko x kordinate");
            int xk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio virsutinio kairiojio tasko y kordinate");
            int yk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio apatinio kairiojio tasko x kordinate");
            int xa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio apatinio kairiojio tasko y kordinate");
            int ya = Convert.ToInt32(Console.ReadLine());

            int s = yk * xa;
            int p = 2 * (yk + xa);

            Console.WriteLine("Plotas:  "+s+"  Perimetras:  "+p);
            Console.ReadKey();

        }
    }
}
