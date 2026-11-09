using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cara3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hari = { "Monday", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Ahad" };

            foreach (string h in hari)
            {
                Console.WriteLine("Hari: " + h);
            }

        }
    }
}
