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
                new Paragraph { Content = @"Type “dread” to continue into Hill Cavern Fair, type “loss” to get back into your car and try to find your way back home.", StoryId = "Intro" },

                //ChoiceDread
                new Paragraph { Content = "You step forward under the sign and Hill Cavern Fair opens up to you amidst the woods. You first notice the darkness of the park–you’ve never seen a theme park so shaded by trees and hills. You would expect from the name that you would be on a hill, or maybe there would be a cave nearby? but you see no indication of either. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "In fact, the park seems surrounded by hills, set in the lowest places among them. The path is now paved, but it was paved long ago, and is beset with potholes and weeds. A small turnstile blocks your way, and this is surely where your exploration will be stopped, because there is no way this place is open. Your car was the only one in the parking lot, and nothing here seems maintained. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = @"“It’s free today,” a cracked, aged voice says, from your left, while you were looking right. ", StoryId = "ChoiceDread" },
                new Paragraph { Content = "You jump and turn. A man stands beside you, in a faded polo shirt. He is unbelievably old, bent by the weight of years and overwhelmingly the color of yellowed receipts, from his tar-stained teeth to his liver-spotted skin. A name tag on his chest says /“Eugene./” ", StoryId = "ChoiceDread" },
                new Paragraph { Content = @"You don’t have a chance to ask for more information as he thrusts a ticket and a park map in your hand and gestures to the turnstile. “Free on Tuesdays.” ", StoryId = "ChoiceDread" },
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
                new Paragraph { Content = "END", StoryId = "ChoiceLoss" },

                //SnackStandMain
                new Paragraph { Content="You head down the cracked asphalt path in the direction the map promises a snack stand. You’re unsure if a place like this is somewhere you would like to actually eat food, but curiosity leads you on to the little booth tucked into a mass of trees and vines that seem only days from swallowing the building entirely. The vines are so thick along the cracked and aged wood that you wonder how an employee could get inside the building. Flecks of paint hint that at one time this shack was brightly colored, but now exposed gray wood and rusted nails are its defining features.", StoryId="SnackStandMain"},
                new Paragraph { Content="You’re sure this place is completely closed until you catch sight of the extremely improbable man behind the counter. ", StoryId="SnackStandMain"},
                new Paragraph { Content=@"An old man with skin the color of yellowed receipts is hunched over an equally ancient cash register. His name tag reads “Gene.” To his left, a hand painted, chipped sign advertises the wares of the Snack Stand.", StoryId="SnackStandMain" },
                new Paragraph { Content="SLUSHEE — 30¢", StoryId="SnackStandMain"},
                new Paragraph { Content="CARAMEL CORN — 25¢", StoryId="SnackStandMain"},
                new Paragraph { Content="COTTON CANDY — 15¢", StoryId="SnackStandMain"},
                new Paragraph { Content=@"Before you can ask if the prices are a joke, the man says, “The slushees are new. Added ‘em only a little while ago. They’re cherry flavored.” He puffs himself up, standing at his full height, which is still shorter than you. ", StoryId="SnackStandMain"},
                new Paragraph { Content=@"What'll it be?", StoryId="SnackStandMain"},

                //SnackStandSlushee
                new Paragraph { Content="The slushee machine does not, in fact, look new. It looks as old and dusty as the rest of the place, and you question if it’s ever been cleaned in the however-many-years it’s been here. The frozen drink swirling inside is red, but the rim of the drink spout looks like it has some sort of black film on it–mold, or mildew.", StoryId = "SnackStandSlushee"},
                new Paragraph { Content="Do you want to order a slushee?", StoryId="SnackStandSlushee"},
                new Paragraph { Content="It really was only 30 cents, but you have a feeling if you drank more than your initial sip your medical bills would be much more expensive. It tastes exactly like wet laundry forgotten in a washing machine smells. You throw the cup away as soon as you leave the snack stand.", StoryId="SnackStandSlushee"},
                new Paragraph { Content="A good choice, really.", StoryId="SnackStandSlushee"},

                //SnackStandCaramelCorn
                new Paragraph { Content="There are popcorn boxes behind the man that you assume are filled with caramel corn. They look dusty–are those spiderwebs? Even so, you feel a draw to the caramel corn. It feels like something worthwhile to have.", StoryId="SnackStandCaramelCorn"},
                new Paragraph { Content="Do you want to order caramel corn?", StoryId="SnackStandCaramelCorn"},
                new Paragraph { Content="It really only cost 25 cents. The box is dusty and cobwebby, but the caramel corn inside smells good, and when you eat some it’s satisfying, with a sweet crunch. You carry the box with you throughout the rest of the park.", StoryId="SnackStandCaramelCorn"},

                //SnackStandCottonCandy
                new Paragraph { Content="Bags of cotton candy hang off the ceiling of the snack stand. They look perfectly normal, and even relatively fresh, despite there being no cotton candy machine in sight.", StoryId="SnackStandCottonCandy"},
                new Paragraph { Content="Do you want to order cotton candy?", StoryId="SnackStandCottonCandy"},
                new Paragraph { Content="For 15 cents you get a pretty big bag of pink cotton candy. It tastes just like all the other cotton candy you’ve ever tasted–sweet and light.", StoryId="SnackStandCottonCandy"},
                new Paragraph { Content="As you walk away from the snack stand, picking bits of cotton candy off the cloud and letting it dissolve in your mouth, you’re struck by how crowded the place is. Maybe you just came right as they opened and beat the initial crowds– because now there are people on all sides of you. It’s really quite bustling. Mostly families, kids running by in excitement towards this or that attraction, adults laughing and calling for them to wait up– you blink as the sun hits you right in your eyes and–", StoryId="SnackStandCottonCandy"},
                new Paragraph { Content="Silence. Empty asphalt. Shadows from the hills, and clouds overhead.", StoryId="SnackStandCottonCandy"},
                new Paragraph { Content="No, you were mistaken. Hill Cavern Fair is as empty and forlorn as when you first stepped inside. In fact, you’re sure it’s only you and Gene here.", StoryId="SnackStandCottonCandy"},

                //GrandStageMain
                new Paragraph { Content="The Grand Stage appears to be neither grand, nor a stage.", StoryId="GrandStageMain"},
                new Paragraph { Content=@"What you find in the place marked on the map is a small outdoor amphitheater of the kind often found in small parks: three levels of concrete seating set into a hill with a flat paved area in the center that it would be rather generous to term a “stage”. The woods are encroaching more into this area than any of the others: there are vine-choked trees on all sides of the paved area, and cracks in the concrete as it continues to lose the fight against the roots of those trees. The vines hang down into the space, and various plants are sprouting from the cracks. Piles of years of leaves and other rotting plant matter line the edges of the concrete.", StoryId="GrandStageMain"},
                new Paragraph { Content="This seems more to be a small rest area than an attraction, but sure enough there is a sign amid the weeds on the stage that seems to indicate a performance will occur here in five minutes.", StoryId="GrandStageMain"},
                new Paragraph { Content="Will you stay for the performance?", StoryId="GrandStageMain"},

                //GrandStageYes
                new Paragraph { Content="You wait for much longer than five minutes, but the wait is restorative and so you don’t leave when the time drags on. You find yourself relaxing back against the concrete, following the journeys of the cracks across it with your eyes.", StoryId="GrandStageYes"},
                new Paragraph { Content="You only look up when you hear a throat being cleared.", StoryId="GrandStageYes"},
                new Paragraph { Content=@"An old, old man with a polo shirt so faded and soiled it’s the color of yellowed receipts stands before you. On his chest is a name tag that reads “Gene.”", StoryId="GrandStageYes"},
                new Paragraph { Content="He stands on the stage with all the dignity and air of a storied actor. He begins his story in a booming, authoritative voice that allows no interruption.", StoryId="GrandStageYes"},
                new Paragraph { Content=@"“In 1947, Brothers Raymond and Eugene Hill bought a large parcel of land just ten miles from the newly established Mammoth Cave National Park. They believed the land to be untouched woodland, ripe for development into a variety of attractions that would surely yield unimaginable profit as the tourists poured into Kentucky for their visits to what would eventually be known as the world’s longest cave system.” He lets this statement hang in the air for a few moments, presumably for you to absorb the grandeur of the region you find yourself in.", StoryId="GrandStageYes"},
                new Paragraph { Content=@"“Shortly after the brothers Hill opened Hill Cavern Fair, they realized their mistake, for in the long, uncharted caverns beneath our feet hide secrets. For millennia the fragile limestone lining empty pockets in the earth has given way beneath the feet of both animal and man. Those who avoid the sinkholes aren’t safe– the Underneath claims bodies by enchanting explorers with its caverns and by courting powerful men with its coal.", StoryId="GrandStageYes"},
                new Paragraph { Content=@"“Here, where the caverns yawn wide, where the bodies accumulate, something was stirred. Something hungry and old and greedy crawled from its gore-filled hole and took a form it thought was less threatening to its prey and settled in the heart of Hill Cavern Fair, a spider waiting upon its web.”", StoryId="GrandStageYes"},
                new Paragraph { Content="Gene goes silent after this last declaration, staring at a spot behind you.", StoryId="GrandStageYes"},
                new Paragraph { Content="After a few minutes of silence, it seems like a good idea for you to leave.", StoryId="GrandStageYes"},

                //GrandStageNo
                new Paragraph { Content="Nothing that happens in this place could be good. You turn away and head back to the main path.", StoryId="GrandStageNo"},

                //PettingZooMain
                new Paragraph { Content="The petting zoo seemed like a safe choice, but as you approach it now you’re filled with the same dread you felt making the decision to come inside Hill Cavern Fair. The Petting Zoo has no attendant, and no animals in sight. A cheery hand painted sign hangs lopsided by one nail over the entrance.", StoryId="PettingZooMain"},
                new Paragraph { Content="HILL CAVERN PETTING ZOO", StoryId="PettingZooMain"},
                new Paragraph { Content="The entire area is surrounded by a wooden fence, and the surrounding forest, despite its enthusiasm for the other buildings in this park, does not encroach beyond it. The ground is dry and dusty, with none of the animal droppings found at similar petting zoos across the world.", StoryId="PettingZooMain"},
                new Paragraph { Content="On the far side of the animal enclosure is a small building– you assume a shelter for the animals– in surprisingly pristine condition. It looks like it has recently been painted, or maybe even recently built. It’s solid white and has a similarly hand painted sign.", StoryId="PettingZooMain"},
                new Paragraph { Content="PLEASE— DON’T FEED THE ANIMALS!", StoryId="PettingZooMain"},
                new Paragraph { Content="THANK YOU, MGMT", StoryId="PettingZooMain"},
                new Paragraph { Content="There are of course no animals in sight, only an empty enclosure with a foreboding air that twists your stomach. Something is very, very wrong here, more wrong than the cumulative wrongness of the rest of Hill Cavern Fair.", StoryId="PettingZooMain"},
                new Paragraph { Content="Will you explore further?", StoryId="PettingZooMain"},

                //PettingZooYesHasCC
                new Paragraph { Content="You step through the wooden gate onto the hard packed dirt. You kick up dust as you walk towards the bright white enclosure. When you touch the door to step inside, it is skin-warm, like the enclosure itself has blood pumping just beneath the fresh coats of paint.", StoryId="PettingZooYesHasCC"},
                new Paragraph { Content="Inside is filled with sweet-smelling clean hay. A single animal is curled up atop the hay, a small brown fawn with bright white spots. You’ve woken it up. It lifts its head to gaze at you and bleats a greeting—or is it a question?", StoryId="PettingZooYesHasCC"},
                new Paragraph { Content="Yes, it’s a question.", StoryId="PettingZooyesHasCC"},
                new Paragraph { Content="You fall to your knees as the words of a god fill your brain.", StoryId="PettingZooYesHasCC"},
                new Paragraph { Content="HAVE YOU AN OFFERING, OR HAVE YOU DISTURBED MY SLUMBER WITHOUT REASON?", StoryId="PettingZooYesHasCC"},
                new Paragraph { Content="An offering? All you have on you is the caramel corn! Will that be enough?", StoryId="PettingZooYesHasCC"},
                new Paragraph { Content="Will you offer the Deer God your caramel corn?", StoryId="PettingZooYesHasCC"},

                //PettingZooYesHasCCYes
                new Paragraph { Content="With trembling hands, you pull the small, dusty box of caramel corn from your pocket and hold it out to the little fawn.", StoryId="PettingZooYesHasCCYes"},
                new Paragraph { Content="The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it.", StoryId="PettingZooYesHasCCYes"},
                new Paragraph { Content="You hear the gentle rustling of hay as the fawn approaches your prone form.", StoryId="PettingZooYesHasCCYes"},
                new Paragraph { Content="A soft crunch near your ear as it eats some of the spilled caramel corn. More rustling, and you realize it’s gently snuffling the inside of the box as it eats more.", StoryId="PettingZooYesHasCCYes"},
                new Paragraph { Content="You wake up outside the enclosure. In your pocket is a green rock with an image of an eight-legged stag engraved upon it, and your caramel corn is gone.", StoryId="PettingZooYesHasCCYes"},

                //PettingZooYesHasCCNo
                new Paragraph { Content="Surely the caramel corn wouldn’t be enough. Besides, the sign said not to feed the animals!", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="You have nothing to offer the little fawn, and so you shake your head.", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it.", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="You hear the gentle rustling of hay as the fawn approaches your prone form.", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="You hear the crunch seconds before your body allows you to feel the white hot pain, shooting up your arm and filling your entire body.", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="It’s a small blessing that you cannot see the gore of what the fawn is doing to your body, and a far larger blessing that everything goes black before it is finished.", StoryId="PettingZooYesHasCCNo"},
                new Paragraph { Content="END", StoryId="PettingZooYesHasCCNo"},

                //PettingZooYesNoCC





            };


        }
    }
}
