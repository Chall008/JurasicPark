## Problem

I need to make an application that keeps track of dinosaurs in Jurassic Park

## Examples

I need a class for dinos

I need to take into account;

- Name
- DietType - carnivore, herbivore
- When Acquired
- Weight
- Enclosure number

Incorporate some features;

- Add
- View
- Remove
- Transfer
- Summary
- Quit

Keep track of dinos in a List<Dinosaurs>

## Data

- 'Name' - string
- 'DietType' - string
- 'When Acquired' - date
- 'Weight' - int
- 'Enclosure number' - int

these attributes will be in the 'class' called Dinosaurs
the 'Dinos' will be placed in a List<Dinosaurs>

## Algorithm

Create a class to represent your dinosaurs. The class should have the following properties

- Name
- DietType - This will be "carnivore" or "herbivore"
- WhenAcquired - This will default to the current time when the dinosaur is created
- Weight - How heavy the dinosaur is in pounds.
- EnclosureNumber - the number of the pen the dinosaur is in

Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.

Keep track of your dinosaurs in a List<Dinosaur>.

When the console application runs, it should let the user choose one of the following actions:

View

- This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.
  Add
- This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
  Remove
- This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
  Transfer
- This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
  Summary
- This command will display the number of carnivores and the number of herbivores.
  Quit
- This will stop the program
