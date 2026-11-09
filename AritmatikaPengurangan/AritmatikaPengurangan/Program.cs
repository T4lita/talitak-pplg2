using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPengurangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Pengurangan ===");

            int manggaa, appel, hasill = 0;

            Console.Write("manggaa = ");
            manggaa = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            appel = int.Parse(Console.ReadLine());

            hasill = manggaa - appel;

            Console.WriteLine($"Hasil manggaa - appel = {hasill}");
        }
    }
}
