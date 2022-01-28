using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceinvaders
{
    internal class Player
    {
        int pos;
        String name;
        int life;

        public int Pos { get => pos; set => pos = value; }
        public string Name { get => name; set => name = value; }
        public int Life { get => life; set => life = value; }

        public Player(int pos, string name, int life)
        {
            this.pos = pos;
            this.name = name;
            this.life = life;
        }

        public Player(int pos)
        {
            this.pos = pos;
        }


    }
}
