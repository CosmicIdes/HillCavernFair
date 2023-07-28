using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class SnackStandCorn
    {

        private static List<string> inventory = new List<string>();

        public static List<string> Inventory { get => inventory; set => inventory = value; }

        public static void Corn()
        {
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "SnackStandCaramelCorn")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();

                AnsiConsole.Markup("[wheat4]Do you want to order caramel corn?[/]");

                Console.WriteLine();

                var Choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .AddChoices(new[] {
                    "Yes", "No",
                }
                ));

                var services = CreateServiceCollection();

                Log.Logger = new LoggerConfiguration()
                .WriteTo.File("gamelogger.txt")
                .CreateLogger();

                var logger = services.GetService<ILogger<SnackStandCorn>>();

                string opt;

                do

                {

                    opt = Choice;

                    switch (opt)
                    {
                        case "Yes":
                            Inventory.Add("caramel corn");
                            logger.LogInformation("Caramel corn added to inventory.");
                            Console.WriteLine(@"It really only cost 25 cents. The box is dusty and cobwebby, but the caramel corn inside smells good, and when you eat some it’s satisfying, with a sweet crunch. You carry the box with you throughout the rest of the park.");
                            Console.WriteLine();
                            Map.ParkMap();
                            break;

                        case "No":
                            Console.WriteLine();
                            Map.ParkMap();
                            break;

                        case null:
                            Corn();
                            break;

                    }

                } while (true);

                static IServiceProvider CreateServiceCollection()
                {
                    return new ServiceCollection()
                        .AddLogging(configure => configure.AddSerilog())
                        .AddTransient<SnackStandCorn>()
                        .BuildServiceProvider();
                }
            }
        }
    }
}
