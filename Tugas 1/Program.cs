using System;

namespace Helloworld
{
//zain m haqqo
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Deklarasi
            const int a = 5;
            const int b = 4;
            const int c = 7;
            int tambah = a + b + c;
            int kali = a * b * c;
            int kurang = a - b - c;
            int bagi = a / b / c;

            Console.WriteLine("anda adalah agen rahasia yang bertugas medapatkan data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak di ketahui...");
            Console.WriteLine("- password terdiri dari 4 angka");
            Console.WriteLine("- jika ditambahkan hasilnya " + tambah);
            Console.WriteLine("- jika dikalikan hasilnya " + kali);
            Console.WriteLine("- jika dikurangi hasilnya " + kurang);
            Console.WriteLine("- jika dibagi hasilnya " + bagi);

            Console.WriteLine("");
            Console.Write("enter code : ");
        }
    }
}
