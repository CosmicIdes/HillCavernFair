/*In the previous incarnation of this game,the Map was just in the main Game class.
The map also contained most of the logic for the game.
Separating it out makes sense in terms of SOLID- Single Responsibility.*/

using HillCavernFair.StorySections;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Spectre.Console;

namespace HillCavernFair
{
    public class Map
	{
		public static void ParkMap()
		{
            var services = CreateServiceCollection();

            Log.Logger = new LoggerConfiguration()
            .WriteTo.File("gamelogger.txt")
            .CreateLogger();

            var logger = services.GetService<ILogger<Map>>();

            var ParkMapAttractions = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[wheat4]The park map is as old and faded as everything else you’ve encountered. It lists several attractions. Where would you like to go?[/]")
                .AddChoices(new[] {
                    "Snack Stand", "The Grand Stage", "Petting Zoo", "Haunted House", "Ye Old Mill",
                }
                ));

            string opt;

            do

            {

                opt = ParkMapAttractions;

                switch (opt)
                {
                    case "Snack Stand":
                        logger.LogInformation("Chose Snack Stand");
                        OptSnackStand.SnackStand();
                        break;

                    case "The Grand Stage":
                        logger.LogInformation("Chose the Grand Stage");
                        OptGrandStage.GrandStage();
                        break;

                    case "Petting Zoo":
                        logger.LogInformation("Chose the Petting Zoo");
                        OptPettingZoo.PettingZoo();
                        break;

                    case "Haunted House":
                        logger.LogInformation("Chose the Haunted House");
                        OptHauntedHouse.HauntedHouse();
                        break;

                    case "Ye Old Mill":
                        logger.LogInformation("Chose Ye Old Mill");
                        OptOldMill.OldMill();
                        break;

                    case null:
                        ParkMap();
                        break;

                }

                } while (true);

            static IServiceProvider CreateServiceCollection()
            {
                return new ServiceCollection()
                    .AddLogging(configure => configure.AddSerilog())
                    .AddTransient<Map>()
                    .BuildServiceProvider();
            }
        } 
    }
}


