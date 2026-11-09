using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progam_biodata_sederhanaIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KESUKAAN ===");

            Console.WriteLine("Makanan             : ");
            string makanan = Console.ReadLine();

            Console.WriteLine("Warna            : ");
            string warna = Console.ReadLine();

            Console.WriteLine("Angka             : ");
            int angka = int.Parse(Console.ReadLine());

            Console.Write("Buah: ");
            string buah = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("=== KESUKAAN ===");
            Console.WriteLine($"Makanan : {makanan}");
            Console.WriteLine($"Warna : {warna}");
            Console.WriteLine($"Angka : {angka}");
            Console.WriteLine($"Buah : {buah}");

        }
    }
}
