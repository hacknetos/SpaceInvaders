using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Bullet
    {
        int posX = 0;//Horizontale Positon
        int posY = 0;//Verticalle Positon
        bool isPlayer;

        public Bullet(int posX, int posY, bool isPlayer)
        {
            this.posX = posX;
            this.posY = posY;
            this.isPlayer = isPlayer;
        }
    }
}
