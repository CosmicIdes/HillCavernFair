using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OldMillGraveyard
	{
		public static void OldMillGraveyardOptDeer()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
            .AsNoTracking()
            .Where(s => s.StoryId == "OldMillGraveyardDeerGodHelp")
            .OrderBy(i => i.Id)
            .ToList();
            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);
                Console.WriteLine();
            }

            if (OptPettingZoo.Inventory.Contains("Gift from Deer God"))
            {
                var context2 = new HillCavernFairContext();

                var Paragraphs2 = context2.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "OldMillGraveyardDeerGodHelpYes")
                .OrderBy(i => i.Id)
                .ToList();

                AnsiConsole.Markup("[green]WELCOME, [/]" + Program.PlayerName + "[green]. DO YOU WISH TO RETURN HOME?[/]");

                foreach (var content2 in Paragraphs2)
                {
                    Console.WriteLine("\t" + content2.Content);
                    Console.WriteLine();
                }
                AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
            }
            else
            {
                var context3 = new HillCavernFairContext();

                var Paragraphs3 = context3.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "OldMillGraveyardDeerGodHelpNo")
                .OrderBy(i => i.Id)
                .ToList();
                foreach (var content3 in Paragraphs3)
                {
                    Console.WriteLine("\t" + content3.Content);
                    Console.WriteLine();
                }
                AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
            } 
        }
	}
}

