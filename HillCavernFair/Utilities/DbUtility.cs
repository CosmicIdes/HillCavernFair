using HillCavernFair.Data;
using HillCavernFair.Domain;

namespace HillCavernFair.Utilities
{
    public class DbUtility : IDbUtility
    { 
            private readonly HillCavernFairContext _context;

        public DbUtility(HillCavernFairContext context)
        {
            _context = context;
        }

        public void EnsureDbExists()
        {
            string path = Environment.CurrentDirectory.ToString() + "\\Story.db";

            if (!File.Exists(path))
            {
                _context.Database.EnsureCreated();

                //Seed data for database
                Paragraph Paragraphs001 = new Paragraph()
                {
                    Id = 1,
                    Content = @"How did you get here? Your memory is fuzzy and ill-formed, and it makes you sick to your stomach every time you try to focus on it. You’re standing beside your car, in an empty gravel-covered parking lot surrounded by woods. Green encroaches on all sides, vines and grass and burrs reaching past the barriers around the parking lot and towards you and your car. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs002 = new Paragraph()
                {
                    Id = 2,
                    Content = @"Before you an is an archway topped by a rusted and faded metal sign bearing the words ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs003 = new Paragraph()
                {
                    Id = 3,
                    Content = @"HILL CAVERN FAIR",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs004 = new Paragraph()
                {
                    Id = 4,
                    Content = @"The vines don’t touch this archway, rickety and ill-maintained as it is. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs005 = new Paragraph()
                {
                    Id = 5,
                    Content = @"You have a choice to make, here. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs006 = new Paragraph()
                {
                    Id = 6,
                    Content = @"Both choices make you feel bad, but different kinds of bad. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs007 = new Paragraph()
                {
                    Id = 7,
                    Content = @"The idea of going forward into this place fills you with dread: the dread of looking over edge of a very tall cliff and considering the bottom, the dread of having to admit to your boss that you’ve made an error that you know isn’t correctable, the dread of many, many potential bad futures and a handful of good ones. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs008 = new Paragraph()
                {
                    Id = 8,
                    Content = @"On the other hand, getting in your car and driving away feels like loss. The loss of your favorite toy in a park where you will never return. The loss of your childhood neighborhood when you moved and had to make all new friends and an all new identity in an all new place– never ever quite feeling like you fit in the same way you did in your old home. An important loss, but something that will fade with time. A loss that will hit you years later in ways you can’t put into words. ",
                    StoryId = "Intro"
                };
                Paragraph Paragraphs009 = new Paragraph()
                {
                    Id = 9,
                    Content = @"Type “dread” to continue into Hill Cavern Fair, type “loss” to get back into your car and try to find your way back home.",
                    StoryId = "Intro"
                };

                //ChoiceDread
                Paragraph Paragraphs010 = new Paragraph()
                {
                    Id = 10,
                    Content = @"You step forward under the sign and Hill Cavern Fair opens up to you amidst the woods. You first notice the darkness of the park–you’ve never seen a theme park so shaded by trees and hills. You would expect from the name that you would be on a hill, or maybe there would be a cave nearby? but you see no indication of either. ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs011 = new Paragraph()
                {
                    Id = 11,
                    Content = @"In fact, the park seems surrounded by hills, set in the lowest places among them. The path is now paved, but it was paved long ago, and is beset with potholes and weeds. A small turnstile blocks your way, and this is surely where your exploration will be stopped, because there is no way this place is open. Your car was the only one in the parking lot, and nothing here seems maintained. ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs012 = new Paragraph()
                {
                    Id = 12,
                    Content = @"“It’s free today,” a cracked, aged voice says, from your left, while you were looking right. ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs013 = new Paragraph()
                {
                    Id = 13,
                    Content = @"You jump and turn. A man stands beside you, in a faded polo shirt. He is unbelievably old, bent by the weight of years and overwhelmingly the color of yellowed receipts, from his tar-stained teeth to his liver-spotted skin. A name tag on his chest says /“Eugene./” ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs014 = new Paragraph()
                {
                    Id = 14,
                    Content = @"You don’t have a chance to ask for more information as he thrusts a ticket and a park map in your hand and gestures to the turnstile. “Free on Tuesdays.” ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs015 = new Paragraph()
                {
                    Id = 15,
                    Content = @"Is it Tuesday? You don't think so. ",
                    StoryId = "ChoiceDread"
                };
                Paragraph Paragraphs016 = new Paragraph()
                {
                    Id = 16,
                    Content = @"The turnstile creaks loudly as you enter Hill Cavern Fair. ",
                    StoryId = "ChoiceDread"
                };

                //ChoiceLoss
                Paragraph Paragraphs017 = new Paragraph()
                {
                    Id = 17,
                    Content = @"You climb into your car and turn your back on the sign, driving down the gravel path that you surely followed into this place. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs018 = new Paragraph()
                {
                    Id = 18,
                    Content = @"Surely you did. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs019 = new Paragraph()
                {
                    Id = 19,
                    Content = @"And surely, as you drive down this winding gravel road through tightly packed trees with branches that slap your windshield and animals that you perceive only as darting, furtive movement, you will eventually reach a main road. A paved, smooth, road. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs020 = new Paragraph()
                {
                    Id = 20,
                    Content = @"Surely you will. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs021 = new Paragraph()
                {
                    Id = 21,
                    Content = @"Surely, right around this corner. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs022 = new Paragraph()
                {
                    Id = 22,
                    Content = @"Well, maybe the next turn. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs023 = new Paragraph()
                {
                    Id = 23,
                    Content = @"Up over this hill. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs024 = new Paragraph()
                {
                    Id = 24,
                    Content = @"Eventually you’ll be home, wherever that is, or was. ",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs025 = new Paragraph()
                {
                    Id = 25,
                    Content = @"Surely.",
                    StoryId = "ChoiceLoss"
                };
                Paragraph Paragraphs026 = new Paragraph()
                {
                    Id = 26,
                    Content = @"END",
                    StoryId = "ChoiceLoss"
                };

                //SnackStandMain
                Paragraph Paragraphs027 = new Paragraph()
                {
                    Id = 27,
                    Content = @"You head down the cracked asphalt path in the direction the map promises a snack stand. You’re unsure if a place like this is somewhere you would like to actually eat food, but curiosity leads you on to the little booth tucked into a mass of trees and vines that seem only days from swallowing the building entirely. The vines are so thick along the cracked and aged wood that you wonder how an employee could get inside the building. Flecks of paint hint that at one time this shack was brightly colored, but now exposed gray wood and rusted nails are its defining features.",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs028 = new Paragraph()
                {
                    Id = 28,
                    Content = @"You’re sure this place is completely closed until you catch sight of the extremely improbable man behind the counter. ",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs029 = new Paragraph()
                {
                    Id = 29,
                    Content = @"An old man with skin the color of yellowed receipts is hunched over an equally ancient cash register. His name tag reads “Gene.” To his left, a hand painted, chipped sign advertises the wares of the Snack Stand.",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs030 = new Paragraph()
                {
                    Id = 30,
                    Content = @"SLUSHEE — 30¢",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs031 = new Paragraph()
                {
                    Id = 31,
                    Content = @"CARAMEL CORN — 25¢",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs032 = new Paragraph()
                {
                    Id = 32,
                    Content = @"COTTON CANDY — 15¢",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs033 = new Paragraph()
                {
                    Id = 33,
                    Content = @"Before you can ask if the prices are a joke, the man says, “The slushees are new. Added ‘em only a little while ago. They’re cherry flavored.” He puffs himself up, standing at his full height, which is still shorter than you. ",
                    StoryId = "SnackStandMain"
                };
                Paragraph Paragraphs034 = new Paragraph()
                {
                    Id = 34,
                    Content = @"What'll it be?",
                    StoryId = "SnackStandMain"
                };

                //SnackStandSlushee
                Paragraph Paragraphs035 = new Paragraph()
                {
                    Id = 35,
                    Content = @"The slushee machine does not, in fact, look new. It looks as old and dusty as the rest of the place, and you question if it’s ever been cleaned in the however-many-years it’s been here. The frozen drink swirling inside is red, but the rim of the drink spout looks like it has some sort of black film on it–mold, or mildew.",
                    StoryId = "SnackStandSlushee"
                };
                Paragraph Paragraphs036 = new Paragraph()
                {
                    Id = 36,
                    Content = @"Do you want to order a slushee?",
                    StoryId = "SnackStandSlushee"
                };

                //SnackStandSlusheeYes
                Paragraph Paragraphs037 = new Paragraph()
                {
                    Id = 37,
                    Content = @"It really was only 30 cents, but you have a feeling if you drank more than your initial sip your medical bills would be much more expensive. It tastes exactly like wet laundry forgotten in a washing machine smells. You throw the cup away as soon as you leave the snack stand.",
                    StoryId = "SnackStandSlusheeYes"
                };

                //SnackStandSlusheeNo
                Paragraph Paragraphs038 = new Paragraph()
                {
                    Id = 38,
                    Content = @"A good choice, really.",
                    StoryId = "SnackStandSlusheeNo"
                };

                //SnackStandCaramelCorn
                Paragraph Paragraphs039 = new Paragraph()
                {
                    Id = 39,
                    Content = @"There are popcorn boxes behind the man that you assume are filled with caramel corn. They look dusty–are those spiderwebs? Even so, you feel a draw to the caramel corn. It feels like something worthwhile to have.",
                    StoryId = "SnackStandCaramelCorn"
                };
                Paragraph Paragraphs040 = new Paragraph()
                {
                    Id = 40,
                    Content = @"Do you want to order caramel corn?",
                    StoryId = "SnackStandCaramelCorn"
                };

                //SnackStandCaramelCornYes
                Paragraph Paragraphs041 = new Paragraph()
                {
                    Id = 41,
                    Content = @"It really only cost 25 cents. The box is dusty and cobwebby, but the caramel corn inside smells good, and when you eat some it’s satisfying, with a sweet crunch. You carry the box with you throughout the rest of the park.",
                    StoryId = "SnackStandCaramelCornYes"
                };

                //SnackStandCottonCandy
                Paragraph Paragraphs042 = new Paragraph()
                {
                    Id = 42,
                    Content = @"Bags of cotton candy hang off the ceiling of the snack stand. They look perfectly normal, and even relatively fresh, despite there being no cotton candy machine in sight.",
                    StoryId = "SnackStandCottonCandy"
                };
                Paragraph Paragraphs043 = new Paragraph()
                {
                    Id = 43,
                    Content = @"Do you want to order cotton candy?",
                    StoryId = "SnackStandCottonCandy"
                };

                //SnackStandCottonCandyYes
                Paragraph Paragraphs044 = new Paragraph()
                {
                    Id = 44,
                    Content = @"For 15 cents you get a pretty big bag of pink cotton candy. It tastes just like all the other cotton candy you’ve ever tasted–sweet and light.",
                    StoryId = "SnackStandCottonCandyYes"
                };
                Paragraph Paragraphs045 = new Paragraph()
                {
                    Id = 45,
                    Content = @"As you walk away from the snack stand, picking bits of cotton candy off the cloud and letting it dissolve in your mouth, you’re struck by how crowded the place is. Maybe you just came right as they opened and beat the initial crowds– because now there are people on all sides of you. It’s really quite bustling. Mostly families, kids running by in excitement towards this or that attraction, adults laughing and calling for them to wait up– you blink as the sun hits you right in your eyes and–",
                    StoryId = "SnackStandCottonCandyYes"
                };
                Paragraph Paragraphs046 = new Paragraph()
                {
                    Id = 46,
                    Content = @"Silence. Empty asphalt. Shadows from the hills, and clouds overhead.",
                    StoryId = "SnackStandCottonCandyYes"
                };
                Paragraph Paragraphs047 = new Paragraph()
                {
                    Id = 47,
                    Content = @"No, you were mistaken. Hill Cavern Fair is as empty and forlorn as when you first stepped inside. In fact, you’re sure it’s only you and Gene here.",
                    StoryId = "SnackStandCottonCandyYes"
                };

                //GrandStageMain
                Paragraph Paragraphs048 = new Paragraph()
                {
                    Id = 48,
                    Content = @"The Grand Stage appears to be neither grand, nor a stage.",
                    StoryId = "GrandStageMain"
                };
                Paragraph Paragraphs049 = new Paragraph()
                {
                    Id = 49,
                    Content = @"What you find in the place marked on the map is a small outdoor amphitheater of the kind often found in small parks: three levels of concrete seating set into a hill with a flat paved area in the center that it would be rather generous to term a “stage”. The woods are encroaching more into this area than any of the others: there are vine-choked trees on all sides of the paved area, and cracks in the concrete as it continues to lose the fight against the roots of those trees. The vines hang down into the space, and various plants are sprouting from the cracks. Piles of years of leaves and other rotting plant matter line the edges of the concrete.",
                    StoryId = "GrandStageMain"
                };
                Paragraph Paragraphs050 = new Paragraph()
                {
                    Id = 50,
                    Content = @"This seems more to be a small rest area than an attraction, but sure enough there is a sign amid the weeds on the stage that seems to indicate a performance will occur here in five minutes.",
                    StoryId = "GrandStageMain"
                };
                Paragraph Paragraphs051 = new Paragraph()
                {
                    Id = 51,
                    Content = @"Will you stay for the performance?",
                    StoryId = "GrandStageMain"
                };

                //GrandStageYes
                Paragraph Paragraphs052 = new Paragraph()
                {
                    Id = 52,
                    Content = @"You wait for much longer than five minutes, but the wait is restorative and so you don’t leave when the time drags on. You find yourself relaxing back against the concrete, following the journeys of the cracks across it with your eyes.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs053 = new Paragraph()
                {
                    Id = 53,
                    Content = @"You only look up when you hear a throat being cleared.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs054 = new Paragraph()
                {
                    Id = 54,
                    Content = @"An old, old man with a polo shirt so faded and soiled it’s the color of yellowed receipts stands before you. On his chest is a name tag that reads “Gene.”",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs055 = new Paragraph()
                {
                    Id = 55,
                    Content = @"He stands on the stage with all the dignity and air of a storied actor. He begins his story in a booming, authoritative voice that allows no interruption.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs056 = new Paragraph()
                {
                    Id = 56,
                    Content = @"“In 1947, Brothers Raymond and Eugene Hill bought a large parcel of land just ten miles from the newly established Mammoth Cave National Park. They believed the land to be untouched woodland, ripe for development into a variety of attractions that would surely yield unimaginable profit as the tourists poured into Kentucky for their visits to what would eventually be known as the world’s longest cave system.” He lets this statement hang in the air for a few moments, presumably for you to absorb the grandeur of the region you find yourself in.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs057 = new Paragraph()
                {
                    Id = 57,
                    Content = @"“Shortly after the brothers Hill opened Hill Cavern Fair, they realized their mistake, for in the long, uncharted caverns beneath our feet hide secrets. For millennia the fragile limestone lining empty pockets in the earth has given way beneath the feet of both animal and man. Those who avoid the sinkholes aren’t safe– the Underneath claims bodies by enchanting explorers with its caverns and by courting powerful men with its coal.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs058 = new Paragraph()
                {
                    Id = 58,
                    Content = @"“Here, where the caverns yawn wide, where the bodies accumulate, something was stirred. Something hungry and old and greedy crawled from its gore-filled hole and took a form it thought was less threatening to its prey and settled in the heart of Hill Cavern Fair, a spider waiting upon its web.”",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs059 = new Paragraph()
                {
                    Id = 59,
                    Content = @"Gene goes silent after this last declaration, staring at a spot behind you.",
                    StoryId = "GrandStageYes"
                };
                Paragraph Paragraphs060 = new Paragraph()
                {
                    Id = 60,
                    Content = @"After a few minutes of silence, it seems like a good idea for you to leave.",
                    StoryId = "GrandStageYes"
                };

                //GrandStageNo
                Paragraph Paragraphs061 = new Paragraph()
                {
                    Id = 61,
                    Content = @"Nothing that happens in this place could be good. You turn away and head back to the main path.",
                    StoryId = "GrandStageNo"
                };

                //PettingZooMain
                Paragraph Paragraphs062 = new Paragraph()
                {
                    Id = 62,
                    Content = @"The petting zoo seemed like a safe choice, but as you approach it now you’re filled with the same dread you felt making the decision to come inside Hill Cavern Fair. The Petting Zoo has no attendant, and no animals in sight. A cheery hand painted sign hangs lopsided by one nail over the entrance.",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs063 = new Paragraph()
                {
                    Id = 63,
                    Content = @"HILL CAVERN PETTING ZOO",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs064 = new Paragraph()
                {
                    Id = 64,
                    Content = @"The entire area is surrounded by a wooden fence, and the surrounding forest, despite its enthusiasm for the other buildings in this park, does not encroach beyond it. The ground is dry and dusty, with none of the animal droppings found at similar petting zoos across the world.",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs065 = new Paragraph()
                {
                    Id = 65,
                    Content = @"On the far side of the animal enclosure is a small building– you assume a shelter for the animals– in surprisingly pristine condition. It looks like it has recently been painted, or maybe even recently built. It’s solid white and has a similarly hand painted sign.",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs066 = new Paragraph()
                {
                    Id = 66,
                    Content = @"PLEASE— DON’T FEED THE ANIMALS!",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs067 = new Paragraph()
                {
                    Id = 67,
                    Content = @"THANK YOU, MGMT",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs068 = new Paragraph()
                {
                    Id = 68,
                    Content = @"There are of course no animals in sight, only an empty enclosure with a foreboding air that twists your stomach. Something is very, very wrong here, more wrong than the cumulative wrongness of the rest of Hill Cavern Fair.",
                    StoryId = "PettingZooMain"
                };
                Paragraph Paragraphs069 = new Paragraph()
                {
                    Id = 69,
                    Content = @"Will you explore further?",
                    StoryId = "PettingZooMain"
                };

                //PettingZooYesHasCC
                Paragraph Paragraphs070 = new Paragraph()
                {
                    Id = 70,
                    Content = @"You step through the wooden gate onto the hard packed dirt. You kick up dust as you walk towards the bright white enclosure. When you touch the door to step inside, it is skin-warm, like the enclosure itself has blood pumping just beneath the fresh coats of paint.",
                    StoryId = "PettingZooYesHasCC"
                };
                Paragraph Paragraphs071 = new Paragraph()
                {
                    Id = 71,
                    Content = @"Inside is filled with sweet-smelling clean hay. A single animal is curled up atop the hay, a small brown fawn with bright white spots. You’ve woken it up. It lifts its head to gaze at you and bleats a greeting—or is it a question?",
                    StoryId = "PettingZooYesHasCC"
                };
                Paragraph Paragraphs072 = new Paragraph()
                {
                    Id = 72,
                    Content = @"Yes, it’s a question.",
                    StoryId = "PettingZooyesHasCC"
                };
                Paragraph Paragraphs073 = new Paragraph()
                {
                    Id = 73,
                    Content = @"You fall to your knees as the words of a god fill your brain.",
                    StoryId = "PettingZooYesHasCC"
                };
                Paragraph Paragraphs074 = new Paragraph()
                {
                    Id = 74,
                    Content = @"HAVE YOU AN OFFERING, OR HAVE YOU DISTURBED MY SLUMBER WITHOUT REASON?",
                    StoryId = "PettingZooYesHasCC"
                };
                Paragraph Paragraphs075 = new Paragraph()
                {
                    Id = 75,
                    Content = @"An offering? All you have on you is the caramel corn! Will that be enough?",
                    StoryId = "PettingZooYesHasCC"
                };
                Paragraph Paragraphs076 = new Paragraph()
                {
                    Id = 76,
                    Content = @"Will you offer the Deer God your caramel corn?",
                    StoryId = "PettingZooYesHasCC"
                };

                //PettingZooYesHasCCYes
                Paragraph Paragraphs077 = new Paragraph()
                {
                    Id = 77,
                    Content = @"With trembling hands, you pull the small, dusty box of caramel corn from your pocket and hold it out to the little fawn.",
                    StoryId = "PettingZooYesHasCCYes"
                };
                Paragraph Paragraphs078 = new Paragraph()
                {
                    Id = 78,
                    Content = @"The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it.",
                    StoryId = "PettingZooYesHasCCYes"
                };
                Paragraph Paragraphs079 = new Paragraph()
                {
                    Id = 79,
                    Content = @"You hear the gentle rustling of hay as the fawn approaches your prone form.",
                    StoryId = "PettingZooYesHasCCYes"
                };
                Paragraph Paragraphs080 = new Paragraph()
                {
                    Id = 80,
                    Content = @"A soft crunch near your ear as it eats some of the spilled caramel corn. More rustling, and you realize it’s gently snuffling the inside of the box as it eats more.",
                    StoryId = "PettingZooYesHasCCYes"
                };
                Paragraph Paragraphs081 = new Paragraph()
                {
                    Id = 81,
                    Content = @"You wake up outside the enclosure. In your pocket is a green rock with an image of an eight-legged stag engraved upon it, and your caramel corn is gone.",
                    StoryId = "PettingZooYesHasCCYes"
                };

                //PettingZooYesHasCCNo
                Paragraph Paragraphs082 = new Paragraph()
                {
                    Id = 82,
                    Content = @"Surely the caramel corn wouldn’t be enough. Besides, the sign said not to feed the animals!",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs083 = new Paragraph()
                {
                    Id = 83,
                    Content = @"You have nothing to offer the little fawn, and so you shake your head.",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs084 = new Paragraph()
                {
                    Id = 84,
                    Content = @"The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it.",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs085 = new Paragraph()
                {
                    Id = 85,
                    Content = @"You hear the gentle rustling of hay as the fawn approaches your prone form.",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs086 = new Paragraph()
                {
                    Id = 86,
                    Content = @"You hear the crunch seconds before your body allows you to feel the white hot pain, shooting up your arm and filling your entire body.",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs087 = new Paragraph()
                {
                    Id = 87,
                    Content = @"It’s a small blessing that you cannot see the gore of what the fawn is doing to your body, and a far larger blessing that everything goes black before it is finished.",
                    StoryId = "PettingZooYesHasCCNo"
                };
                Paragraph Paragraphs088 = new Paragraph()
                {
                    Id = 88,
                    Content = @"END",
                    StoryId = "PettingZooYesHasCCNo"
                };

                //PettingZooYesNoCC
                Paragraph Paragraphs089 = new Paragraph()
                {
                    Id = 89,
                    Content = @"You step through the wooden gate onto the hard packed dirt. You kick up dust as you walk towards the bright white enclosure. When you touch the door to step inside, it is skin-warm, like the enclosure itself has blood pumping just beneath the fresh coats of paint.",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs090 = new Paragraph()
                {
                    Id = 90,
                    Content = @"Inside is filled with sweet-smelling clean hay. A single animal is curled up atop the hay, a small brown fawn with bright white spots. You’ve woken it up. It lifts its head to gaze at you and bleats a greeting—or is it a question? ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs091 = new Paragraph()
                {
                    Id = 91,
                    Content = @"Yes, it's a question.",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs092 = new Paragraph()
                {
                    Id = 92,
                    Content = @"You fall to your knees as the words of a god fill your brain.",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs093 = new Paragraph()
                {
                    Id = 93,
                    Content = @"HAVE YOU AN OFFERING, OR HAVE YOU DISTURBED MY SLUMBER WITHOUT REASON?",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs094 = new Paragraph()
                {
                    Id = 94,
                    Content = @"An offering? Do you have anything on you that you can offer the fawn? You search your pockets frantically.",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs095 = new Paragraph()
                {
                    Id = 95,
                    Content = @"All you have is the park map and your ticket. These aren’t going to be enough. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs096 = new Paragraph()
                {
                    Id = 96,
                    Content = @"You have nothing to offer the little fawn, and so you shake your head. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs097 = new Paragraph()
                {
                    Id = 97,
                    Content = @"The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs098 = new Paragraph()
                {
                    Id = 98,
                    Content = @"You hear the gentle rustling of hay as the fawn approaches your prone form. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs099 = new Paragraph()
                {
                    Id = 99,
                    Content = @"You hear the crunch seconds before your body allows you to feel the white hot pain, shooting up your arm and filling your entire body. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs100 = new Paragraph()
                {
                    Id = 100,
                    Content = @"It’s a small blessing that you cannot see the gore of what the fawn is doing to your body, and a far larger blessing that everything goes black before it is finished. ",
                    StoryId = "PettingZooYesNoCC"
                };
                Paragraph Paragraphs101 = new Paragraph()
                {
                    Id = 101,
                    Content = @"END",
                    StoryId = "PettingZooYesNoCC"
                };

                //PettingZooNo
                Paragraph Paragraphs102 = new Paragraph()
                {
                    Id = 102,
                    Content = @"You’ve made a good decision for now, though something tells you that you should return with something worthwhile.",
                    StoryId = "PettingZooNo"
                };

                //HauntedHouseMain
                Paragraph Paragraphs103 = new Paragraph()
                {
                    Id = 103,
                    Content = @"You’re not sure how anything in this place could be more haunted than the park itself, but you head off for the “Haunted House” marked on the map.",
                    StoryId = "HauntedHouseMain"
                };
                Paragraph Paragraphs104 = new Paragraph()
                {
                    Id = 104,
                    Content = "What you find isn’t really a house–it’s a large metal box that looks like it could be easily folded up and hauled off by a truck to a carnival in the next state–or at least it once could have been. Rust and years and the woods have seeped into its cracks, and if someone attempted to fold it up and cart it away it wouldn’t survive the first pothole it encountered on its way out of the park. ",
                    StoryId = "HauntedHouseMain"
                };
                Paragraph Paragraphs105 = new Paragraph()
                {
                    Id = 105,
                    Content = "The metal structure is gaudily painted with faux stonework, cartoon skeletons peeking from around corners and through barred windows. The fading of years hasn’t diminished this old ride’s charm, and it’s a surprisingly welcome sight, a carnival staple planted amongst these claustrophobic hills. ",
                    StoryId = "HauntedHouseMain"
                };
                Paragraph Paragraphs106 = new Paragraph()
                {
                    Id = 106,
                    Content = @"And, right at the entrance, an old, old man with hair the color of yellowed receipts waves cheerfully at you. “Step right up, step right up! Have the fright of your life!” His face is so wrinkled it looks like melted wax, and on his polo shirt is a name tag that reads “Gene.” He really seems quite nice, and enthusiastic to get you on this old ride. ",
                    StoryId = "HauntedHouseMain"
                };
                Paragraph Paragraphs107 = new Paragraph()
                {
                    Id = 107,
                    Content = "Will you ride the Haunted House?",
                    StoryId = "HauntedHouseMain"
                };

                //HauntedHouseYes
                Paragraph Paragraphs108 = new Paragraph()
                {
                    Id = 108,
                    Content = "You climb the metal steps up to the entrance of the ride. From here, you can see there is actually a cart on a track leading towards a door painted to look as though it’s wood. There’s even a safety bar on the cart, implying the ride might reach speeds for which a safety bar is required. You climb into the cart and Gene cheerfully checks the safety bar before stepping back to a control panel and starting the ride. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs109 = new Paragraph()
                {
                    Id = 109,
                    Content = "Mechanical whirs and clinks and roars sound as your cart is pulled forward. The metal door swings open at the last second, thrusting you into cool darkness.",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs110 = new Paragraph()
                {
                    Id = 110,
                    Content = "And then the air shifts and the darkness adjusts. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs111 = new Paragraph()
                {
                    Id = 111,
                    Content = "You’re outside, on a large lawn in the dead of night. The moon is high and bright, illuminating a large manor house. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs112 = new Paragraph()
                {
                    Id = 112,
                    Content = "Not an imitation of a manor house, not a show scene on a dark ride, you’re really there. The only thing connecting you back to your previous surroundings is the cart, but there is no track and you are completely still, facing the scene before you.",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs113 = new Paragraph()
                {
                    Id = 113,
                    Content = "The manor house isn’t especially large or imposing. The great expanse of the lawn is between you and the house, and the wind plays through it in a pleasant way as your eyes adjust to the moon-bright darkness. Trees are on either side of the house, and it is well-kept with three rows of plain windows catching a bit of the moonlight and reflecting it back towards you. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs114 = new Paragraph()
                {
                    Id = 114,
                    Content = "All in all, a pleasant, if confusing, place to be. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs115 = new Paragraph()
                {
                    Id = 115,
                    Content = "You notice the person crawling towards the manor house with a jolt. It seemed like there was no one there just moments ago, but now you see that a figure on all fours in a black robe-like garment is right before you. You are extremely grateful that the figure is moving away from you, for there is an extreme wrongness in the way it moves, a jittering, dragging sort of crawl that reminds you of glitched analog camera footage. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs116 = new Paragraph()
                {
                    Id = 116,
                    Content = "You close your eyes, perhaps willing yourself somewhere else, but you feel no change in the air. When you finally open your eyes again you are alone, but there is evidence for where your companion has gone: the first story window, to the left of the door, is open. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs117 = new Paragraph()
                {
                    Id = 117,
                    Content = "Oh, God, it’s gotten in. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs118 = new Paragraph()
                {
                    Id = 118,
                    Content = "And you are left waiting for what feels like hours. The safety bar on the cart is indeed clapped down fast and resists all attempts at escape you can muster. You must wait, staring into the darkness of the open window, wondering what the thing is doing inside. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs119 = new Paragraph()
                {
                    Id = 119,
                    Content = "Your attention drifts with time, and is only snapped back after the thing has exited the house again. It no longer crawls, and it moves quite swiftly, though its movements are still jittery and clumsy. The robe reaches only its knees where it falls into tatters. Long, confident strides on thin white legs brings it towards you. A hood obscures much of its emaciated face, but you can see enough. Oh, God, you can see enough. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs120 = new Paragraph()
                {
                    Id = 120,
                    Content = "And in its skinny arms, an unmoving baby. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs121 = new Paragraph()
                {
                    Id = 121,
                    Content = "Is it asleep?",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs122 = new Paragraph()
                {
                    Id = 122,
                    Content = "Is the baby asleep?",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs123 = new Paragraph()
                {
                    Id = 123,
                    Content = "You can't tell.",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs124 = new Paragraph()
                {
                    Id = 124,
                    Content = @"You can’t tell at all, and even if you were brave enough (surely, you are brave enough) you cannot save this child, because you’re stuck in this damn cart. You cannot run to save yourself (surely, you would never do this) because you’re stuck in this damn cart. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs125 = new Paragraph()
                {
                    Id = 125,
                    Content = @"But you do not need to worry, for you’re not actually in danger. The– person, figure, skeleton, corpse– the thing simply passes you by, confident in its purpose. It does not even turn its head to acknowledge you. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs126 = new Paragraph()
                {
                    Id = 126,
                    Content = "The baby does not move or make a sound.",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs127 = new Paragraph()
                {
                    Id = 127,
                    Content = "The wind blows hard, suddenly whipping the grass around and causing you to close your eyes against the granules blasted against your face. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs128 = new Paragraph()
                {
                    Id = 128,
                    Content = "Mechanical whirs and clinks and roars and your cart exits through a metal door painted to look as though it's made of wood. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs129 = new Paragraph()
                {
                    Id = 129,
                    Content = "The safety bar lifts easily once the cart comes to a stop. Gene is nowhere to be seen. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs130 = new Paragraph()
                {
                    Id = 130,
                    Content = "You stagger out of the cart on unsteady legs, feeling as though you just rode a modern high-speed roller coaster. ",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs131 = new Paragraph()
                {
                    Id = 131,
                    Content = "From behind you, you hear someone else stand up from the cart and walk onto the metal floor. In the corner of your eye, a black and white blurred figure steps beside you.",
                    StoryId = "HauntedHouseYes"
                };
                Paragraph Paragraphs132 = new Paragraph()
                {
                    Id = 132,
                    Content = "You turn your head, and of course you are alone. ",
                    StoryId = "HauntedHouseYes"
                };

                //HauntedHouseNo
                Paragraph Paragraphs133 = new Paragraph()
                {
                    Id = 133,
                    Content = "What a shame. It seemed like it would be fun.",
                    StoryId = "HauntedHouseNo"
                };

                //OldMillMain
                Paragraph Paragraphs134 = new Paragraph()
                {
                    Id = 134,
                    Content = "The Old Mill Ride has all the appearances of literally being in an old mill, a large wooden structure with a water wheel on the outside being pushed along by a not insignificant stream. There is an opening under the structure that lets the stream flow under and presumably through it. ",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs135 = new Paragraph()
                {
                    Id = 135,
                    Content = "There is none of the expected queue area that similar rides possess, just a yawning empty doorway to darkness. The only indication that this is indeed an attraction at a theme park is a very old paint job on the side of the building.",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs136 = new Paragraph()
                {
                    Id = 136,
                    Content = @"“YE OLDE MILL” is painted in overwrought imitation medieval text across the aged wood.",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs137 = new Paragraph()
                {
                    Id = 137,
                    Content = "You enter through the wide doorway. It takes a moment for your eyes to adjust to the gloom inside, despite the rest of the park not being particularly bright. ",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs138 = new Paragraph()
                {
                    Id = 138,
                    Content = @"The room is empty save for an extremely old man. He wears a faded polo shirt with a nametag that reads “Gene.” He looks tired, and greets you only with a slight wave of his hand. His sallow skin is the color of yellowed receipts. ",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs139 = new Paragraph()
                {
                    Id = 139,
                    Content = @"He is standing by the stream, which is flanked on both sides by a poured concrete floor. A small boat waits by him, its movement down the stream hampered by a bar that must be manually lifted to let it continue into the depths of the ride. ",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs140 = new Paragraph()
                {
                    Id = 140,
                    Content = @"“I miss my brother,” Gene confides to you as you approach, his voice bearing all the weight of his years. “I’m so confused now. Ray always knew what to do. I feel like I’m just going in circles.” He gestures to the boat and sighs. “Climb in.”",
                    StoryId = "OldMillMain"
                };
                Paragraph Paragraphs141 = new Paragraph()
                {
                    Id = 141,
                    Content = "Will you ride the Old Mill?",
                    StoryId = "OldMillMain"
                };

                //OldMillNo
                Paragraph Paragraphs142 = new Paragraph()
                {
                    Id = 142,
                    Content = "You must return here eventually, but perhaps now isn’t the time.",
                    StoryId = "OldMillNo"
                };

                //OldMillSaloon1
                Paragraph Paragraphs143 = new Paragraph()
                {
                    Id = 143,
                    Content = "Gene somberly lifts the bar and your boat begins its journey down the stream. There is no safety bar on the boat, and the concrete floor is level with it. It would be very easy to stop the boat and get out at any time during this ride. ",
                    StoryId = "OldMillSaloon1"
                };
                Paragraph Paragraphs144 = new Paragraph()
                {
                    Id = 144,
                    Content = @"You pass through a short tunnel and are soon floating through an old west style saloon scene. A group of mannequins sit at a table playing a card game, one serving as bartender is busy pouring whiskey for a patron at the bar, and a particularly aged mannequin in a red dress stands atop a stage. A fuzzy recording of a woman singing “House of the Rising Sun” is playing over speakers you can’t see.",
                    StoryId = "OldMillSaloon1"
                };
                Paragraph Paragraphs145 = new Paragraph()
                {
                    Id = 145,
                    Content = @"Type “continue” to let your boat float on to the next scene, type “get out” to climb out of the boat and into the scene.",
                    StoryId = "OldMillSaloon1"
                };

                //OldMillSaloon2
                Paragraph Paragraphs146 = new Paragraph()
                {
                    Id = 146,
                    Content = "You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs147 = new Paragraph()
                {
                    Id = 147,
                    Content = "The recording immediately sounds clearer now that you’re level with the scene. The performer is beginning the second verse, and the quality of her voice causes you to turn and look at the stage.",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs148 = new Paragraph()
                {
                    Id = 148,
                    Content = @"A young woman in a red dress is standing there singing where the mannequin used to be. “If I had only listened to what my mama said, I’d be at home today. But bein’ so young and foolish, my Lord, let a gambler lead me astray.”",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs149 = new Paragraph()
                {
                    Id = 149,
                    Content = @"“Hey!” The bartender calls to you. He’s finished pouring the drink and is passing it to the man in front of him. “Find a seat or buy a drink, but quit blockin’ the door!” ",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs150 = new Paragraph()
                {
                    Id = 150,
                    Content = "And you are blocking the door, aren’t you? You move to the bar past the card players. ",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs151 = new Paragraph()
                {
                    Id = 151,
                    Content = @"The man who just received his drink is eyeing you. “You okay there, pardner? You look like you’ve seen a ghost.”",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs152 = new Paragraph()
                {
                    Id = 152,
                    Content = "You suppose the best thing to do is order a drink, and you do, before turning to the man who spoke and beginning to tell him all about the strange day you’ve been having. ",
                    StoryId = "OldMillSaloon2"
                };
                Paragraph Paragraphs153 = new Paragraph()
                {
                    Id = 153,
                    Content = "END",
                    StoryId = "OldMillSaloon2"
                };

                //OldMillJail1
                Paragraph Paragraphs154 = new Paragraph()
                {
                    Id = 154,
                    Content = "Continuing the old west theme, you find yourself looking at the inside of a jail cell. A mannequin dressed as a sheriff stands on the other side of the bars looking in at you and the single mannequin sitting on the dirt floor inside. ",
                    StoryId = "OldMillJail1"
                };
                Paragraph Paragraphs155 = new Paragraph()
                {
                    Id = 155,
                    Content = @"Type “continue” to let your boat float on to the next scene, type “get out” to climb out of the boat and into the scene.",
                    StoryId = "OldMillJail1"
                };

                //OldMillJail2
                Paragraph Paragraphs156 = new Paragraph()
                {
                    Id = 156,
                    Content = "You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ",
                    StoryId = "OldMillJail2"
                };
                Paragraph Paragraphs157 = new Paragraph()
                {
                    Id = 157,
                    Content = "You immediately feel tired as you overlook the two mannequins. You decide to join the mannequin on the floor and sit down beside it. ",
                    StoryId = "OldMillJail2"
                };
                Paragraph Paragraphs158 = new Paragraph()
                {
                    Id = 158,
                    Content = "Your limbs feel stiff, and stretching does not relieve this feeling. Your skin catches the light as you stretch. It’s shiny. In fact, it looks just like varnished wood. You rap your knuckles against the shiny spot on your skin, and it sounds just like two pieces of varnished wood being clunked together. ",
                    StoryId = "OldMillJail2"
                };
                Paragraph Paragraphs159 = new Paragraph()
                {
                    Id = 159,
                    Content = "You don’t have much time to worry about this development, because the exhaustion is really taking hold now. You’re so tired your limbs are wooden, both literally and figuratively. A bit of a nap here couldn’t hurt.",
                    StoryId = "OldMillJail2"
                };
                Paragraph Paragraphs160 = new Paragraph()
                {
                    Id = 160,
                    Content = "END",
                    StoryId = "OldMillJail2"
                };

                //OldMillGraveyard1
                Paragraph Paragraphs161 = new Paragraph()
                {
                    Id = 161,
                    Content = "The next scene is a graveyard complete with a skeleton in a cowboy hat propped up against the fence. A painted cardboard moon hangs high over the scene, and a painted backdrop shows a forest in the distance.",
                    StoryId = "OldMillGraveyard1"
                };
                Paragraph Paragraphs162 = new Paragraph()
                {
                    Id = 162,
                    Content = @"Type “Continue” to let your boat float on to the next scene, type “Get Out” to climb out of the boat and into the scene.",
                    StoryId = "OldMillGraveyard1"
                };

                //OldMillGraveyardDeerGodHelp
                Paragraph Paragraphs163 = new Paragraph()
                {
                    Id = 163,
                    Content = "You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };
                Paragraph Paragraphs164 = new Paragraph()
                {
                    Id = 164,
                    Content = "This scene is particularly poorly made. From the boat you could make out the corrugated sides of the gravestones, and here among the graves it’s even more obvious that they are just painted cardboard. ",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };
                Paragraph Paragraphs165 = new Paragraph()
                {
                    Id = 165,
                    Content = @"The forest backdrop is more intriguing, as it is painted skillfully by someone who really should be painting for somewhere other than Hill Cavern Fair. You can make out individual plants and trees, and– there is some animal in the forest, watching you. ",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };
                Paragraph Paragraphs166 = new Paragraph()
                {
                    Id = 166,
                    Content = "You are drawn to that spot on the backdrop, heading forward to look closer. By the time you realize something is wrong, you’re already in the forest.",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };
                Paragraph Paragraphs167 = new Paragraph()
                {
                    Id = 167,
                    Content = @"A stag stands before you, twice your height and with twice as many legs as it should have. Its antlers are tall and many-branched, extending up into the trees where you are unable to see them end. Its eyes glow without any light source to reflect back.",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };
                Paragraph Paragraphs168 = new Paragraph()
                {
                    Id = 168,
                    Content = "Its voice fills your mind.",
                    StoryId = "OldMillGraveyardDeerGodHelp"
                };

                //OldMillGraveyardDeerGodHelpYes
                Paragraph Paragraphs169 = new Paragraph()
                {
                    Id = 169,
                    Content = @"The Deer God kneels before you, its many jointed legs folding down unnaturally until it reaches a level where you could easily climb upon its back.",
                    StoryId = "OldMillGraveyardDeerGodHelpYes"
                };
                Paragraph Paragraphs170 = new Paragraph()
                {
                    Id = 170,
                    Content = "You have no choice but to climb on. You do not expect it to actually take you home, but perhaps it will take you somewhere better than here.",
                    StoryId = "OldMillGraveyardDeerGodHelpYes"
                };
                Paragraph Paragraphs171 = new Paragraph()
                {
                    Id = 171,
                    Content = "END",
                    StoryId = "OldMillGraveyardDeerGodHelpYes"
                };

                //OldMillGraveyardDeerGodHelpNo
                Paragraph Paragraphs172 = new Paragraph()
                {
                    Id = 172,
                    Content = "I HAVE BEEN WAITING FOR YOU, SERVANT. FOLLOW ME.",
                    StoryId = "OldMillGraveyardDeerGodHelpNo"
                };
                Paragraph Paragraphs173 = new Paragraph()
                {
                    Id = 173,
                    Content = "You have no choice but to follow the creature as it leads you deeper into the forest.",
                    StoryId = "OldMillGraveyardDeerGodHelpNo"
                };
                Paragraph Paragraphs174 = new Paragraph()
                {
                    Id = 174,
                    Content = "END",
                    StoryId = "OldMillGraveyardDeerGodHelpNo"
                };

                //OldMillFinal
                Paragraph Paragraphs175 = new Paragraph()
                {
                    Id = 175,
                    Content = "The boat reaches a dead end. There are no more scenes, only a black wall in front of you and a door to your right.",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs176 = new Paragraph()
                {
                    Id = 176,
                    Content = "You have no choice but to climb out and go through the door. ",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs177 = new Paragraph()
                {
                    Id = 177,
                    Content = @"The sun shines brightly as you walk out onto the gravel. You’re at the entrance to Hill Cavern Fair, and a young man in a bright yellow polo shirt grins and waves at you. On his chest is a name tag that reads “Gene.”",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs178 = new Paragraph()
                {
                    Id = 178,
                    Content = @"“Where’ve you been, Ray? I haven’t seen anyone yet!”",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs179 = new Paragraph()
                {
                    Id = 179,
                    Content = @"You smile and pat your brother’s shoulder. “No need to be so anxious, Gene. It’s our first day. We’ve got lots of days ahead of us. If the tourists don’t come today, there’s tomorrow, and the day after that.”",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs180 = new Paragraph()
                {
                    Id = 180,
                    Content = @"Gene nods, always attentive to your advice. “You’re right, of course, I just really want our opening day to be grand.”",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs181 = new Paragraph()
                {
                    Id = 181,
                    Content = @"“It can be grand with just the two of us,” you promise, leading the way into your park.",
                    StoryId = "OldMillFinal"
                };
                Paragraph Paragraphs182 = new Paragraph()
                {
                    Id = 182,
                    Content = "END",
                    StoryId = "OldMillFinal"
                };

                _context.Add(Paragraphs001);
                _context.Add(Paragraphs002);
                _context.Add(Paragraphs003);
                _context.Add(Paragraphs004);
                _context.Add(Paragraphs005);
                _context.Add(Paragraphs006);
                _context.Add(Paragraphs007);
                _context.Add(Paragraphs008);
                _context.Add(Paragraphs009);
                _context.Add(Paragraphs010);
                _context.Add(Paragraphs011);
                _context.Add(Paragraphs012);
                _context.Add(Paragraphs013);
                _context.Add(Paragraphs014);
                _context.Add(Paragraphs015);
                _context.Add(Paragraphs016);
                _context.Add(Paragraphs017);
                _context.Add(Paragraphs018);
                _context.Add(Paragraphs019);
                _context.Add(Paragraphs020);
                _context.Add(Paragraphs021);
                _context.Add(Paragraphs022);
                _context.Add(Paragraphs023);
                _context.Add(Paragraphs024);
                _context.Add(Paragraphs025);
                _context.Add(Paragraphs026);
                _context.Add(Paragraphs027);
                _context.Add(Paragraphs028);
                _context.Add(Paragraphs029);
                _context.Add(Paragraphs030);
                _context.Add(Paragraphs031);
                _context.Add(Paragraphs032);
                _context.Add(Paragraphs033);
                _context.Add(Paragraphs034);
                _context.Add(Paragraphs035);
                _context.Add(Paragraphs036);
                _context.Add(Paragraphs037);
                _context.Add(Paragraphs038);
                _context.Add(Paragraphs039);
                _context.Add(Paragraphs040);
                _context.Add(Paragraphs041);
                _context.Add(Paragraphs042);
                _context.Add(Paragraphs043);
                _context.Add(Paragraphs044);
                _context.Add(Paragraphs045);
                _context.Add(Paragraphs046);
                _context.Add(Paragraphs047);
                _context.Add(Paragraphs048);
                _context.Add(Paragraphs049);
                _context.Add(Paragraphs050);
                _context.Add(Paragraphs051);
                _context.Add(Paragraphs052);
                _context.Add(Paragraphs053);
                _context.Add(Paragraphs054);
                _context.Add(Paragraphs055);
                _context.Add(Paragraphs056);
                _context.Add(Paragraphs057);
                _context.Add(Paragraphs058);
                _context.Add(Paragraphs059);
                _context.Add(Paragraphs060);
                _context.Add(Paragraphs061);
                _context.Add(Paragraphs062);
                _context.Add(Paragraphs063);
                _context.Add(Paragraphs064);
                _context.Add(Paragraphs065);
                _context.Add(Paragraphs066);
                _context.Add(Paragraphs067);
                _context.Add(Paragraphs068);
                _context.Add(Paragraphs069);
                _context.Add(Paragraphs070);
                _context.Add(Paragraphs071);
                _context.Add(Paragraphs072);
                _context.Add(Paragraphs073);
                _context.Add(Paragraphs074);
                _context.Add(Paragraphs075);
                _context.Add(Paragraphs076);
                _context.Add(Paragraphs077);
                _context.Add(Paragraphs078);
                _context.Add(Paragraphs079);
                _context.Add(Paragraphs080);
                _context.Add(Paragraphs081);
                _context.Add(Paragraphs082);
                _context.Add(Paragraphs083);
                _context.Add(Paragraphs084);
                _context.Add(Paragraphs085);
                _context.Add(Paragraphs086);
                _context.Add(Paragraphs087);
                _context.Add(Paragraphs088);
                _context.Add(Paragraphs089);
                _context.Add(Paragraphs090);
                _context.Add(Paragraphs091);
                _context.Add(Paragraphs092);
                _context.Add(Paragraphs093);
                _context.Add(Paragraphs094);
                _context.Add(Paragraphs095);
                _context.Add(Paragraphs096);
                _context.Add(Paragraphs097);
                _context.Add(Paragraphs098);
                _context.Add(Paragraphs099);
                _context.Add(Paragraphs100);
                _context.Add(Paragraphs101);
                _context.Add(Paragraphs102);
                _context.Add(Paragraphs103);
                _context.Add(Paragraphs104);
                _context.Add(Paragraphs105);
                _context.Add(Paragraphs106);
                _context.Add(Paragraphs107);
                _context.Add(Paragraphs108);
                _context.Add(Paragraphs109);
                _context.Add(Paragraphs110);
                _context.Add(Paragraphs111);
                _context.Add(Paragraphs112);
                _context.Add(Paragraphs113);
                _context.Add(Paragraphs114);
                _context.Add(Paragraphs115);
                _context.Add(Paragraphs116);
                _context.Add(Paragraphs117);
                _context.Add(Paragraphs118);
                _context.Add(Paragraphs119);
                _context.Add(Paragraphs120);
                _context.Add(Paragraphs121);
                _context.Add(Paragraphs122);
                _context.Add(Paragraphs123);
                _context.Add(Paragraphs124);
                _context.Add(Paragraphs125);
                _context.Add(Paragraphs126);
                _context.Add(Paragraphs127);
                _context.Add(Paragraphs128);
                _context.Add(Paragraphs129);
                _context.Add(Paragraphs130);
                _context.Add(Paragraphs131);
                _context.Add(Paragraphs132);
                _context.Add(Paragraphs133);
                _context.Add(Paragraphs134);
                _context.Add(Paragraphs135);
                _context.Add(Paragraphs136);
                _context.Add(Paragraphs137);
                _context.Add(Paragraphs138);
                _context.Add(Paragraphs139);
                _context.Add(Paragraphs140);
                _context.Add(Paragraphs141);
                _context.Add(Paragraphs142);
                _context.Add(Paragraphs143);
                _context.Add(Paragraphs144);
                _context.Add(Paragraphs145);
                _context.Add(Paragraphs146);
                _context.Add(Paragraphs147);
                _context.Add(Paragraphs148);
                _context.Add(Paragraphs149);
                _context.Add(Paragraphs150);
                _context.Add(Paragraphs151);
                _context.Add(Paragraphs152);
                _context.Add(Paragraphs153);
                _context.Add(Paragraphs154);
                _context.Add(Paragraphs155);
                _context.Add(Paragraphs156);
                _context.Add(Paragraphs157);
                _context.Add(Paragraphs158);
                _context.Add(Paragraphs159);
                _context.Add(Paragraphs160);
                _context.Add(Paragraphs161);
                _context.Add(Paragraphs162);
                _context.Add(Paragraphs163);
                _context.Add(Paragraphs164);
                _context.Add(Paragraphs165);
                _context.Add(Paragraphs166);
                _context.Add(Paragraphs167);
                _context.Add(Paragraphs168);
                _context.Add(Paragraphs169);
                _context.Add(Paragraphs170);
                _context.Add(Paragraphs171);
                _context.Add(Paragraphs172);
                _context.Add(Paragraphs173);
                _context.Add(Paragraphs174);
                _context.Add(Paragraphs175);
                _context.Add(Paragraphs176);
                _context.Add(Paragraphs177);
                _context.Add(Paragraphs178);
                _context.Add(Paragraphs179);
                _context.Add(Paragraphs180);
                _context.Add(Paragraphs181);
                _context.Add(Paragraphs182);

                _context.SaveChanges();
            }
        }
    }
}

    


