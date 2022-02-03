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
          do
          {

                if (Console.KeyAvailable)
                {

                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.LeftArrow:
                            if (Pos >= 0 && Pos <= map.Map.GetLength(1))
                            {
                                pos--;
                                map.PlayerPosition = pos;
                                Console.WriteLine("Left");
                                map.playerHasMove('L');
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (Pos >=0 && Pos <= map.Map.GetLength(1))
                            {
                                pos++;
                                map.PlayerPosition=pos;
                                map.playerHasMove('R');
                                Console.WriteLine("Right");
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
                    if (pos < 0 )
                    {
                        pos = map.Map.GetLength(1);
                        map.playerHasMove('R');
                    }
                    if (map.Map.GetLength(0)<pos)
                    {
                        pos = 0;
                        map.playerHasMove('L');
                    }
                    
                }
          } while (spacemain._RUNNING);
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
