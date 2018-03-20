using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180120_apskaiciuoja_palukanas_dviem_metam_Uzd_nr3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Prasome ivesti pinigu suma kokia norite padeti i banka lt");
            double litai = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("pasirinkite 1 arba 2 metus");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            

            if (skaicius == 1)
            {
                double procentai = litai * 0.02;
                double ats = procentai + litai;
                Console.WriteLine("Po metu jums bus ismoketa:   " +ats+ " lt");
                Console.WriteLine("Po metu jau turesite sukaupes  " + procentai +" lt palukanu");
            }

            else if(skaicius == 2)
            {
                double procentai2 = litai * 0.02+ litai;
                double procentai3 =procentai2* 0.02;
                double pal = procentai2 + procentai3;
                double ats2 = litai * 0.02;
                double ats3 = (litai+ats2) * 0.02;
                double ats4 = ats2 + ats3;
                Console.WriteLine("Po 2 metu jums bus ismoketa:   " + ats4 + " lt");
                Console.WriteLine("Po 1 metu jau turesite sukaupes  " + pal + " lt palukanu");
            }

            Console.ReadKey();
        }
    }
}
