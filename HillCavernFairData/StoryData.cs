using HillCavernFair.Domain;

namespace HillCavernFair.Data
{
    public class StoryData
    {
        public static void Storydb(HillCavernFairContext context)
        {
            context.Database.EnsureCreated();

            if (context.Paragraphs.Any())
            {
                return;
            }

            var paragraphs = new Paragraph[]
            {
                //Intro
                new Paragraph { Content = "How did you get here? Your memory is fuzzy and ill-formed, and it makes you sick to your stomach every time you try to focus on it. You’re standing beside your car, in an empty gravel-covered parking lot surrounded by woods. Green encroaches on all sides, vines and grass and burrs reaching past the barriers around the parking lot and towards you and your car. ", StoryId = "Intro" },
                new Paragraph { Content = "Before you an is an archway topped by a rusted and faded metal sign bearing the words ", StoryId = "Intro" },
                new Paragraph { Content = "HILL CAVERN FAIR", StoryId = "Intro" },
                new Paragraph { Content = "The vines don’t touch this archway, rickety and ill-maintained as it is. ", StoryId = "Intro" },
                new Paragraph { Content = "You have a choice to make, here. " },
                new Paragraph { Content = "Both choices make you feel bad, but different kinds of bad. ", StoryId = "Intro" },
                new Paragraph { Content = "The idea of going forward into this place fills you with dread: the dread of looking over edge of a very tall cliff and considering the bottom, the dread of having to admit to your boss that you’ve made an error that you know isn’t correctable, the dread of many, many potential bad futures and a handful of good ones. ", StoryId = "Intro" },
                new Paragraph { Content = "On the other hand, getting in your car and driving away feels like loss. The loss of your favorite toy in a park where you will never return. The loss of your childhood neighborhood when you moved and had to make all new friends and an all new identity in an all new place– never ever quite feeling like you fit in the same way you did in your old home. An important loss, but something that will fade with time. A loss that will hit you years later in ways you can’t put into words. ", StoryId = "Intro" },
                new Paragraph { Content = "Type “dread” to continue into Hill Cavern Fair, type “loss” to get back into your car and try to find your way back home.", StoryId = "Intro" },

                //ChoiceDread
                new Paragraph { Content = "You step forward under the sign and Hill Cavern Fair opens up to you amidst the woods. You first notice the darkness of the park–you’ve never seen a theme park so shaded by trees and hills. You would expect from the name that you would be on a hill, or maybe there would be a cave nearby? but you see no indication of either. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "In fact, the park seems surrounded by hills, set in the lowest places among them. The path is now paved, but it was paved long ago, and is beset with potholes and weeds. A small turnstile blocks your way, and this is surely where your exploration will be stopped, because there is no way this place is open. Your car was the only one in the parking lot, and nothing here seems maintained. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = " /“It’s free today,/” a cracked, aged voice says, from your left, while you were looking right. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "You jump and turn. A man stands beside you, in a faded polo shirt. He is unbelievably old, bent by the weight of years and overwhelmingly the color of yellowed receipts, from his tar-stained teeth to his liver-spotted skin. A name tag on his chest says /“Eugene./” ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "You don’t have a chance to ask for more information as he thrusts a ticket and a park map in your hand and gestures to the turnstile. “/Free on Tuesdays./” ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "Is it Tuesday? You don't think so. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "The turnstile creaks loudly as you enter Hill Cavern Fair. ", StoryId = "ChoiceDread" },

                //ChoiceLoss
                new Paragraph { Content = "You climb into your car and turn your back on the sign, driving down the gravel path that you surely followed into this place. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Surely you did. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "And surely, as you drive down this winding gravel road through tightly packed trees with branches that slap your windshield and animals that you perceive only as darting, furtive movement, you will eventually reach a main road. A paved, smooth, road. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Surely you will. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Surely, right around this corner. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Well, maybe the next turn. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Up over this hill. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Eventually you’ll be home, wherever that is, or was. ", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "Surely.", StoryId = "ChoiceLoss" },
                new Paragraph { Content = "END", StoryId = "ChoiceLoss" }

            };


        }
    }
}
