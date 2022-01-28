using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceinvaders
{
    internal class Enimy
    {
        string Name;
        int xPos;
        int yPos;
        string art;

        public Enimy(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
    }
}
