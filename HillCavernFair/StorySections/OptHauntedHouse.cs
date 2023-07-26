using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
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

            var Choice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Yes", "No",
                         }
                    ));

            string opt;

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

            } while (true);
        }
	}
}

