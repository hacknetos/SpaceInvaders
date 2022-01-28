namespace SpaceInvaders
{
    internal class Field
    {
        Char[,] map;
        List<Enemies> enemies;
        int playerPosition;

        public Field(int y,  int x, List<Enemies> enemies, int playerPosition)
        {
            this.map = new char[y,x];
            this.enemies = enemies;
            this.playerPosition = playerPosition;
        }

        public int PlayerPosition { get => playerPosition; set => playerPosition = value; }
        public char[,] Map { get => map; set => map = value; }

        public async Task mapBuilder()
        {
            foreach (var item in enemies)
            {
                map[item.YPos, item.XPos] = 'X';
            } //give all Enemies in the fild
            map[playerPosition, map.GetLength(1) - 1] = 'V';//place the player
            await Task.Delay(100);//NO waring in my projekt q(≧▽≦q)

            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    if (map[y, x] == '\0')
                    {
                        map[y, x] = ' ';
                    }
                }
            }//alle Emty map was filld

        }//Build the Map
        public async Task mapOutput()
        {
            while (spacemain._RUNNING)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        Console.Write(map[y, x]);
                    }
                    Console.Write("\n");//new line
                    await Task.Delay(100);//so that you can see it
                    Console.Clear();//So that it is not among each other AMOG US *~(￣▽￣)~*
                }
            }
        }// give the map on the console 
    }
}
