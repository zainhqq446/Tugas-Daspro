using System;

int AngkaRandomPemain;
int AngkaRandomLawan;
int NilaiPemain = 0;
int NilaiLawan = 0;

Random random = new Random();

for (int i = 0; 1 < 10; i++)
{
    Console.WriteLine("Ronde "+(i+1));
    Console.WriteLine("Tekan Enter untuk mulai");
    Console.ReadKey();

    AngkaRandomPemain = random.Next(1, 7);
    Console.WriteLine("Pemain melempar Dadu");

    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("....."); 

    AngkaRandomLawan = random.Next(1, 7);
    Console.WriteLine("Lawan melempar Dadu");

    if(AngkaRandomPemain > AngkaRandomLawan)
    {
        Console.WriteLine("Pemain menang" + AngkaRandomPemain);
    }
    else if (AngkaRandomPemain < AngkaRandomLawan)
    {
        Console.WriteLine("Lawan menang" + AngkaRandomLawan);
    }
    else
    {
        Console.WriteLine("permainan seimbang coba untuk main lagi");
    }

    Console.WriteLine("score sekarang - Pemain" + NilaiPemain + "Nilai Lawan" + NilaiLawan);
    Console.WriteLine();

    if(NilaiPemain > NilaiLawan)
    {
        Console.WriteLine("Pemain memenangkan permainan");
    }
    else if(NilaiPemain < NilaiLawan)
    {
        Console.WriteLine("Lawan memenangkan permainan");
    }
}
Console.ReadKey();