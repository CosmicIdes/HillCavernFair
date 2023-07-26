using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
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

                SnackStandChoice();
            }

        }
        public static void SnackStandChoice()
        {

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
                        SnackStandSlushee.Slushee();
                        break;

                    case "CARAMEL CORN":
                        SnackStandCorn.Corn();
                        break;

                    case "COTTON CANDY":
                        SnackStandCandy.Candy();
                        break;

                    case "Nothing":
                        Map.ParkMap();
                        break;

                    case null:
                        SnackStandChoice();
                        break;

                }

            } while (true);
        }
    }
}

