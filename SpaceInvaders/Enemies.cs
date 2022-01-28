using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Enemies
    {
        int yPos;
        int xPos;
        int life;
        Boolean isAlife;

        public Enemies(int yPos, int xPos, int life)
        {
            this.yPos = yPos;
            this.xPos = xPos;
            this.life = life;
        }

        public int YPos { get => yPos; set => yPos = value; }
        public int XPos { get => xPos; set => xPos = value; }

        public void hit()
        {
            life--;
            if (life <= 0)
                isAlife = false;                
        }

    }
}
