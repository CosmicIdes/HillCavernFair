using Spectre.Console;

namespace HillCavernFair
{
    public static class Menu
    {
        public static void MainMenu()
        {
            int opt;

            do

            {
                AnsiConsole.Markup("[cornflowerblue] 1)- Display Name[/]");
                Console.WriteLine();
                AnsiConsole.Markup("[cornflowerblue] 2)- Display Email[/]");
                Console.WriteLine();
                AnsiConsole.Markup("[cornflowerblue] 3)- Display Runtime[/]");
                Console.WriteLine();
                AnsiConsole.Markup("[cornflowerblue] 4)- Exit[/]");
                Console.WriteLine();
                AnsiConsole.Markup("[cornflowerblue] 5)- Start Game [/]");
                Console.WriteLine();

                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Your name is " + Program.PlayerName + ".");
                        break;

                    case 2:
                        Console.Write("Your email is " + Program.PlayerEmail + ".");
                        break;

                    case 3:
                        Console.WriteLine("Your runtime is " + Runtime.CurrentRuntime / 1000 + "seconds.");
                        break;

                    case 4:
                        Environment.Exit(5);
                        break;

                    case 5:
                        Console.Clear();
                        //Game.GameStart();
                        break;

                    default:
                        Console.Clear();
                        break;
                }

            } while (true);

        }
    }
}


