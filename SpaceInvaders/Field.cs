using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders;

namespace SpaceInvaders
{
    internal class Field
    {
       private Char[,] field;
       private List<Enemies> enemies;
       private int playerPosition;
        
        public Field(char[,] field, List<Enemies> enemies, int playerPosition)
        {
            this.field = field;
            this.enemies = enemies;
            this.playerPosition = playerPosition;
        }


        public async Task mapBuilder()
        {
           await foreach (var item in enemies)
            {
                field[item.XPos, item.YPos] = 'X';
            }
           field[playerPosition, field.GetLength(1) - 1] = 'V';
            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {
                    if (field[y,x] == '\0')
                    {
                       field[y, x] = ' ';
                    }
                }
            }
           
        }
        public async Task mapOutput()
        {
            while (spaceinvaders.spacemain._RUNNING)
            {
                for (int y = 0; y < field.GetLength(0); y++)
                {
                    for (int x = 0; x < field.GetLength(1); x++)
                    {
                        Console.Write(field[y, x]);
                    }
                    Console.Write("\n");
                    await Task.Delay(100);
                    Console.Clear();
                }
            }
        }
    }
}
