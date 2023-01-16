using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class Player
    {
        int posY = 0;//Verticale Postion
        int posX = 0;//Horizontale Positon
        int lifes = 3;
        int points = 0;
        string name = "Anonymus";

        public Player(int posY, int posX, int lifes, int points, string name)
        {
            this.posY = posY;
            this.posX = posX;
            this.lifes = lifes;
            this.points = points;
            this.name = name;
        }
        // Gets
        public int getPosY() { return posY;}
        public int getPosX() { return posX;}
        public int getLifes() { return lifes;}
        public int getPoints() { return points;}
        public string getName() { return name;} 
        //Sets
        public void setPosY(int y) { this.posY=y;}
        public void setPosX(int x) { this.posX=x;}
        public void setLifes(int l) { this.lifes=l;}
        public void setPoints(int p) { this.points=p;}
        public void setName(string name) { this.name = name;}
        //Variablen
        public Bullet shoot(bool isPlayer)
        {
            return new Bullet(this.posX, this.posY-1, isPlayer);
        }
        public void hit()
        {
            lifes--;
        }
    }
}
