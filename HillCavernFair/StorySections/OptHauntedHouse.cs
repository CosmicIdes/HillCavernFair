using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OptHauntedHouse
	{
		public static void HauntedHouse()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "HauntedHouseMain")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();
            }

            AnsiConsole.Markup("[wheat4]Will you ride the Haunted House?[/]");

            Console.WriteLine();

            var Choice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Yes", "No",
                         }
                    ));

            string opt;

            var services = CreateServiceCollection();

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("gamelogger.txt")
            .CreateLogger();

            var logger = services.GetService<ILogger<OptHauntedHouse>>();

            do

            {

                opt = Choice;

                switch (opt)
                {
                    case "Yes":
                        var context2 = new HillCavernFairContext();

                        var Paragraphs2 = context2.Paragraph
                        .AsNoTracking()
                        .Where(s => s.StoryId == "HauntedHouseYes")
                        .OrderBy(i => i.Id)
                        .ToList();
                        foreach (var content2 in Paragraphs2)
                        {
                            Console.WriteLine("\t" + content2.Content);
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Map.ParkMap();
                        break;

                    case "No":
                        Console.WriteLine("What a shame. It seemed like it would be fun.");
                        Console.WriteLine();
                        Map.ParkMap();
                        break;

                    case null:
                        HauntedHouse();
                        break;

                }

                logger.LogInformation(Choice + "Haunted House");

            } while (true);

            static IServiceProvider CreateServiceCollection()
            {
                return new ServiceCollection()
                    .AddLogging(configure => configure.AddSerilog())
                    .AddTransient<OptHauntedHouse>()
                    .BuildServiceProvider();
            }
        }
	}
}

