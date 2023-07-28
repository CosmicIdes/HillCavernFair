using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OldMillSaloon
	{
		public static void OldMillSaloonOpt()
		{

            AnsiConsole.Markup(@"[wheat4]Choose “continue” to let your boat float on to the next scene, choose “get out” to climb out of the boat and into the scene.[/]");

            Console.WriteLine();

            var Choice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Continue", "Get out",
                         }
                    ));

            string opt;

            var services = CreateServiceCollection();

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("gamelogger.txt")
            .CreateLogger();

            var logger = services.GetService<ILogger<OldMillSaloon>>();

            do

            {

                opt = Choice;

                switch (opt)
                {
                    case "Get out":
                        var context = new HillCavernFairContext();

                        var Paragraphs = context.Paragraph
                        .AsNoTracking()
                        .Where(s => s.StoryId == "OldMillSaloon2")
                        .OrderBy(i => i.Id)
                        .ToList();
                        foreach (var content in Paragraphs)
                        {
                            Console.WriteLine("\t" + content.Content);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                        Console.WriteLine();
                        Menu.MainMenu();
                        break;

                    case "Continue":

                        var context4 = new HillCavernFairContext();

                        var Paragraphs4 = context4.Paragraph
                        .AsNoTracking()
                        .Where(s => s.StoryId == "OldMillJail1")
                        .OrderBy(i => i.Id)
                        .ToList();
                        foreach (var content4 in Paragraphs4)
                        {
                            Console.WriteLine("\t" + content4.Content);
                            Console.WriteLine();
                        }

                        logger.LogInformation(Choice + "Saloon");

                        Console.WriteLine();


                        AnsiConsole.Markup(@"[wheat4]Choose “continue” to let your boat float on to the next scene, choose “get out” to climb out of the boat and into the scene.[/]");

                        Console.WriteLine();

                        var Choice2 = AnsiConsole.Prompt(
                                     new SelectionPrompt<string>()
                                    .AddChoices(new[] {
                         "Continue", "Get out",
                                     }
                                ));

                        string opt2;
                        do
                        {
                            opt2 = Choice2;

                            switch (opt2)
                            {
                                case "Get out":
                                    OldMillJail.OldMillJailOpt();
                                    break;

                                case "Continue":
                                    var context2 = new HillCavernFairContext();

                                    var Paragraphs2 = context2.Paragraph
                                    .AsNoTracking()
                                    .Where(s => s.StoryId == "OldMillGraveyard1")
                                    .OrderBy(i => i.Id)
                                    .ToList();
                                    foreach (var content2 in Paragraphs2)
                                    {
                                        Console.WriteLine("\t" + content2.Content);
                                        Console.WriteLine();
                                    }

                                    logger.LogInformation(Choice2 + "Jail");

                                    Console.WriteLine();

                                    var Choice3 = AnsiConsole.Prompt(
                                     new SelectionPrompt<string>()
                                    .AddChoices(new[] {
                                    "Continue", "Get out",
                                     }
                                     ));
                                    string opt3;
                                    do
                                    {
                                        opt3 = Choice3;

                                        switch (opt3)
                                        {
                                            case "Get out":
                                                OldMillGraveyard.OldMillGraveyardOptDeer();
                                                break;

                                            case "Continue":
                                                var context3 = new HillCavernFairContext();

                                                var Paragraphs3 = context3.Paragraph
                                                .AsNoTracking()
                                                .Where(s => s.StoryId == "OldMillFinal")
                                                .OrderBy(i => i.Id)
                                                .ToList();
                                                foreach (var content3 in Paragraphs3)
                                                {
                                                    Console.WriteLine("\t" + content3.Content);
                                                    Console.WriteLine();
                                                }
                                                Console.WriteLine();
                                                AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                                                Console.WriteLine();
                                                Menu.MainMenu();
                                                break;
                                        }

                                        logger.LogInformation(Choice3 + "Graveyard");
                                    }
                                    while (true);
                            }
                        }
                        while (true);
                }

            } while (true);

            static IServiceProvider CreateServiceCollection()
            {
                return new ServiceCollection()
                    .AddLogging(configure => configure.AddSerilog())
                    .AddTransient<OldMillSaloon>()
                    .BuildServiceProvider();
            }
        }
	}
}

