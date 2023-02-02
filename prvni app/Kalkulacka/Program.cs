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
            float first = float.Parse(prvni_cislo);
            Console.WriteLine("Zadej druhé číslo:");
            string druhe_cislo = Console.ReadLine();
            float second = float.Parse(druhe_cislo);
            Console.WriteLine("Vyber operator: (nabídka: +;-;*;/)");
            string operator_kalk = Console.ReadLine();
            if (operator_kalk == "+")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                float vysledek_kalk = first + second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else if (operator_kalk == "-")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                float vysledek_kalk = first - second;
                Console.WriteLine("Výsledek je " + vysledek_kalk);
            }
            else if (operator_kalk == "*")
            {
                Console.WriteLine("Vybral si operátor " + operator_kalk);
                float vysledek_kalk = first * second;
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
                float vysledek_kalk = first / second;
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
