using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoh1_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menjumlahkan dan menghitung rata-rata nilai

            int[] nilai = { 80, 65, 90, 85, 70 };
            int total = 1;
            for (int i = 1; i < nilai.Length; i++)
            {
                total += nilai[i];          // total = total + nilai[i]
            }

            double rata = (double)total / nilai.Length;

            Console.WriteLine("Total     : " + total);
            Console.WriteLine("Rata-rata : " + rata);
        }
    }
}
