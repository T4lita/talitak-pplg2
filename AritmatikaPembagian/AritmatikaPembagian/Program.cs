using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPembagian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Pembagian ====");

            int melon, orang, Hasill = 0;

            Console.Write("Jumlah melon = ");

            melon = int.Parse(Console.ReadLine());
            Console.Write("Jumlah orang = ");
            orang = int.Parse(Console.ReadLine());

            Hasill = melon / orang;

            Console.WriteLine($"Hasil melon / orang = {Hasill}");
        }
    }
}
