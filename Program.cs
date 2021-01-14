using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{

    class Dinosaur
    {


        // Create a class to represent your dinosaurs. The class should have the following properties

        //- 'Name' - string
        public string Name { get; set; }

        // - 'DietType' - string
        // - carnivore & herbivore

        public string DietType { get; set; }

        // - 'When Acquired' - DateTime
        public DateTime WhenAcquired = DateTime.Now;


        // - 'Weight' - int

        public int Weight { get; set; }
        // - 'Enclosure number' - int
        public int EnclosureNumber { get; set; }

    }




    class Program
    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            // Keep track of dinos in a List<Dinosaurs>

            var dinosaurs = new List<Dinosaur>()
            {

            };

            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {

                BannerMessage("Welcome to Jurassic Park!! ");
                // Incorporate some features;
                Console.WriteLine();
                Console.WriteLine("As you can see below we have some options for you to chose!");
                Console.WriteLine();
                // - Add
                Console.WriteLine("ADD:");
                // - View
                Console.WriteLine("VIEW:");
                // - Remove
                Console.WriteLine("REMOVE:");
                // - Transfer
                Console.WriteLine("TRANSFER:");
                // - Summary
                Console.WriteLine("SUMMARY:");
                // - Quit
                Console.WriteLine("QUIT:");
                Console.WriteLine();
                Console.WriteLine("What would you like to use? ");
                var choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "QUIT")
                {

                    userHasChosenToQuit = true;


                }

                // Add
                // - This command will let the user type in the information for a dinosaur and add it to the list. 
                // - Prompt for the Name Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
                if (choice == "ADD")
                {
                    Console.WriteLine("What is the name? ");
                    var newDinoName = Console.ReadLine().Trim();

                    Console.WriteLine("Is it a carnivore or a herbivore? ");
                    var newDietType = Console.ReadLine();

                    Console.WriteLine("What is their weight? ");
                    var newWeightString = Console.ReadLine();
                    var newWeight = int.Parse(newWeightString);

                    Console.WriteLine("What is their enclosure number? ");
                    var newEnclosureNumberString = Console.ReadLine();
                    var newEnclosureNumber = int.Parse(newEnclosureNumberString);


                    var newDino = new Dinosaur()
                    {
                        Name = newDinoName,
                        DietType = newDietType,
                        Weight = newWeight,
                        EnclosureNumber = newEnclosureNumber,
                    };

                    dinosaurs.Add(newDino);
                }

                switch (choice)
                {
                    case "VIEW":
                        // - This command will show the all the dinosaurs in the list, ordered by WhenAcquired. 
                        // - If there aren't any dinosaurs in the park then print out a message that there aren't any.



                        // Makes a new list with all the movies ordered by their title
                        dinosaurs.OrderBy(dino => dino.WhenAcquired);

                        foreach (var dino in dinosaurs)
                        {
                            Console.WriteLine("Here is a dinosaur!");
                            Console.WriteLine($" {dino.Name}, {dino.DietType}, {dino.Weight}, {dino.EnclosureNumber} {dino.WhenAcquired}");

                        }
                        break;

                    case "REMOVE":
                        // - This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
                        Console.WriteLine("Which dinosaur would you like to remove? ");
                        var dinoRemove = Console.ReadLine().Trim();
                        var deletedDino = dinosaurs.Find(foundDino => foundDino.Name == dinoRemove);
                        //called from list and then.Remove(d)
                        dinosaurs.Remove(deletedDino);


                        // go into list of dinosaurs
                        // - list method that will allow me to find the firs instance that will allow me to find a dino 

                        break;

                    case "TRANSFER":
                        // - This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
                        Console.WriteLine("Which dinosaur would you like to choose? ");
                        var dinoTransfer = Console.ReadLine().Trim();
                        var whichDinosaur = dinosaurs.Find(foundTransferDino => foundTransferDino.Name == dinoTransfer);
                        // newDinoEnclosure.EnclosureNumber = the users input enclosure number

                        Console.WriteLine("What enclosure are you transfering them to? ");
                        // I want to change the current dinos enclosure number and update
                        var updatedEnclosure = Console.ReadLine();
                        whichDinosaur.EnclosureNumber = int.Parse(updatedEnclosure);



                        //var selected = dinosaurs.Where(newEnclosure => newEnclosure.EnclosureNumber ).ToList();
                        //selected.ForEach(item => items.Remove(item));
                        //otherList.AddRange(selected);



                        //newDinoEnclosure.EnclosureNumber = updatedEnclosure;

                        break;

                    case "SUMMARY":
                        // - This command will display the number of carnivores and the number of herbivores.
                        Console.WriteLine("Stated below are all the dinosaurs sorted by diet. ");
                        Console.WriteLine();
                        var carnivores = dinosaurs.Where(carnivoreDino => carnivoreDino.DietType == "carnivore");
                        var numberOfHerbivores = dinosaurs.Count() - carnivores.Count();
                        Console.WriteLine($"There is {carnivores.Count()} carnivore(s) and {numberOfHerbivores} herbivore(s) currently at jurassic Park!");






                        break;

                    default:
                        break;

                }





                //Add an option to view all the Dinosaurs in a given enclosure number.



                //Console.WriteLine("There are none dinosaurs with this information");

            }

        }
    }
}
