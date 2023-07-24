using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OptGrandStage
	{
		public static void GrandStage()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "GrandStageMain")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();
            }

            AnsiConsole.Markup("[wheat4]Will you stay for the performance?[/]");

            var GrandStageChoice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Yes", "No",
                         }
                    ));

            string opt;

            do

            {

                opt = GrandStageChoice;

                switch (opt)
                {
                    case "Yes":
                        var context2 = new HillCavernFairContext();

                        var Paragraphs2 = context2.Paragraph
                        .AsNoTracking()
                        .Where(s => s.StoryId == "GrandStageYes")
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
                        Console.WriteLine("Nothing that happens in this place could be good. You turn away and head back to the main path.");
                        Console.WriteLine();
                        Map.ParkMap();
                        break;

                    case null:
                        GrandStage();
                        break;

                }

            } while (true);
        }
	}
}

