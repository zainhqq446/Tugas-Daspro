using System;

/*
zain m haqqo
2207112580
T.INFORMATIKA B
GAME BATTLE TANK
*/

namespace BattleTank
{
    class Program
    {
        static char[,] tank = 
        {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] ans = 
        {
            {1,1},{2,2},{3,5}
        };
        static int[,] recent = 
        {
            {0,0},{0,0},{0,0}
        };
        static int[] tebakan = {0,0};
        static int jB = 0;
        static bool gstate = true;
        static int truth = 0;

        static void Main(string[] args)
        {
        //Gameplay
            while(gstate)
            {
                drawTank();
                try
                {
                    Console.Write("Pilih kolom: "); tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih baris: "); tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Anda memasukkan angka tidak valid");
                }
                truth = cekTank();
                if(truth == 2)
                {
                    Console.WriteLine("tembakan tepat mengenai tank");
                }
                else
                if(truth == 1)
                {
                    Console.WriteLine("Boom! Tank hancur!");
                    jB++;
                }
                else
                {
                    Console.WriteLine("Meleset!, tembakan tidak kena");
                }
                if(jB >= 3)
                {
                    Console.WriteLine("\nMenang! Tank hancur semua!");
                    gstate=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(tank[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(recent[i,0] == tebakan[0] && recent[i,1] == tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(ans[i,0] == tebakan[0] && ans[i,1] == tebakan[1])
                {
                    tank[tebakan[0],tebakan[1]] = 'X';
                    recent[i,0] = tebakan[0];
                    recent[i,1] = tebakan[1];
                    return 1;
                }
                else
                {
                    tank[tebakan[0],tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}