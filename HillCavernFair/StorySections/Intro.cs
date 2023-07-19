using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;


namespace HillCavernFair.StorySections;


public class Intro
{
	public static void GameIntro()
	{
		var context = new HillCavernFairContext();

        var Paragraphs = context.Paragraph
			.AsNoTracking()
            .Where(s => s.StoryId == "Intro")
            .OrderBy(i => i.Id)
			.ToList();

		foreach (var content in Paragraphs)
		{
			Console.WriteLine("\t" + content.Content);
		}

		string opt;

		do
		{
			opt = Console.ReadLine();

			switch (opt)
			{
				case "dread":
					ChoiceDread.IntroChoiceDread();
					break;

				case "loss":
					ChoiceLoss.IntroChoiceLoss();
					break;

				case null:
					AnsiConsole.Markup("[red]Choose 'dread' to continue into Hill Cavern Fair or 'loss' to leave.[/]");
					break;

			}

		}
		while (true);
	}
}

