using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LepsiKalkulacka
{
    internal class Program
    {
        static double NumberKalk()
        {
            Console.WriteLine("Zadej číslo:");
            double number1;
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Nenapsal si číslo správně. Zkus to znova:");
            }
            return number1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, vítám tě v jednoduché kalkulačce.");
            Console.WriteLine("Zatím toho neumím tolik, ale budu se snažit ti pomoci.");
            Console.WriteLine("-------------------------------");
            List<double> vysledky = new List<double>();
            string rozhodnuti = "";
            do
            {
            Console.WriteLine("Začneme? (a/n)");
                rozhodnuti = Console.ReadLine();
                switch (rozhodnuti)
                {
                    case "a":
                        {
                            double zadaneCislo = NumberKalk();
                            vysledky.Add(zadaneCislo);
                            string pokracovani = "";
                            do
                            {
                                string pocetniOperace = "";
                                Console.WriteLine($"Máš číslo {vysledky.Last()} přidej matematický operátor: |+|-|*|/|");
                                pocetniOperace = Console.ReadLine();
                                switch (pocetniOperace)
                                {
                                    case "+":
                                        {
                                            double meziVypocet = vysledky.Last() + NumberKalk();
                                            vysledky.Add(meziVypocet);
                                        }
                                        break;
                                    case "-":
                                        {
                                            double meziVypocet = vysledky.Last() - NumberKalk();
                                            vysledky.Add(meziVypocet);
                                        }
                                        break;
                                    case "*":
                                        {
                                            double meziVypocet = vysledky.Last() * NumberKalk();
                                            vysledky.Add(meziVypocet);
                                        }
                                        break;
                                    case "/":
                                        {
                                            double delitel = NumberKalk();
                                            if (delitel == 0)
                                            {
                                                Console.WriteLine("Nelze dělit nulou! Zkus to znova");
                                                break;
                                            }
                                            double meziVypocet = vysledky.Last() / delitel;
                                            vysledky.Add(meziVypocet);
                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Takovou operaci ještě neznám, pokračuj v počítání.");
                                        }
                                        break;
                                }
                                Console.WriteLine("Chceš pokračovat v počítání? (a/n)");
                                pokracovani = Console.ReadLine();
                                if (pokracovani == "n")
                                {
                                    Console.WriteLine("-------------------------------");
                                    Console.WriteLine($"vysledek je {vysledky.Last()}.");
                                    Console.WriteLine("-------------------------------");
                                    vysledky.Clear();
                                }
                            } while (pokracovani == "a");
                        }
                        break;
                    case "n":
                        {
                            Console.WriteLine("Věřila jsem ve větší důvěru. Sbohem.");
                            Console.WriteLine("-------------------------------");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Zkus mi odpovědět ještě jednou:");
                        }
                        break;
                }
                Console.WriteLine("Chceš zadat nový příklad? (a/n)");
                rozhodnuti = Console.ReadLine();
            }
            while (rozhodnuti == "a");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("KONEC");
        }
    }
}
