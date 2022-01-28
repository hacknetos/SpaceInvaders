using System;
using System.Collections.Generic;
using System.Linq;

namespace spaceinvaders // Note: actual namespace depends on the project name.
{
    public class spacemain
    {
        static char[,] field = new char[20, 10];
        static Player player = new Player(5);
        public static void Main(string[] args)
        {
            asyncMain();

        }
        static async Task asyncMain()
        {
            int exist = 0;
            Enimy[] e = new Enimy[20];
           
            field[player.Pos, 9] = 'Y';
            for (int i = 0; i < 20; i++)
            {
                e[i] = new Enimy(0,i);
                
            } //enimy erstellen
            foreach (var item in e)
            {
                field[item.YPos,item.XPos] = 'X';
            } // ennime anzeigen
            Keykap();
            do
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 20; y++)
                    {
                        if (field[y, x] == '\0')
                            field[y, x] = ' ';
                        if (field[y, x] == '|' && exist >= 1)
                        {
                            cleaner(y);
                            exist = 0;
                        }
                        Console.Write(field[y, x]);
                    
                    }

                    Console.WriteLine();
                }
                
               Thread.Sleep(250);
                Console.Clear();
                exist++;
            } while (true);
            
        }

        private static void cleaner(int pos)
        {
            bool roundone = true;
            for (int i = pos; i < 9; i++)
            {
                if (i > 0 && roundone)
                {
                    for (int a = pos; a > -1; a--)
                    {
                        field[pos, i] = ' ';
                    }
                    roundone = false;
                }
                field[pos, i] = ' ';
            }
        }

        private static async Task Keykap() 
        {
            do
            {
                if (Console.KeyAvailable)
                {

                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.LeftArrow:
                            if (player.Pos > 0)
                            {
                                field[player.Pos, 9] = ' ';
                                player.Pos--;
                                 field[player.Pos, 9] = 'Y';
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (player.Pos < field.GetLength(0)-1) 
                            { 
                            field[player.Pos, 9] = ' ';
                            player.Pos++;
                            field[player.Pos, 9] = 'Y';
                            }
                            break;
                        case ConsoleKey.Spacebar :
                            shoot();
                            break;

                        case ConsoleKey.UpArrow:
                            shoot();
                            break;
                        default:
                            break;
                    }
                }


              await  Task.Delay(50);
            } while (true); 
        }

        private static void shoot()
        {
            shoote s = new shoote(false,player.Pos);
            for (int i = 8 ; i >= 0; i--)
            {
                field[s.Pos, i] = '|';
               
            }
                
        }


        
    }
}
