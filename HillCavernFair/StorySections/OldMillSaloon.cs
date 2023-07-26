using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OldMillSaloon
	{
		public static void OldMillSaloonOpt()
		{

            AnsiConsole.Markup(@"[wheat4]Choose “continue” to let your boat float on to the next scene, choose “get out” to climb out of the boat and into the scene.[/]");

            var Choice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                        .AddChoices(new[] {
                         "Continue", "Get out",
                         }
                    ));

            string opt;

            do

            {

                opt = Choice;

                switch (opt)
                {
                    case "Get out":
                        var context = new HillCavernFairContext();

                        var Paragraphs = context.Paragraph
                        .AsNoTracking()
                        .Where(s => s.StoryId == "OldMillSaloon2")
                        .OrderBy(i => i.Id)
                        .ToList();
                        foreach (var content in Paragraphs)
                        {
                            Console.WriteLine("\t" + content.Content);
                            Console.WriteLine();
                        }
                        AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                        break;

                    case "Continue":
                        
                        AnsiConsole.Markup(@"[wheat4]Choose “continue” to let your boat float on to the next scene, choose “get out” to climb out of the boat and into the scene.[/]");

                        var Choice2 = AnsiConsole.Prompt(
                                     new SelectionPrompt<string>()
                                    .AddChoices(new[] {
                         "Continue", "Get out",
                                     }
                                ));

                        string opt2;
                        do
                        {
                            opt2 = Choice2;

                            switch (opt2)
                            {
                                case "Get out":
                                    OldMillJail.OldMillJailOpt();
                                    break;

                                case "Continue":
                                    var context2 = new HillCavernFairContext();

                                    var Paragraphs2 = context2.Paragraph
                                    .AsNoTracking()
                                    .Where(s => s.StoryId == "OldMillGraveyard1")
                                    .OrderBy(i => i.Id)
                                    .ToList();
                                    foreach (var content2 in Paragraphs2)
                                    {
                                        Console.WriteLine("\t" + content2.Content);
                                        Console.WriteLine();
                                    }

                                    var Choice3 = AnsiConsole.Prompt(
                                     new SelectionPrompt<string>()
                                    .AddChoices(new[] {
                                    "Continue", "Get out",
                                     }
                                     ));
                                    string opt3;
                                    do
                                    {
                                        opt3 = Choice3;

                                        switch (opt3)
                                        {
                                            case "Get out":
                                                OldMillJail.OldMillJailOpt();
                                                break;

                                            case "Continue":
                                                var context3 = new HillCavernFairContext();

                                                var Paragraphs3 = context3.Paragraph
                                                .AsNoTracking()
                                                .Where(s => s.StoryId == "OldMillFinal")
                                                .OrderBy(i => i.Id)
                                                .ToList();
                                                foreach (var content3 in Paragraphs3)
                                                {
                                                    Console.WriteLine("\t" + content3.Content);
                                                    Console.WriteLine();
                                                }
                                                AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                                                break;
                                        }
                                    }
                                    while (true);
                            }
                        }
                        while (true);
                }

            } while (true);
        }
	}
}

