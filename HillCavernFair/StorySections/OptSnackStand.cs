using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OptSnackStand
	{

        public static void SnackStand()
        {
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "SnackStandMain")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();
            }

            SnackStandChoice();
        }

        public static void SnackStandChoice()
        {
            var services = CreateServiceCollection();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("gamelogger.txt")
                .CreateLogger();

            var logger = services.GetService<ILogger<OptSnackStand>>();

            var SnackStandChoices = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .AddChoices(new[] {
                    "SLUSHEE", "CARAMEL CORN", "COTTON CANDY", "Nothing",
                }
                ));

            string opt;

            do

            {

                opt = SnackStandChoices;

                switch (opt)
                {
                    case "SLUSHEE":
                        logger.LogInformation("Chose to view slushee");
                        SnackStandSlushee.Slushee();
                        break;

                    case "CARAMEL CORN":
                        logger.LogInformation("Chose to view caramel corn");
                        SnackStandCorn.Corn();
                        break;

                    case "COTTON CANDY":
                        logger.LogInformation("Chose to view cotton candy");
                        SnackStandCandy.Candy();
                        break;

                    case "Nothing":
                        logger.LogInformation("Chose nothing from the Snack Stand");
                        Map.ParkMap();
                        break;

                    case null:
                        SnackStandChoice();
                        break;
                }

            } while (true);

        }

        static IServiceProvider CreateServiceCollection()
        {
            return new ServiceCollection()
                .AddLogging(configure => configure.AddSerilog())
                .AddTransient<OptSnackStand>()
                .BuildServiceProvider();
        }
    }
}

