using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Enemy : Player
    {
        public Enemy(int posY, int posX, int lifes, int points, string name) : base(posY, posX, lifes, points, name)
        {
        }
        
        
    }
}
