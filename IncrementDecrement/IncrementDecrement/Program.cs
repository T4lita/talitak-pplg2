using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Increment Decrement ===");

            int pepaya = 3;
            int pisang = 4;

            Console.WriteLine($"pepaya = {pepaya}");
            Console.WriteLine($"pisang = {pepaya}");

            // Increment
            pepaya++;
            ++pisang;

            Console.WriteLine($"pepaya+1 = {pepaya}");
            Console.WriteLine($"pisang+1 = {pisang}");

            // Decrement
            pepaya--;
            --pisang;

            Console.WriteLine($"pepaya-1 = {pepaya}");
            Console.WriteLine($"pisang-1 = {pisang}");
        }
    }
}
