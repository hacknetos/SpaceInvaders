namespace SpaceInvaders // Note: actual namespace depends on the project name.
{
    public class spacemain
    {
        static public Boolean _RUNNING;
        public static async Task Main(string[] args)
        {
            List<Enemies> enemies = new List<Enemies>();
            for (int i = 0; i < 5; i++)
            {
                enemies.Add(new Enemies(0, i, 1));
            }
            Field map = new Field(5, 10, enemies, 5);
            Player player = new Player(5, 5, "peter", map);
            _RUNNING = true;

            map.mapBuilder();
            Task.Run(map.mapOutput);
            player.move();
            


        }
    }
}
