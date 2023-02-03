using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool spis = false;
            //int pocetOvecek = 0;
            //while (!spis)
            //{
            //    pocetOvecek++;
            //    Console.WriteLine($"{pocetOvecek} ve stádě.");
            //    Console.WriteLine("Spí? A/N");
            //    string odpoved = Console.ReadLine();
            //    if (odpoved == "A")
            //    {
            //        spis = true;
            //    }
            //}


            Console.WriteLine("Zadej mi svůj rok narození:");
            int rok;
            while (!int.TryParse(Console.ReadLine(), out rok) || rok < 1900 || rok > DateTime.Now.Year)
            {
                Console.WriteLine("Nenapsal si rok správně. Zkus to znova:");
            }
            Console.WriteLine("Napsal si rok " + rok);
            int aktualRok = DateTime.Now.Year;
            Console.WriteLine("Máš " + (aktualRok - rok) + " let.");

            //int rok = DateTime.Now.Year;
            //string rokNar = Console.ReadLine();
            //int mujRok = int.Parse(rokNar);
            //for (int i = mujRok; i < rok; i++)
            //{
            //    Console.WriteLine(i + " -> Neumřel jsem.");
            //}

            //for (int i = 0; i < 21; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 21; i = i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Zadej číslo od:");
            //int prvniCislo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Zadej číslo do:");
            //int druheCislo = int.Parse(Console.ReadLine());
            //for (int i = prvniCislo; prvniCislo < druheCislo; prvniCislo++)
            //{
            //    Console.WriteLine(prvniCislo);
            //}
        }
    }
}
