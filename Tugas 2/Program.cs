/*
ZAIN M HAQQO
2207112580
*/

using System;
namespace DasPro
{
    class Program
    {
        //main method
         static void Main(string[] args)
        {
            TheGameStart = true;
            Intro();
            Console.WriteLine("Silahkan Enter");
            Console.ReadLine();
            Console.Clear();
            while(TheGameStart)
            {     
                if(chance >0)
                {
                    if(TheGameStart==true)
                    {
                        PlayGame();
                    }
                    if (level ==6)
                    {
                        Win();
                    }
                    Console.Clear();
                }
                else
                {
                    ShowEnd();
                    Console.Clear();
                }
            }
            Console.WriteLine("Tekan enter untuk lanjut");
            Console.ReadLine();
        }    

        //Deklarasi variabel
        static Random rnd = new Random();
        static int level =1;
        static int kodeA ;
        static int kodeB ;
        static int kodeC ;
        static int hasilTambah;
        static int hasilKali;
        static int hasilTambah2;
        static int hasilKali2;
        static int hasilTambah3;
        static int hasilKali3;
        static int hasilTambah4;
        static int hasilKali4;
        static int chance = 3;
        static int hasilA =0 ;
        static int hasilB =0 ;
        static int hasilC =0 ;
        static bool TheGameStart;
        static void Init()
        {
            //Operasi Aritmatika
            kodeA = rnd.Next(0, 2*level);
            kodeB = rnd.Next(0, 3*level);
            kodeC = rnd.Next(0, 4*level);
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;
            hasilTambah2 = kodeA+kodeB;
            hasilKali2 = kodeA*kodeB;
            hasilTambah3 = kodeA+kodeC;
            hasilKali3 = kodeA*kodeC;
            hasilTambah4 = kodeB+kodeC;
            hasilKali4 = kodeB*kodeC;
        }    

        static void Intro()
        {
            //Begin of Game
            Console.WriteLine(" TEBAK ANGKA ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ANDA ADALAH AGEN RAHASIA YANG BERTUGAS MENDAPATKAN DATA DARI SERVER");
            Console.WriteLine("AKSES KE SERVER MEMBUTUHKAN PASSWORD YANG TIDAK DIKETAHUI");
            Console.WriteLine("PASSWORD MEMILIKI 3 ANGKA");
            Console.WriteLine("UNTUK MASUK KE SERVER ANDA HARUS MENEBAK ANGKA BERIKUT");
        }

        static void PlayGame()
        {
            Init();
            //Inti TheGame
            Console.WriteLine("Kode memiliki 3 angka");
            Console.WriteLine("Jika semua kode ditambahkan hasilnya"+hasilTambah);
            Console.WriteLine("Jika semua kode dikalikan hasilnya"+hasilKali);
            Console.WriteLine("Jika kode 1 dan 2 ditambahkan hasilnya"+hasilTambah2);
            Console.WriteLine("Jika kode 1 dan 2 dikalikan hasilnya"+hasilKali2);
            Console.WriteLine("Jika kode 1 dan 3 ditambahkan hasilnya"+hasilTambah3);
            Console.WriteLine("Jika kode 1 dan 3 dikalikan hasilnya"+hasilKali3);
            Console.WriteLine("Jika kode 2 dan 3 ditambahkan hasilnya"+hasilTambah4);
            Console.WriteLine("Jika kode 2 dan 3 dikalikan hasilnya"+hasilKali4);
            Console.Write("> Kode pertama :");
            hasilA = Convert.ToInt32 (Console.ReadLine());
            Console.Write("> Kode kedua : ");
            hasilB = Convert.ToInt32 (Console.ReadLine());
            Console.Write("> Kode ketiga : ");
            hasilC = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Tebakan anda "+hasilA+" "+hasilB+" "+hasilC+" ?");

            if(hasilA == kodeA && hasilB == kodeB && hasilC == kodeC)
            {
                Console.WriteLine("tebakan anda benar");
                level ++;
                Console.WriteLine("");
                if(level <6);
                {
                    Console.WriteLine("Naik level"+level);
                }
                Console.WriteLine("Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                chance-- ;
                Console.WriteLine("");
                Console.WriteLine("Tebakan anda salah...");
                Console.WriteLine("Sisa percobaan:"+chance);
                Console.WriteLine("Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
        }        

        static void ShowEnd()
        {
            Console.Clear();
            if(chance ==0)
            {
                Console.WriteLine("KODE SALAH");
                Console.WriteLine("coba lagi dilain waktu");
                Console.WriteLine("Tekan Enter untuk keluar");
                Console.ReadLine();
                Console.Clear();
                TheGameStart = false;
            }     
        }

        static void Win()
        {
            Console.WriteLine("KODE ANDA BENAR");
            Console.WriteLine("selamat tebakan anda benar!");
            Console.WriteLine("tekan Enter untuk keluar");
            Console.ReadLine();
            Console.Clear();
            TheGameStart = false;
        }    
    }
}               