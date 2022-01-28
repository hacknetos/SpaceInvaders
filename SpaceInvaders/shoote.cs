using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceinvaders
{
    internal class shoote
    {
        Boolean isEneimy;
        int pos;//seitwerts
        

        public shoote(bool isEneimy, int pos)
        {
            this.isEneimy = isEneimy;
            this.pos = pos;
            
        }

        public int Pos { get => pos; set => pos = value; }
    }
}
