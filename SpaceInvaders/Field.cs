namespace SpaceInvaders
{
    internal class Field
    {
        Char[,] map;
        List<Enemies> enemies;
        int playerPosition;

        public Field(int y, int x, List<Enemies> enemies, int playerPosition)
        {
            this.map = new char[y, x];
            this.enemies = enemies;
            this.playerPosition = playerPosition;
        }

        public int PlayerPosition { get => playerPosition; set => playerPosition = value; }
        public char[,] Map { get => map; set => map = value; }

        public async Task mapBuilder()
        {
            map[4, playerPosition] = 'V';
            foreach (var item in enemies)
            {
                map[item.YPos, item.XPos] = 'X';
            } //give all Enemies in the fild

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

            await Task.Delay(100);//NO waring in my projekt q(≧▽≦q)
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
                    //So that it is not among each other AMOG US *~(￣▽￣)~*
                }
                await Task.Delay(100);//so that you can see it
                Console.Clear();
            }
        }// give the map on the console 

        public async Task playerHasMove(char LoR)
        {
            if (LoR == 'L')
            {
                map[4, playerPosition + 1] = ' ';
                map[4, playerPosition] = 'V';
            }
            else
            {
                map[4, playerPosition - 1] = ' ';
                map[4, playerPosition] = 'V';
            }
               
        }
    }
}
