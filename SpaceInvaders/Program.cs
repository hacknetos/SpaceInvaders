using Spectre.Console;


namespace SpaceInvaders // Note: actual namespace depends on the project name.
{
    public class spacemain
    {
        static public Boolean _RUNNING;
        public static void Main(string[] args)
        {
            beforGame();
            
        }
        public static async Task beforGame()
        {
            

            AnsiConsole.Write(
                new FigletText("Wellkom to Space Invaders")
                .Centered()
                .Color(Color.Red3));

            var select = AnsiConsole.Prompt(
              new SelectionPrompt<string>()
              .Title("Selcet an on Option:")
              .PageSize(10)
              .MoreChoicesText("[red]Move Up and Down To show Mohr Options[/]")
              .AddChoices(new[] { "new Game", "Best Games", "Quit" })
              );
            switch (select)
            {
                case "new Game":
                    AnsiConsole.Clear();
                    stardGame();
                    break;
                case "Best Games":
                    AnsiConsole.Clear();
                    break;
                case "Quit":
                    AnsiConsole.Clear();
                    AnsiConsole.Write(
                        new FigletText("Bye have a nice day")
                        .LeftJustified()
                        .Color(Color.Red)
                        );
                    break;
                default:
                    break;
            }
        }
        public static void stardGame()
        {
            int x = AnsiConsole.Ask<int>("How Big is the [red]Horizontel fild[/]? ");
            int y = AnsiConsole.Ask<int>("How Big is the [red]Vertical fild[/]? ");
            Field field = new Field(y,x);
            string name = AnsiConsole.Ask<string>("wahts is[red]your name[/]? ");
            Player player = new Player(y-1,x-3,3,0,name) ;

            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < x; i++)
            {
                enemies.Add(new Enemy(0, i, 1, 0, "eemy"));
            }
            Game game = new Game(false,player,enemies,field);
            game.stardGame();
           
        }
    }
}
