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
                if (rocniObdobi == "jaro")
                {
                    Console.WriteLine($"{rocniObdobi} je krásné protože všechno pučí a roste");
                    return;
                }
                else if (rocniObdobi == "leto")
                {
                    Console.WriteLine($"{rocniObdobi} tak v tomto období jezdíme na dovolenou");
                    return;
                }
                else if (rocniObdobi == "podzim")
                {
                    Console.WriteLine($"{rocniObdobi} začíná být chladno a větrno");
                    return;
                }
                else if (rocniObdobi == "zima")
                {
                    Console.WriteLine($"{rocniObdobi} je pro zimní sporty a vše odpočívá a jsou Vánoce");
                    return;
                }
                else
                {
                    Console.WriteLine("Zadal si něco co není roční období. Zkus to znova:");
                }
            }
        }
    }
}
