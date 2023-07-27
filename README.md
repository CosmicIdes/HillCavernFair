My project will be an update to my ChooseYourPath project that I submitted for Software Dev Course 1. This project is a choose-your-own-adventure style text game in which the player can select what way they want to go.


## Requirements:


_You must create at least one class (not including the default class in a new project), then create at least one object of that class and populate it with data from a database. You must use or display the data in your application.  You are only required to have 1 table (one entity). Hint: If using Entity Framework or other object relational mappers, you must create classes to get data from a database:_ 
This requirement will be fulfilled with the class for the story objects being pulled from a database.


_Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application:_ This will be accomplished throughout the story.



## Picked Features(3):


_Implement a regular expression (regex) to ensure a field either a phone number or email address is always stored and displayed in the same format:_ I will ask for email at the start of the game and use regex to ensure the email is in a valid format.


_Implement a log that records errors, invalid inputs, or other important events and writes them to a text file:_ I will have the user’s choices logged and written to a text file so they can review what they did and decide what else to try on a subsequent play-through.


_Add comments to your code explaining how you are using at least two of the SOLID principles:_ Since this is an update to an existing project, refactoring with SOLID in mind seems like a great idea!


## Bonus Features:

_Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program._ I populate an inventory list with items you've acquired during your visit, and sometimes special things happen if you have a certain item in your inventory.




## Extra Things:


I will be making the console prettier using a nuget package called Spectre Console, and using the SQLite nuget package for the database. Serilog will be used for logging.