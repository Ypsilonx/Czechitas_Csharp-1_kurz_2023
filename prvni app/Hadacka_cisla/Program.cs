using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadacka_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj vítám tě u hádání čísla mezi 1-100.");
            string novaHra = "";
            do
            {
                //Console.WriteLine("Chceš vygenerovat hádané číslo? (A/N)");
                //string rozhodnutiHrat = "";
                //while (rozhodnutiHrat != "A" && rozhodnutiHrat != "N")
                //{
                    //rozhodnutiHrat = Console.ReadLine();
                    //if (rozhodnutiHrat == "N")
                    //{
                        //Console.WriteLine("Škoda, mohli jsme si zahrát. Sbohem.");
                        //return;
                    //}
                    //else if (rozhodnutiHrat == "A")
                    //{
                        Random rnd = new Random();
                        int randomNumber = rnd.Next(1, 101);
                        Console.WriteLine("Mám číslo mezi 1 a 100. Teď budeš hádat a máš 5 pokusů.");
                        Console.WriteLine("Jediná nápověda bude jestli si s tipem vysoko nebo nízko.");
                        Console.WriteLine("Hádej číslo:");
                        for (int pokus = 1; pokus < 6; pokus++)
                        {
                            int tipCislo;
                            while (!int.TryParse(Console.ReadLine(), out tipCislo) || ((tipCislo < 1) || (tipCislo > 100)))
                            {
                                Console.WriteLine("Nezadal číslo v rozmezí 1-100:");
                            }
                            if (tipCislo < randomNumber)
                            {
                                Console.WriteLine("Tip je nízko.");
                                //Console.WriteLine(randomNumber);
                            }
                            else if (tipCislo > randomNumber)
                            {
                                Console.WriteLine("Tip je vysoko.");
                                //Console.WriteLine(randomNumber);
                            }
                            else if (tipCislo == randomNumber)
                            {
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine($"Trefa {tipCislo} odpovídá hádanému číslu.");
                                Console.WriteLine($"Na uhodnutí ti stačil {pokus}. pokus.");
                                Console.WriteLine("-------------------------------");
                                break;
                            }
                            Console.WriteLine($"Pokus číslo {pokus}.");
                            if (pokus == 5 && tipCislo != randomNumber)
                            {
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine($"Nepovedlo se ti uhodnout náhodné číslo, které bylo {randomNumber}");
                                Console.WriteLine("-------------------------------");
                            }

                        }
                    //}
                    //else
                    //{
                        //Console.WriteLine("Tvá odpověď neodpovídá Ano nebo Ne.");
                    //}
                //}
            Console.WriteLine("Chceš hrát znovu? (A/N)");
                string znovu = "";
                while (znovu != "A" && znovu != "N")
                {
                    znovu = Console.ReadLine();
                    if (znovu == "N")
                    {
                        Console.WriteLine("Děkuji za hru a měj se krásně.");
                        return;
                    }
                    else if (znovu == "A")
                    {
                        novaHra = "A";
                    }
                    else
                    {
                        Console.WriteLine("Tak 'Ano, chceš hrát' nebo 'Ne, nechceš?'.");
                    }
                }
            }
            while (novaHra == "A");
        }
    }
}
