using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaSisabagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Sisa Bagi ===");

            int Durian, Orang, Haasil = 0;

            Console.Write("Jumlah Durian = ");
            Durian = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Orang = ");
            Orang = int.Parse(Console.ReadLine());

            Haasil = Durian % Orang;

            Console.WriteLine($"Hasil Durian % Orang = {Haasil}");
        }
    }
}
