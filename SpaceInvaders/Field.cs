using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Field
    {
        Char[,] field = new Char[5, 5];

        public Field(int x, int y)
        {
            this.field = new Char[y,x];
        }
        public Char[,] getField() { return field; }
        public void fillField(List<Enemy> enemy , Player player) {
            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {
                    field[y, x] = ' ';
                }
            }
            foreach (var item in enemy)
            {
                field[item.getPosY(), item.getPosX()] = 'Y';
            }
            field[player.getPosY(), player.getPosX()] = '^';
        }
        public void updateKordinte(int x, int y,Char symole)
        {
            field[y,x] = symole;
        }


    }
}
