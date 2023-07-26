using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OldMillJail
	{
		public static void OldMillJailOpt()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
            .AsNoTracking()
            .Where(s => s.StoryId == "OldMillJail2")
            .OrderBy(i => i.Id)
            .ToList();
            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);
                Console.WriteLine();
            }

            AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
        }
	}
}

