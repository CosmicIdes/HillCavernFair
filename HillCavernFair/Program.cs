/*Welcome to Hill Cavern Fair, an adventure game. 
 * Coded by Brandi Hornbuckle (https://github.com/OrenjiId3s and https://linkedin.com/in/bhornbuckle)
 * and story by Calliope Woods (https://www.calliopewoods.com).*/

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
        Console.Title = "Hill Cavern Fair";

        AnsiConsole.Write(
            new FigletText("HILL CAVERN FAIR")
            .Centered()
            .Color(Color.DarkGoldenrod));

        Console.WriteLine();

        AnsiConsole.Markup("[mediumpurple1]Code by Brandi Hornbuckle (https://github.com/OrenjiId3s)[/]");

        Console.WriteLine();

        AnsiConsole.Markup("[hotpink3_1]Story by Calliope Woods (https://www.calliopewoods.com)[/]");

        Console.WriteLine();

        AnsiConsole.Markup("[darkgoldenrod]Welcome to Hill Cavern Fair. This is best viewed in full screen mode.[/]");

        Console.WriteLine();

        Console.ReadKey();
    }
}