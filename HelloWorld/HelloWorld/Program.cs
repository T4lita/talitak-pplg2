using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Projek 1
            // Praktik 1
            // Menampilkan pesan "Hello World!" di layar konsol
            // Dibuat oleh Talita
            // Kelas X PPLG 2
            Console.WriteLine("Hello World");
            Console.WriteLine("Nama = Talita Anjelika");
            Console.WriteLine("Kelas = X PPLG 2");
            Console.WriteLine("Jurusan = PPLG");

            //Praktik 2
            // Nama : Talita Anjelika
            // Kelas : X PPLG 2
            // Perberdaan Write dan WriteLine
            Console.Write("Hello");
            Console.WriteLine("Pak Mukthi");
            Console.WriteLine("Pak, gini bener ga pak?");
            Console.WriteLine("Bingung saya pak");
            Console.WriteLine("Saya mengerjakan sebisa saya ya pak");

            //Praktik 3
            // Nama : Talita
            // Kelas :X PPLG 2
            // Membuat dan memanggil variabel
            int umur = 14;
            string nama = "Talita";
            Console.WriteLine("Nama saya" + nama + " Umur saya " + umur);

            // Praktik 4
            // Nama : Talita
            // Kelas : X PPLG 2
            // Input variabel dari user
            Console.Write("Masukkan nama");
            string Nama = Console.ReadLine();
            Console.Write("Masukkan umur : ");
            int Umur = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=== DATA SISWA ===");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Umur : " + umur + " tahun");

            // Praktik 5
            // Nama : Talita 
            // Kelas : X PPLG 2
            // Progam Biodata Sederhana
            Console.Write("Nama : ");
            string NAMA = Console.ReadLine();

            Console.Write("Kelas : ");
            string KELAS = Console.ReadLine();

            Console.Write("Jurusan");
            string JURUSAN = Console.ReadLine();

            Console.Write("Umur : ");
            int UMUR = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("==== Biodata Siswa ====");
            Console.WriteLine("Nama : " + NAMA);
            Console.WriteLine("Kelas : " + KELAS);
            Console.WriteLine("Jurusan : " + JURUSAN);
            Console.WriteLine("Umur : " + UMUR);
        }
    }
}