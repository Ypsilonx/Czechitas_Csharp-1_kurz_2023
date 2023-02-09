using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocni_obdobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyber si roční období:");
            bool rocniObdobicheck = false;
            while (!rocniObdobicheck)
            {
                string rocniObdobi = Console.ReadLine();
                switch (rocniObdobi)
                {
                    case "jaro":
                        Console.WriteLine($"{rocniObdobi} je krásné protože všechno pučí a roste");
                        break;
                    case "leto":
                        Console.WriteLine($"{rocniObdobi} tak v tomto období jezdíme na dovolenou");
                        break;
                    case "podzim":
                        Console.WriteLine($"{rocniObdobi} začíná být chladno a větrno");
                        break;
                    case "zima":
                        Console.WriteLine($"{rocniObdobi} je pro zimní sporty a vše odpočívá a jsou Vánoce");
                        break;
                    default:
                        Console.WriteLine("Zadal si něco co není roční období. Zkus to znova:");
                        break;
                }
            }

        }
    }
}
