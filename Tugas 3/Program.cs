using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static int kesempatan;
        static string kataMisteri, kataTertebak;
        static List<string> listTebakan = new List<string>{};

        static void Main(string[] args)
        {
            Init();
            intro();
            PlayGame();
            EndGame();
        }

        static void Init()     
        {
            kesempatan = 5;
            kataMisteri = "terkilir";
        }

        static void intro()
        {
            Console.WriteLine("selamat datangkita akan bermian tebak kata hari ini");
            Console.WriteLine($"kamu memiliki {kesempatan} kesempatan untuk menebak kata misteri hari ini");
            Console.WriteLine("kata merupakan nama penyakit manusia");
            Console.WriteLine("penyakit ini dialami oleh semua orang tanpa terkecuali");
            Console.WriteLine($"kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.WriteLine("tebak penyakit apakah yang dimaksud?\n");
        }

        static void PlayGame()
        {
            while(kesempatan > 0)
            {
                kataTertebak = "";
                Console.Write("\nApa huruf tebakanmu? (a-z): ");
                string input = Console.ReadLine();
                listTebakan.Add(input);
                if(CekKata(kataMisteri,listTebakan))
                {
                    Console.WriteLine("\nSelamat! kamu berhasil menebak kata misteri.");
                    Console.WriteLine("kata misteri adalah "+kataMisteri);
                    break;
                }
                else if(kataMisteri.Contains(input))
                {
                    Console.WriteLine("\nhuruf itu ada dalam kata misteri.");
                    for(int i=0;i<kataMisteri.Length;i++)
                    {
                        string str = Convert.ToString(kataMisteri[i]);
                        if(listTebakan.Contains(str))
                        {
                            kataTertebak+=str;
                        }
                        else
                        {
                            kataTertebak+="_";
                        }
                    }
                    Console.WriteLine(kataTertebak);;
                    Console.WriteLine("\nsilahkan tebak lagi...");
                }
                else
                {
                    Console.WriteLine("\nhuruf itu tidak ada dalam kata misteri");
                    kesempatan--;//kesempatan = kesempatan - 1;
                    Console.WriteLine($"kesempatan yang anda tinggal {kesempatan}");
                }

                if(kesempatan == 0)
                {
                    EndGame();
                    break;
                }
            }
        }

        static bool CekKata(string kata, List<string> list)
        {
            bool ret = false;
            for (int i = 0; i < kata.Length; i++)
            {
                string str = Convert.ToString(kata[i]);
                if(list.Contains(str))
                {
                    ret = true;
                }
                else
                {
                    return ret = false;
                }
            }
            return ret;
        }

        static void EndGame()
        {
            Console.WriteLine("\npermainan telah berakhir");
            Console.WriteLine("anda telah memenangkan permainan");
            Console.WriteLine("sampai jumpa dilain waktu");
            Console.WriteLine("byee...");
            Console.ReadKey();
        }
    }
}        