using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180122_paros_laikas_h_min_s_Uzd_nr_16
{
    class Program
    {
        static void Main(string[] args)
        {
           
            TimeSpan interval = new TimeSpan(10,43,2,5);
       

            Console.WriteLine("{0:N5} hours, as follows:", interval.TotalHours);
            Console.WriteLine("   Hours:        {0,3}",
                              interval.Days * 24 + interval.Hours);
            Console.WriteLine("   Minutes:      {0,3}", interval.Minutes);
            Console.WriteLine("   Seconds:      {0,3}", interval.Seconds);
            Console.WriteLine("   Milliseconds: {0,3}", interval.Milliseconds);
            Console.ReadKey();



        }
    }
}
