using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180123_pazimiu_vidurki_while_Uzd_nr_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int kiekis = 0;
            int pazymis = 0;

            do
            {
                Console.WriteLine("Iveskite pazymi jei pabaiga iveskite 0");

                pazymis = Convert.ToInt32(Console.ReadLine());
                if (pazymis != 0)
                {
                    suma += pazymis;
                    kiekis++;
                }

            } while (pazymis != 0); 
            {
                double vidurkis = (double)suma / kiekis;
                Console.WriteLine("Viduurkis yra: " + vidurkis);
                Console.ReadKey();
            }
        }
    }
}
