using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class SnackStandCandy
	{

        private static List<string> inventory = new List<string>();

        public static List<string> Inventory { get => inventory; set => inventory = value; }

        public static void Candy()
		{
                var context = new HillCavernFairContext();

                var Paragraphs = context.Paragraph
                    .AsNoTracking()
                    .Where(s => s.StoryId == "SnackStandCottonCandy")
                    .OrderBy(i => i.Id)
                    .ToList();


                foreach (var content in Paragraphs)
                {
                    Console.WriteLine("\t" + content.Content);

                    Console.WriteLine();

                    AnsiConsole.Markup("[wheat4]Do you want to order cotton candy?[/]");
                    var SnackStandCandyChoice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Yes", "No",
                         }
                    ));

                    string opt;

                    do

                    {

                        opt = SnackStandCandyChoice;

                        switch (opt)
                        {
                            case "Yes":
                                Inventory.Add("cotton candy");

                                var context2 = new HillCavernFairContext();

                                var Paragraphs2 = context2.Paragraph
                                .AsNoTracking()
                                .Where(s => s.StoryId == "SnackStandCottonCandyYes")
                                .OrderBy(i => i.Id)
                                .ToList();
                                foreach (var content2 in Paragraphs2)
                                {
                                    Console.WriteLine("\t" + content2.Content);
                                    Console.WriteLine();
                                }
                                Map.ParkMap();
                                break;

                            case "No":
                                Console.WriteLine();
                                Map.ParkMap();
                                break;

                            case null:
                                Candy();
                                break;

                        }

                    } while (true);
                
            }
        }
	}
}

