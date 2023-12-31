﻿using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;


namespace HillCavernFair.StorySections;


public class Intro
{

    private static List<string> inventory = new List<string>();

    public static List<string> Inventory { get => inventory; set => inventory = value; }

    public static void GameIntro()
	{
        var services = CreateServiceCollection();

        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("gamelogger.txt")
            .CreateLogger();

        var logger = services.GetService<ILogger<Intro>>();

        var context = new HillCavernFairContext();

        var Paragraphs = context.Paragraph
			.AsNoTracking()
            .Where(s => s.StoryId == "Intro")
            .OrderBy(i => i.Id)
			.ToList();


		foreach (var content in Paragraphs)
		{
			Console.WriteLine("\t" + content.Content);

            Console.WriteLine();
		}

		AnsiConsole.Markup(@"[wheat4]Type[/] [silver]“dread”[/] [wheat4]to continue into Hill Cavern Fair, type [/][silver]“loss”[/] [wheat4]to get back into your car and try to find your way back home.[/]");

		Console.WriteLine();


		string opt;

		do
		{
			opt = Console.ReadLine();

			switch (opt)
			{
				case "dread":
					Inventory.Add("Hill Cavern Fair Ticket");
					Inventory.Add("Park Map");
                    logger.LogInformation("Chose dread");
                    logger.LogInformation("Hill Cavern Fair ticket and Park Map added to inventory.");
					ChoiceDread.IntroChoiceDread();
					break;

				case "loss":
                    logger.LogInformation("Chose loss");
                    ChoiceLoss.IntroChoiceLoss();
					break;

				case null:
                    AnsiConsole.Markup("[red]Choose 'dread' to continue into Hill Cavern Fair or 'loss' to leave.[/]");
					break;

			}

		}
		while (true);
	}
    static IServiceProvider CreateServiceCollection()
    {
        return new ServiceCollection()
            .AddLogging(configure => configure.AddSerilog())
            .AddTransient<Intro>()
            .BuildServiceProvider();
    }
}

