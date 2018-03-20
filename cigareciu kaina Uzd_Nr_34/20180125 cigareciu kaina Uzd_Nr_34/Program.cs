using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180125_cigareciu_kaina_Uzd_Nr_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double cigarete = 0.17;
            double diena = 5;
            double metai = 0;
            double norma = 1;
            double naujos = 0;


            Console.WriteLine("Vienos cigaretes kaina 0.17\nSiu metu per diena suruko 5 cigaretes\nIveskite kiek padauges surukomu cigareciu: ");
            double pasirinkimas = Convert.ToDouble(Console.ReadLine());
            
            
            
                metai = cigarete * diena * 356;

                norma = diena + pasirinkimas;

                naujos = cigarete * norma * 356;
               
           
            
            
            Console.WriteLine("Pirmais metais isleis: "+ metai + " \nSurukomu cigareciu kiekis padides  " +norma +"\nSekanciais metais isleis:  " +naujos);
            Console.ReadKey();
        }
    }
}
