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
        Char[,] field;
        List<Enemies> enemies;
        int playerPosition;
        
        public Field(char[,] field, List<Enemies> enemies, int playerPosition)
        {
            this.field = field;
            this.enemies = enemies;
            this.playerPosition = playerPosition;
        }


        public async Task mapBuilder()
        {
            foreach (var item in enemies)
            {
                field[item.XPos, item.YPos] = 'X';
            } //give all Enemies in the fild
            await Task.Delay(50);//NO waring in my projekt q(≧▽≦q)
            field[playerPosition, field.GetLength(1) - 1] = 'V';//place the player
            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)  
                {
                    if (field[y,x] == '\0')
                    {
                       field[y, x] = ' ';
                    }
                }
            }//alle Emty field was filld

        }//Build the Map
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
                    Console.Write("\n");//new line
                    await Task.Delay(100);//so that you can see it
                    Console.Clear();//So that it is not among each other AMOG US *~(￣▽￣)~*
                }
            }
        }// give the map on the console 
    }
}
