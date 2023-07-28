/*The menu is used frequently, so separating it into its own class reduces copying/pasting.*/

using HillCavernFair.StorySections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair
{
    public class Menu
    {
        
        public static void MainMenu()
        {
            var services = CreateServiceCollection();

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("gamelogger.txt")
            .CreateLogger();

            var logger = services.GetService<ILogger<Menu>>();

            string opt;

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

                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Console.Write("Your name is " + Program.PlayerName + ".");
                        break;

                    case "2":
                        Console.Write("Your email is " + Program.PlayerEmail + ".");
                        break;

                    case "3":
                        Console.WriteLine("Your runtime is " + Runtime.CurrentRuntime / 1000 + "seconds.");
                        break;

                    case "4":
                        Environment.Exit(5);
                        break;

                    case "5":
                        Console.Clear();
                        Intro.GameIntro();
                        break;

                    default:
                        Console.Clear();
                        break;
                }

                logger.LogInformation(opt);

            } while (true);

            static IServiceProvider CreateServiceCollection()
            {
                return new ServiceCollection()
                    .AddLogging(configure => configure.AddSerilog())
                    .AddTransient<Menu>()
                    .BuildServiceProvider();
            }
        }
    }
}


