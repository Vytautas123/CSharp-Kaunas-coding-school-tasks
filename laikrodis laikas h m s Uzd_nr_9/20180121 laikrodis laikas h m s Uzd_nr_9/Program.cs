using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20180121_laikrodis_laikas_h_m_s_Uzd_nr_9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime laikas = DateTime.Now;
            // Console.WriteLine(laikas.ToString());   pilna data 

            // Console.WriteLine(laikas.ToShortDateString()); data be laiko

            //Console.WriteLine(laikas.ToShortTimeString()); data paliekama tik laikas

            //Console.WriteLine(laikas.AddHours(3).ToShortTimeString());  prie dabartinio sutrumpinto laiko pridedam 3 val
            
            Console.WriteLine(laikas.ToLongTimeString());
            
            

            Console.WriteLine(laikas.AddSeconds(1).ToLongTimeString());
            Console.ReadKey();
        }
        
    }
}
