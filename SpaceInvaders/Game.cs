using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Game
    {
        bool isPause = false;
        //int bigX = 10;//Horizontale Größe
        //int bigY = 10;//Verticale Größe
        Player player;
        List<Enemy> enemys;
        Field field;

        public Game(bool isPause, Player player, List<Enemy> enemys, Field field)
        {
            this.isPause = isPause;
            this.player = player;
            this.enemys = enemys;
            this.field = field;
        }
        public void stardGame()
        {
            field.fillField(enemys, player);
            AnsiConsole.Clear();
            AnsiConsole.Write(
                new FigletText("Start")
                .Centered()
                .Color(Color.Green)
                );
            outputField();
            Console.WriteLine("To Startd Press Enter");
            Console.ReadLine();
            startRunGame();
        }

        private async void startRunGame()
        {
            Task.Run(() => {
                do
                {
                    var oldX = player.getPosX();
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.A:
                           
                            if (oldX > 0)
                            {
                                player.setPosX(oldX - 1);
                                field.updateKordinte(oldX, player.getPosY(), ' ');
                                field.updateKordinte(player.getPosX(), player.getPosY(), '^');
                            }
                            break;
                        case ConsoleKey.D:
                            
                            if (oldX < field.getField().GetLength(1)-1)
                            {
                                player.setPosX(oldX + 1);
                                field.updateKordinte(oldX, player.getPosY(), ' ');
                                field.updateKordinte(player.getPosX(), player.getPosY(), '^');
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            Bullet bul = player.shoot(true);
                            Task.Run(() =>
                            {
                               //TODO Bullet Fly 
                            })
                            break;
                        case ConsoleKey.W:
                            break;
                        default:
                            break;
                    }
                } while (true);
            });
            Task.Run(async () =>
            {
                do
                {
                    outputField();
                    await Task.Delay(100);
                    Console.Clear();
                } while (true);
            });
            do
            {

            } while (player.getLifes()>0);
        }

        public async void outputField()
        {
            
            Char[,] tmpField = field.getField();
            for (int y = 0; y < tmpField.GetLength(0); y++)
            {
                for (int x = 0; x <tmpField.GetLength(1); x++)
                {
                   Console.Write(tmpField[y, x]);
                }
                 Console.Write('\n');
            }
        }
    }
}
