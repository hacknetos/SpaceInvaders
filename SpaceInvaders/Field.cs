namespace SpaceInvaders
{
    internal class Field
    {
        Char[,] map;
        List<Enemies> enemies;
        int playerPosition;

        public Field(char[,] field, List<Enemies> enemies, int playerPosition)
        {
            this.map = field;
            this.enemies = enemies;
            this.playerPosition = playerPosition;
        }

        public int PlayerPosition { get => playerPosition; set => playerPosition = value; }
        public char[,] Map { get => map; set => map = value; }

        public async Task mapBuilder()
        {
            foreach (var item in enemies)
            {
                map[item.XPos, item.YPos] = 'X';
            } //give all Enemies in the fild
            await Task.Delay(50);//NO waring in my projekt q(≧▽≦q)
            map[playerPosition, map.GetLength(1) - 1] = 'V';//place the player
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
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
