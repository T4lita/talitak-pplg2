using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPenjumlahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Penjumlahan ===");

            int mangga, apel, hasil;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            apel = int.Parse(Console.ReadLine());

            // operasi penjumlahan denagan operator +
            hasil = mangga + apel;

            Console.WriteLine($"Hasil mangga + appel = {hasil}");

        }
    }
}
