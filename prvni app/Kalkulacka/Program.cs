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
            double first;
            while (!double.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Nenapsal si číslo správně. Zkus to znova:");
            }
            Console.WriteLine("Zadej druhé číslo:");
            double second;
            while (!double.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Nenapsal si číslo správně. Zkus to znova:");
            }
            Console.WriteLine("Vyber operátor: (nabídka: +;-;*;/)");
            bool operatorCheck = false;
            while (!operatorCheck)
            {
                string operatorKalk = Console.ReadLine();
                if (operatorKalk == "+")
                {
                    Console.WriteLine("Vybral si operátor " + operatorKalk);
                    double vysledekKalk = first + second;
                    Console.WriteLine("Výsledek je " + vysledekKalk);
                    return;
                }
                else if (operatorKalk == "-")
                {
                    Console.WriteLine("Vybral si operátor " + operatorKalk);
                    double vysledekKalk = first - second;
                    Console.WriteLine("Výsledek je " + vysledekKalk);
                    return;
                }
                else if (operatorKalk == "*")
                {
                    Console.WriteLine("Vybral si operátor " + operatorKalk);
                    double vysledekKalk = first * second;
                    Console.WriteLine("Výsledek je " + vysledekKalk);
                    return;
                }
                else if (operatorKalk == "/")
                {
                    Console.WriteLine("Vybral si operátor " + operatorKalk);
                    if (second == 0)
                    {
                        Console.WriteLine("Nelze dělit nulou!");
                        return;
                    }
                    double vysledekKalk = first / second;
                    Console.WriteLine("Výsledek je " + vysledekKalk);
                    return;
                }
                else
                {
                    string vysledekKalk = "Zadal si špatný operátor pro výpočet! Zkus to znovu:";
                    Console.WriteLine(vysledekKalk);
                }
            }
        }
    }
}
