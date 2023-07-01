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
                new Paragraph { Content="You step through the wooden gate onto the hard packed dirt. You kick up dust as you walk towards the bright white enclosure. When you touch the door to step inside, it is skin-warm, like the enclosure itself has blood pumping just beneath the fresh coats of paint.", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="Inside is filled with sweet-smelling clean hay. A single animal is curled up atop the hay, a small brown fawn with bright white spots. You’ve woken it up. It lifts its head to gaze at you and bleats a greeting—or is it a question? ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="Yes, it's a question.", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="You fall to your knees as the words of a god fill your brain.", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="HAVE YOU AN OFFERING, OR HAVE YOU DISTURBED MY SLUMBER WITHOUT REASON?", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="An offering? Do you have anything on you that you can offer the fawn? You search your pockets frantically.", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="All you have is the park map and your ticket. These aren’t going to be enough. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="You have nothing to offer the little fawn, and so you shake your head. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="The fawn stands in a slow unfurling that reminds you more of a spider than any mammal you’ve seen. It has too many legs, and those legs are too long, with too many joints. It flicks its ears, and you fully collapse on the ground before it. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="You hear the gentle rustling of hay as the fawn approaches your prone form. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="You hear the crunch seconds before your body allows you to feel the white hot pain, shooting up your arm and filling your entire body. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="It’s a small blessing that you cannot see the gore of what the fawn is doing to your body, and a far larger blessing that everything goes black before it is finished. ", StoryId="PettingZooYesNoCC"},
                new Paragraph { Content="END", StoryId="PettingZooYesNoCC"},

                //PettingZooNo
                new Paragraph { Content="You’ve made a good decision for now, though something tells you that you should return with something worthwhile.", StoryId="PettingZooNo"},

                //HauntedHouseMain
                new Paragraph { Content=@"You’re not sure how anything in this place could be more haunted than the park itself, but you head off for the “Haunted House” marked on the map.", StoryId="HauntedHouseMain"},
                new Paragraph { Content="What you find isn’t really a house–it’s a large metal box that looks like it could be easily folded up and hauled off by a truck to a carnival in the next state–or at least it once could have been. Rust and years and the woods have seeped into its cracks, and if someone attempted to fold it up and cart it away it wouldn’t survive the first pothole it encountered on its way out of the park. ", StoryId="HauntedHouseMain"},
                new Paragraph { Content="The metal structure is gaudily painted with faux stonework, cartoon skeletons peeking from around corners and through barred windows. The fading of years hasn’t diminished this old ride’s charm, and it’s a surprisingly welcome sight, a carnival staple planted amongst these claustrophobic hills. ", StoryId="HauntedHouseMain"},
                new Paragraph { Content=@"And, right at the entrance, an old, old man with hair the color of yellowed receipts waves cheerfully at you. “Step right up, step right up! Have the fright of your life!” His face is so wrinkled it looks like melted wax, and on his polo shirt is a name tag that reads “Gene.” He really seems quite nice, and enthusiastic to get you on this old ride. ", StoryId="HauntedHouseMain"},
                new Paragraph { Content="Will you ride the Haunted House?", StoryId="HauntedHouseMain"},

                //HauntedHouseYes
                new Paragraph { Content="You climb the metal steps up to the entrance of the ride. From here, you can see there is actually a cart on a track leading towards a door painted to look as though it’s wood. There’s even a safety bar on the cart, implying the ride might reach speeds for which a safety bar is required. You climb into the cart and Gene cheerfully checks the safety bar before stepping back to a control panel and starting the ride. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Mechanical whirs and clinks and roars sound as your cart is pulled forward. The metal door swings open at the last second, thrusting you into cool darkness.", StoryId="HauntedHouseYes"},
                new Paragraph { Content="And then the air shifts and the darkness adjusts. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You’re outside, on a large lawn in the dead of night. The moon is high and bright, illuminating a large manor house. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Not an imitation of a manor house, not a show scene on a dark ride, you’re really there. The only thing connecting you back to your previous surroundings is the cart, but there is no track and you are completely still, facing the scene before you.", StoryId="HauntedHouseYes"},
                new Paragraph { Content="The manor house isn’t especially large or imposing. The great expanse of the lawn is between you and the house, and the wind plays through it in a pleasant way as your eyes adjust to the moon-bright darkness. Trees are on either side of the house, and it is well-kept with three rows of plain windows catching a bit of the moonlight and reflecting it back towards you. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="All in all, a pleasant, if confusing, place to be. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You notice the person crawling towards the manor house with a jolt. It seemed like there was no one there just moments ago, but now you see that a figure on all fours in a black robe-like garment is right before you. You are extremely grateful that the figure is moving away from you, for there is an extreme wrongness in the way it moves, a jittering, dragging sort of crawl that reminds you of glitched analog camera footage. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You close your eyes, perhaps willing yourself somewhere else, but you feel no change in the air. When you finally open your eyes again you are alone, but there is evidence for where your companion has gone: the first story window, to the left of the door, is open. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Oh, God, it’s gotten in. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="And you are left waiting for what feels like hours. The safety bar on the cart is indeed clapped down fast and resists all attempts at escape you can muster. You must wait, staring into the darkness of the open window, wondering what the thing is doing inside. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Your attention drifts with time, and is only snapped back after the thing has exited the house again. It no longer crawls, and it moves quite swiftly, though its movements are still jittery and clumsy. The robe reaches only its knees where it falls into tatters. Long, confident strides on thin white legs brings it towards you. A hood obscures much of its emaciated face, but you can see enough. Oh, God, you can see enough. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="And in its skinny arms, an unmoving baby. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Is it asleep?", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Is the baby asleep?", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You can't tell.", StoryId="HauntedHouseYes"},
                new Paragraph { Content=@"You can’t tell at all, and even if you were brave enough (surely, you are brave enough) you cannot save this child, because you’re stuck in this damn cart. You cannot run to save yourself (surely, you would never do this) because you’re stuck in this damn cart. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content=@"But you do not need to worry, for you’re not actually in danger. The– person, figure, skeleton, corpse– the thing simply passes you by, confident in its purpose. It does not even turn its head to acknowledge you. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="The baby does not move or make a sound.", StoryId="HauntedHouseYes"},
                new Paragraph { Content="The wind blows hard, suddenly whipping the grass around and causing you to close your eyes against the granules blasted against your face. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="Mechanical whirs and clinks and roars and your cart exits through a metal door painted to look as though it's made of wood. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="The safety bar lifts easily once the cart comes to a stop. Gene is nowhere to be seen. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You stagger out of the cart on unsteady legs, feeling as though you just rode a modern high-speed roller coaster. ", StoryId="HauntedHouseYes"},
                new Paragraph { Content="From behind you, you hear someone else stand up from the cart and walk onto the metal floor. In the corner of your eye, a black and white blurred figure steps beside you.", StoryId="HauntedHouseYes"},
                new Paragraph { Content="You turn your head, and of course you are alone. ", StoryId="HauntedHouseYes"},

                //HauntedHouseNo
                new Paragraph { Content="What a shame. It seemed like it would be fun.", StoryId="HauntedHouseNo"},

                //OldMillMain
                new Paragraph { Content="The Old Mill Ride has all the appearances of literally being in an old mill, a large wooden structure with a water wheel on the outside being pushed along by a not insignificant stream. There is an opening under the structure that lets the stream flow under and presumably through it. ", StoryId="OldMillMain"},
                new Paragraph { Content="There is none of the expected queue area that similar rides possess, just a yawning empty doorway to darkness. The only indication that this is indeed an attraction at a theme park is a very old paint job on the side of the building.", StoryId="OldMillMain"},
                new Paragraph { Content=@"“YE OLDE MILL” is painted in overwrought imitation medieval text across the aged wood.", StoryId="OldMillMain"},
                new Paragraph { Content="You enter through the wide doorway. It takes a moment for your eyes to adjust to the gloom inside, despite the rest of the park not being particularly bright. ", StoryId="OldMillMain"},
                new Paragraph { Content=@"The room is empty save for an extremely old man. He wears a faded polo shirt with a nametag that reads “Gene.” He looks tired, and greets you only with a slight wave of his hand. His sallow skin is the color of yellowed receipts. ", StoryId="OldMillMain"},
                new Paragraph { Content=@"He is standing by the stream, which is flanked on both sides by a poured concrete floor. A small boat waits by him, its movement down the stream hampered by a bar that must be manually lifted to let it continue into the depths of the ride. ", StoryId="OldMillMain"},
                new Paragraph { Content=@"“I miss my brother,” Gene confides to you as you approach, his voice bearing all the weight of his years. “I’m so confused now. Ray always knew what to do. I feel like I’m just going in circles.” He gestures to the boat and sighs. “Climb in.”", StoryId="OldMillMain"},
                new Paragraph { Content="Will you ride the Old Mill?"},

                //OldMillNo
                new Paragraph { Content="You must return here eventually, but perhaps now isn’t the time.", StoryId="OldMillNo"},

                //OldMillSaloon1
                new Paragraph { Content="Gene somberly lifts the bar and your boat begins its journey down the stream. There is no safety bar on the boat, and the concrete floor is level with it. It would be very easy to stop the boat and get out at any time during this ride. ", StoryId="OldMillSaloon1"},
                new Paragraph { Content=@"You pass through a short tunnel and are soon floating through an old west style saloon scene. A group of mannequins sit at a table playing a card game, one serving as bartender is busy pouring whiskey for a patron at the bar, and a particularly aged mannequin in a red dress stands atop a stage. A fuzzy recording of a woman singing “House of the Rising Sun” is playing over speakers you can’t see.", StoryId="OldMillSaloon1"},
                new Paragraph { Content=@"Type “continue” to let your boat float on to the next scene, type “get out” to climb out of the boat and into the scene.", StoryId="OldMillSaloon1"},

                //OldMillSaloon2
                new Paragraph { Content="You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ", StoryId="OldMillSaloon2"},
                new Paragraph { Content="The recording immediately sounds clearer now that you’re level with the scene. The performer is beginning the second verse, and the quality of her voice causes you to turn and look at the stage.", StoryId="OldMillSaloon2"},
                new Paragraph { Content=@"A young woman in a red dress is standing there singing where the mannequin used to be. “If I had only listened to what my mama said, I’d be at home today. But bein’ so young and foolish, my Lord, let a gambler lead me astray.”", StoryId="OldMillSaloon2"},
                new Paragraph { Content=@"“Hey!” The bartender calls to you. He’s finished pouring the drink and is passing it to the man in front of him. “Find a seat or buy a drink, but quit blockin’ the door!” ", StoryId="OldMillSaloon2"},
                new Paragraph { Content="And you are blocking the door, aren’t you? You move to the bar past the card players. ", StoryId="OldMillSaloon2"},
                new Paragraph { Content=@"The man who just received his drink is eyeing you. “You okay there, pardner? You look like you’ve seen a ghost.”", StoryId="OldMillSaloon2"},
                new Paragraph { Content="You suppose the best thing to do is order a drink, and you do, before turning to the man who spoke and beginning to tell him all about the strange day you’ve been having. ", StoryId="OldMillSaloon2"},
                new Paragraph { Content="END", StoryId="OldMillSaloon2"},

                //OldMillJail1
                new Paragraph { Content="Continuing the old west theme, you find yourself looking at the inside of a jail cell. A mannequin dressed as a sheriff stands on the other side of the bars looking in at you and the single mannequin sitting on the dirt floor inside. ", StoryId="OldMillJail1"},
                new Paragraph { Content=@"Type “continue” to let your boat float on to the next scene, type “get out” to climb out of the boat and into the scene.", StoryId="OldMillJail1"},

                //OldMillJail2
                new Paragraph { Content="You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ", StoryId="OldMillJail2"},
                new Paragraph { Content="You immediately feel tired as you overlook the two mannequins. You decide to join the mannequin on the floor and sit down beside it. ", StoryId="OldMillJail2"},
                new Paragraph { Content="Your limbs feel stiff, and stretching does not relieve this feeling. Your skin catches the light as you stretch. It’s shiny. In fact, it looks just like varnished wood. You rap your knuckles against the shiny spot on your skin, and it sounds just like two pieces of varnished wood being clunked together. ", StoryId="OldMillJail2"},
                new Paragraph { Content="You don’t have much time to worry about this development, because the exhaustion is really taking hold now. You’re so tired your limbs are wooden, both literally and figuratively. A bit of a nap here couldn’t hurt.", StoryId="OldMillJail2"},
                new Paragraph { Content="END", StoryId="OldMillJail2"},

                //OldMillGraveyard1
                new Paragraph { Content="The next scene is a graveyard complete with a skeleton in a cowboy hat propped up against the fence. A painted cardboard moon hangs high over the scene, and a painted backdrop shows a forest in the distance.", StoryId="OldMillGraveyard1"},
                new Paragraph { Content=@"Type “Continue” to let your boat float on to the next scene, type “Get Out” to climb out of the boat and into the scene.", StoryId="OldMillGraveyard1"},

                //OldMillGraveyardDeerGodHelp
                new Paragraph { Content="You reach out to the concrete on either side to slow the boat, and easily clamber out. The boat continues down the stream without you. ", StoryId="OldMillGraveyardDeerGodHelp"},
                new Paragraph { Content="This scene is particularly poorly made. From the boat you could make out the corrugated sides of the gravestones, and here among the graves it’s even more obvious that they are just painted cardboard. ", StoryId="OldMillGraveyardDeerGodHelp"},
                new Paragraph { Content=@"The forest backdrop is more intriguing, as it is painted skillfully by someone who really should be painting for somewhere other than Hill Cavern Fair. You can make out individual plants and trees, and– there is some animal in the forest, watching you. ", StoryId="OldMillGraveyardDeerGodHelp"},
                new Paragraph { Content="You are drawn to that spot on the backdrop, heading forward to look closer. By the time you realize something is wrong, you’re already in the forest.", StoryId="OldMillGraveyardDeerGodHelp"},
                new Paragraph { Content=@"A stag stands before you, twice your height and with twice as many legs as it should have. Its antlers are tall and many-branched, extending up into the trees where you are unable to see them end. Its eyes glow without any light source to reflect back.", StoryId="OldMillGraveyardDeerGodHelp"},
                new Paragraph { Content="Its voice fills your mind.", StoryId="OldMillGraveyardDeerGodHelp"},

                //OldMillGraveyardDeerGodHelpYes
                new Paragraph { Content=@"The Deer God kneels before you, its many jointed legs folding down unnaturally until it reaches a level where you could easily climb upon its back.", StoryId="OldMillGraveyardDeerGodHelpYes"},
                new Paragraph { Content="You have no choice but to climb on. You do not expect it to actually take you home, but perhaps it will take you somewhere better than here.", StoryId="OldMillGraveyardDeerGodHelpYes"},
                new Paragraph { Content="END", StoryId="OldMillGraveyardDeerGodHelpYes"},

                //OldMillGraveyardDeerGodHelpNo
                new Paragraph { Content="I HAVE BEEN WAITING FOR YOU, SERVANT. FOLLOW ME.", StoryId="OldMillGraveyardDeerGodHelpNo"},
                new Paragraph { Content="You have no choice but to follow the creature as it leads you deeper into the forest.", StoryId="OldMillGraveyardDeerGodHelpNo"},
                new Paragraph { Content="END", StoryId="OldMillGraveyardDeerGodHelpNo"},

                //OldMillFinal
                new Paragraph { Content="The boat reaches a dead end. There are no more scenes, only a black wall in front of you and a door to your right.", StoryId="OldMillFinal"},
                new Paragraph { Content="You have no choice but to climb out and go through the door. ", StoryId="OldMillFinal"},
                new Paragraph { Content=@"The sun shines brightly as you walk out onto the gravel. You’re at the entrance to Hill Cavern Fair, and a young man in a bright yellow polo shirt grins and waves at you. On his chest is a name tag that reads “Gene.”", StoryId="OldMillFinal"},
                new Paragraph { Content=@"“Where’ve you been, Ray? I haven’t seen anyone yet!”", StoryId="OldMillFinal"},
                new Paragraph { Content=@"You smile and pat your brother’s shoulder. “No need to be so anxious, Gene. It’s our first day. We’ve got lots of days ahead of us. If the tourists don’t come today, there’s tomorrow, and the day after that.”", StoryId="OldMillFinal"},
                new Paragraph { Content=@"Gene nods, always attentive to your advice. “You’re right, of course, I just really want our opening day to be grand.”", StoryId="OldMillFinal"},
                new Paragraph { Content=@"“It can be grand with just the two of us,” you promise, leading the way into your park.", StoryId="OldMillFinal"},
                new Paragraph { Content="END", StoryId="OldMillFinal"}
            };

            foreach (var paragraphData in paragraphs)
            {
                context.Paragraph.Add(paragraphData);
            }
            context.SaveChanges();




        }


    }
}

