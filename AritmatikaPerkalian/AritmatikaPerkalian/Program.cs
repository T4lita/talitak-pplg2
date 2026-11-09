using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPerkalian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Perkalian ===");

            int Mangga, Appel, Hasil = 0;

            Console.Write("mangga = ");
            Mangga = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            Appel = int.Parse(Console.ReadLine());

            Hasil = Mangga * Appel;

            Console.WriteLine($"Hasil Mangga * Appel = {Hasil}");
        }
    }
}
