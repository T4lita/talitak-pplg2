using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progam_Konversi_SuhuIPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan suhu dalam Celcius: ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = (celcius * 9 / 5) + 32;
            double reamur = celcius * 4 / 5;

            Console.WriteLine("/n==== HASIL KONVERSI ====");
            Console.WriteLine($"Celcius : {celcius} °C");
            Console.WriteLine($"Fahrenheit : {fahrenheit} °F");
            Console.WriteLine($"Reaumur    : {reamur} °R");
        }
    }
}
