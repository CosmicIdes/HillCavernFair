using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class ChoiceDread
	{
		public static void IntroChoiceDread()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "ChoiceDread")
                .OrderBy(i => i.Id)
                .ToList();

            foreach (var content in Paragraphs)
            {
                AnsiConsole.Markup("\t" + content.Content);
            }

            Map.ParkMap();
        }
	}
}

