//In the previous incarnation of this game,the Map was just in the main Game class.
//Separating it out makes sense in terms of SOLID- Single Responsibility.

using Spectre.Console;

namespace HillCavernFair
{
    public class Map
	{
		public static void ParkMap()
		{

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

                opt = Console.ReadLine();

                switch (opt.ToLower())
                {
                    case "snack stand":
                        SnackStand();
                        break;

                    case "the grand stage":
                        GrandStage();
                        break;

                    case "petting zoo":
                        PettingZoo();
                        break;

                    case "haunted house":
                        HauntedHouse();
                        break;

                    case "ye old mill":
                        OldMill();
                        break;

                    case null:
                        ParkMap();
                        break;

                }

                } while (true);
            
        } 
    }
}


