using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180120_kiek_min_ir_s_prabego_po_vidurnakcio_Uzd_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek dabar yra valandu");
            int val = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite kiek dabar yra minuciu");
            int min = Convert.ToInt32(Console.ReadLine());

            int m = val * 60 + min;
            int s = m * 60;

            Console.WriteLine("m= " +m + "  s= "+s);
            Console.ReadLine();
        }
    }
}
