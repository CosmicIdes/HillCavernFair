using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OptOldMill
	{
		public static void OldMill()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "OldMillMain")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();
            }

            AnsiConsole.Markup("[wheat4]Will you ride the Old Mill?[/]");

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
                        .Where(s => s.StoryId == "OldMillSaloon1")
                        .OrderBy(i => i.Id)
                        .ToList();
                        foreach (var content2 in Paragraphs2)
                        {
                            Console.WriteLine("\t" + content2.Content);
                            Console.WriteLine();
                        }
                        
                        break;

                    case "No":
                        Console.WriteLine("You must return here eventually, but perhaps now isn’t the time.");
                        Console.WriteLine();
                        Map.ParkMap();
                        break;

                    case null:
                        OldMill();
                        break;

                }

            } while (true);
        }
	}
}

