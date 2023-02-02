using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Ahoj vítám tě v jednoduché kalkulačce.");
            Console.WriteLine("Zadej první číslo:");
            string prvni_cislo = Console.ReadLine();
            double first;
            bool napsalCislo1 = double.TryParse(prvni_cislo, out first);
            if(napsalCislo1)
            {
                Console.WriteLine("Je to cajk.");
            }
            else
            {
                Console.WriteLine("Není to číslo kámo.");
                return;
            }
            Console.WriteLine("Zadej druhé číslo:");
            string druhe_cislo = Console.ReadLine();
            double second;
            bool napsalCislo2 = double.TryParse(druhe_cislo, out second);
            if(napsalCislo2)
            {
                Console.WriteLine("Je to cajk.");
            }
            else
            {
                Console.WriteLine("Není to číslo kámo.");
                return;
            }
            Console.WriteLine("Vyber operator: (nabídka: +;-;*;/)");
            string operator_kalk = Console.ReadLine();
            if (operator_kalk == "+")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                double vysledek_kalk = first + second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else if (operator_kalk == "-")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                double vysledek_kalk = first - second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else if (operator_kalk == "*")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                double vysledek_kalk = first * second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else if (operator_kalk == "/")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                if (second == 0)
                {
                    Console.WriteLine("Nelze dělit nulou!");
                    Environment.Exit(0);
                }
                double vysledek_kalk = first / second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else
            {
                string vysledek_kalk = "Zadal si špatný operátor pro výpočet!";
                Console.WriteLine(vysledek_kalk);
            }

        }
    }
}
