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
        }
    }
}
