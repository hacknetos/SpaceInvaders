using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceInvaders;

namespace SpaceInvaders
{
    internal class Bullet
    {
        int yPos;
        int xPos;
        Boolean isEnemy = false;

        public Bullet(int yPos, int xPos, bool isEnemy)
        {
            this.yPos = yPos;
            this.xPos = xPos;
            this.isEnemy = isEnemy;
        }

        public int YPos { get => yPos; set => yPos = value; }
        public int XPos { get => xPos; set => xPos = value; }
    }
}
