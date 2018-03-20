using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180121_seimos_metu_biudzeto_skaiciuokle_Uzd_nr_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskitei pinigu suma kiek seima gauna pinu per viena menesi");
            double menesis = Convert.ToDouble(Console.ReadLine());

            double metai = menesis * 12;

            double mokestciai = metai * 0.05;
            double maistas = metai * 0.5;
            double rubai = metai * 0.3;

            double pramogos = metai - mokestciai - maistas - rubai;

            Console.WriteLine("Mokesciai:   "+ mokestciai+"  Maistas:   " + maistas+"  Rubai:   " + rubai + "  Pramogoms:  " +pramogos);
            Console.ReadKey();
        }
    }
}
