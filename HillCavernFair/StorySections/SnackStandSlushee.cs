using HillCavernFair.Data;
using Microsoft.EntityFrameworkCore;
using Spectre.Console;

namespace HillCavernFair.StorySections
{
    public class SnackStandSlushee
	{
		public static void Slushee()
		{
            var context = new HillCavernFairContext();

            var Paragraphs = context.Paragraph
                .AsNoTracking()
                .Where(s => s.StoryId == "SnackStandSlushee")
                .OrderBy(i => i.Id)
                .ToList();


            foreach (var content in Paragraphs)
            {
                Console.WriteLine("\t" + content.Content);

                Console.WriteLine();

                AnsiConsole.Markup("[wheat4]Do you want to order a slushee?[/]");

                Console.WriteLine();

                var SnackStandSlusheeChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .AddChoices(new[] {
                    "Yes", "No",
                }
                ));

                string opt;

                do

                {

                    opt = SnackStandSlusheeChoice;

                    switch (opt)
                    {
                        case "Yes":
                            Console.WriteLine("It really was only 30 cents, but you have a feeling if you drank more than your initial sip your medical bills would be much more expensive. It tastes exactly like wet laundry forgotten in a washing machine smells. You throw the cup away as soon as you leave the snack stand.");
                            Console.WriteLine();
                            Map.ParkMap();
                            break;

                        case "No":
                            Console.WriteLine("A good choice, really.");
                            Console.WriteLine();
                            Map.ParkMap();
                            break;

                        case null:
                            Slushee();
                            break;

                    }

                } while (true);

            }
        }
	}
}

