/*Welcome to Hill Cavern Fair, an adventure game. 
 * Coded by Brandi Hornbuckle (https://github.com/OrenjiId3s and https://linkedin.com/in/bhornbuckle)
 * and story by Calliope Woods (https://www.calliopewoods.com).*/

using Spectre.Console;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HillCavernFair;

public class Program
{
    private static string? playerName;
    private static string? playerEmail;

    public static string? PlayerName { get => playerName; set => playerName = value; }
    public static string? PlayerEmail { get => playerEmail; set => playerEmail = value; }

    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        CreateDbIfNotExists(host);
        host.Run();

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
        Console.WriteLine();

        Menu.MainMenu();

        Console.ReadKey();
    }

    public static void CreateDbIfNotExists(IHost host)
    {
        using(var scope = host.Services.CreateScope())
        {
            var Services = scope.ServiceProvider;
            try
            {
                var context = Services.GetRequiredService<HillCavernFairContext>();
                StoryData.Storydb(context);
            }
            catch (Exception ex)
            {
                var logger = Services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An Error Occurred Creating in DB");
                throw;
            }
        }
    }
}

