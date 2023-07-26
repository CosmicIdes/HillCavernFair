using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class OptPettingZoo
	{

        private static List<string> inventory = new List<string>();

        public static List<string> Inventory { get => inventory; set => inventory = value; }

        public static void PettingZoo()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "PettingZooMain")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();
            }

            AnsiConsole.Markup("[wheat4]Will you explore further?[/]");

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
                        

                        
                        if (SnackStandCorn.Inventory.Contains("caramel corn"))
                            {
                            var context5 = new HillCavernFairContext();
                            var Paragraphs5 = context5.Paragraph
                                .AsNoTracking()
                                .Where(s => s.StoryId == "PettingZooYesHasCC")
                                .OrderBy(i => i.Id)
                                .ToList();


                            foreach (var content5 in Paragraphs5)
                            {
                                Console.WriteLine("\t" + content5.Content);

                                Console.WriteLine();
                            }

                            AnsiConsole.Markup("[wheat4]Will you offer the Deer God your caramel corn?[/]");

                            var Choice2 = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                            .AddChoices(new[] {
                            "Yes", "No",
                            }
                            ));

                            if (Choice2 == "Yes")
                            {
                                var context2 = new HillCavernFairContext();

                                var Paragraphs2 = context2.Paragraph
                                .AsNoTracking()
                                .Where(s => s.StoryId == "PettingZooYesHasCCYes")
                                .OrderBy(i => i.Id)
                                .ToList();
                                foreach (var content2 in Paragraphs2)
                                {
                                    Console.WriteLine("\t" + content2.Content);
                                    Console.WriteLine();
                                }
                                Inventory.Add("Gift from the Deer God");
                                Inventory.Remove("caramel corn");
                            }
                            else
                            {
                                var context4 = new HillCavernFairContext();

                                var Paragraphs4 = context4.Paragraph
                                .AsNoTracking()
                                .Where(s => s.StoryId == "PettingZooYesHasCCNo")
                                .OrderBy(i => i.Id)
                                .ToList();
                                foreach (var content4 in Paragraphs4)
                                {
                                    Console.WriteLine("\t" + content4.Content);
                                    Console.WriteLine();
                                }
                                AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                                Console.WriteLine();
                                Menu.MainMenu();
                            }
                        }
                        else
                        {
                            var context3 = new HillCavernFairContext();

                            var Paragraphs3 = context3.Paragraph
                            .AsNoTracking()
                            .Where(s => s.StoryId == "PettingZooYesNoCC")
                            .OrderBy(i => i.Id)
                            .ToList();
                            foreach (var content3 in Paragraphs3)
                            {
                                Console.WriteLine("\t" + content3.Content);
                                Console.WriteLine();
                            }
                            AnsiConsole.Markup("Your runtime was " + Runtime.CurrentRuntime / 1000 + " seconds.");
                            Console.WriteLine();
                            Menu.MainMenu();
                        }
                        break;

                    case "No":
                        Console.WriteLine(@"You’ve made a good decision for now, though something tells you that you should return with something worthwhile.");
                        Console.WriteLine();
                        Map.ParkMap();
                        break;

                    case null:
                        PettingZoo();
                        break;

                }

            } while (true);
        }
	}
}

