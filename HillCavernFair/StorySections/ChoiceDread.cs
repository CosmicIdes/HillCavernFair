using System;
using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;

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
                Console.WriteLine("\t" + content.Content);
            }

            Map.ParkMap();
        }
	}
}

