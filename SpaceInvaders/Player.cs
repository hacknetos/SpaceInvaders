namespace SpaceInvaders
{
    internal class Player
    {
        int pos;
        int life;
        String name;
        Field map;

        public Player(int pos, int life, string name, Field map)
        {
            this.pos = pos;
            this.life = life;
            this.name = name;
            this.map = map;
        }

        public int Pos { get => pos; set => pos = value; }
        public int Life { get => life; set => life = value; }
        public string Name { get => name; set => name = value; }
        internal Field Map { get => map; set => map = value; }

        public async Task move()
        {
            while (spacemain._RUNNING) ;
            {

                if (Console.KeyAvailable)
                {

                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.LeftArrow:
                            if (Pos > 0 && Pos < map.Map.GetLength(0))
                            {
                                pos--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (Pos > 0 && Pos < map.Map.GetLength(0))
                            {
                                pos++;
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            shot();
                            break;

                        case ConsoleKey.UpArrow:
                            shot();
                            break;
                        default:
                            break;
                    }
                }


                await Task.Delay(10);
            }
        }

        private async Task shot()
        {
            Bullet bullet = new Bullet(pos, map.Map.GetLength(1) - 2,false);
            for (int i = 0; i < map.Map.GetLength(1)-2; i++)
            {
                bullet.YPos = Pos;
                bullet.XPos = i;
                map.Map[Pos,i] = '|';
                map.Map[Pos,i-1] = ' ';
               await Task.Delay(110);
            }
        }
    }
}
