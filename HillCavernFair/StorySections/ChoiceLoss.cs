using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class ChoiceLoss
	{
		public static void IntroChoiceLoss()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "ChoiceLoss")
                .OrderBy(i => i.Id)
                .ToList();

            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);
                Console.WriteLine();
            }

            AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");

            Console.WriteLine();

            Menu.MainMenu();

        }
	}
}

