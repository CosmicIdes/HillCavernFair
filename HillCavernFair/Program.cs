/*Welcome to Hill Cavern Fair, an adventure game. 
 * Coded by Brandi Hornbuckle (https://github.com/OrenjiId3s and https://linkedin.com/in/bhornbuckle)
 * and story by Calliope Woods (https://www.calliopewoods.com).*/

using HillCavernFair.Data;
using HillCavernFair.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair;

public class Program
{

    private static string? playerName;
    private static string? playerEmail;

    public static string? PlayerName { get => playerName; set => playerName = value; }
    public static string? PlayerEmail { get => playerEmail; set => playerEmail = value; }


    public static void Main(string[] args)
    {
        var services  = CreateServiceCollection();

        IDbUtility? utility = services.GetService<IDbUtility>();

        utility.EnsureDbExists();
        bool run = true;

        Log.Logger = new LoggerConfiguration()
        .WriteTo.File("gamelogger.txt")
        .CreateLogger();

        var logger = services.GetService<ILogger<Program>>();

        Console.Title = "Hill Cavern Fair";

        AnsiConsole.Write(
            new FigletText("HILL CAVERN FAIR")
            .Centered()
            .Color(Color.Wheat4));

        Console.WriteLine();

        AnsiConsole.Markup("[mediumpurple1]Code by Brandi Hornbuckle (https://github.com/OrenjiId3s)[/]");

        Console.WriteLine();

        AnsiConsole.Markup("[hotpink3_1]Story by Calliope Woods (https://www.calliopewoods.com)[/]");

        Console.WriteLine();

        AnsiConsole.Markup("[wheat4]Welcome to Hill Cavern Fair. This is best viewed in full screen mode.[/]");

        Console.WriteLine();

        AnsiConsole.Markup("[cornflowerblue]Please enter your name:  [/]");

        PlayerName = Console.ReadLine();

        logger.LogInformation(PlayerName);

        AnsiConsole.Markup("[cornflowerblue]Please enter your email address:  [/]");

        PlayerEmail = Console.ReadLine();
        {

            if (RegexEmail.Validate(PlayerEmail))

            {
                AnsiConsole.Markup("[wheat4]Thank you. Your name is [/]" + PlayerName + "[wheat4] and your email is [/]"
                    + PlayerEmail + "[wheat4]. Enjoy your visit.[/]");
            }
            else
            {
                AnsiConsole.Markup("[red]Please enter a valid email.  [/]");
                PlayerEmail = Console.ReadLine();
            }
        }

        logger.LogInformation(PlayerEmail);

        Console.WriteLine();

        Menu.MainMenu();

        Console.ReadKey();

        static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection()
                .AddLogging(configure => configure.AddSerilog())
                .AddTransient<IDbUtility, DbUtility>()
                .AddTransient<Program>()
                .AddDbContext<HillCavernFairContext>()
                .BuildServiceProvider();
        }
    }

}

