using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bawaan_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 56, 78, 90, 2, 34 };

            Array.Sort(angka);
            Console.WriteLine("Terurut : " + string.Join(",", angka));

            Array.Reverse(angka);
            Console.WriteLine("Dibalik : " + string.Join(", ", angka));

            Console.WriteLine("Indeks 2 : " + Array.IndexOf(angka, 2));
            Console.WriteLine("Jumlah   : " + angka.Sum());
            Console.WriteLine("Terbesar : " + angka.Max());
        }
    }
}
