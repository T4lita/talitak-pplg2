using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progam_Penjumlahan_DuaAngkaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== KALKULATOR PENJUMLAHAN ====");

            Console.Write("Masukkan angka pertama : ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua : ");
            int angka2 = int.Parse(Console.ReadLine());

            int hasil = angka1 + angka2;

            Console.WriteLine($"Hasil: {angka1} + {angka2} = {hasil}");
        }
    }
}
