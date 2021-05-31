using System;

namespace Team_software_project
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("What do you want to do?: list / quit \n> ");
                string toDo = Console.ReadLine();
                if (toDo is "list")
                {

                    Animals();
                    CallAnimal();
                    break;


                }
                else if (toDo is "quit")
                {
                    Console.WriteLine("Have a nice day!");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid command!\n");
                }
            }


            Console.ReadLine();
        }
        static void Animals()
        {
            Console.WriteLine("\nWolf \nTiger \nBear \nCat \nDog \nBird\n");
        }

        static void CallAnimal()
        {

            Animal animals = new Animal();
            animals.AnimalSpecies();
            int nameCount = 0;
            int ComeHere = 0;

            while (true)
            {

                Console.Write("\nWhat do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]\n> ");
                string activity = Console.ReadLine();
                if (activity is "ComeHere")
                {
                    if (animals.status is "wild")
                    {
                        Console.WriteLine("\nWild animals don't come close to humans!");
                    }

                    else if (ComeHere > 0)
                    {
                        Console.WriteLine("\nThe animal is already with you!");
                    }
                    else
                    {
                        Console.WriteLine("\n" + animals.species + " came to the owner");
                    }
                    ComeHere++;

                }

                else if (activity is "GiveName")
                {

                    animals.Givename();
                    nameCount++;
                }

                else if (activity is "Eat")
                {
                    animals.Feed();
                    if (nameCount >= 1 && animals.status is "tame")
                    {
                        Console.WriteLine("\n" + animals.name + " gained weight 1 kg and weights " + animals.weight + " kg");
                    }
                    else if (nameCount == 0 && animals.status is "tame")
                    {
                        Console.WriteLine("\n" + animals.species + " gained weight 1kg and weights " + animals.weight + " kg");

                    }

                }

                else if (activity is "MakeSound")
                {

                    Console.WriteLine("\n" + animals.sound);

                }

                else if (activity is "TalkToOwner")
                {
                    if (animals.status == "tame")
                    {
                        Console.WriteLine("\n" + animals.sound);
                    }

                    else if (animals.status == "wild")
                    {
                        Console.WriteLine("\n" + "Wild animals have no owners!");
                    }

                }

                else if (activity is "MakeSound")
                {

                    Console.WriteLine("\n" + animals.sound);

                }

                else if (activity is "TalkToOwner")
                {
                    if (animals.status == "tame")
                    {
                        Console.WriteLine("\n" + animals.sound);
                    }

                    else if (animals.status == "wild")
                    {
                        Console.WriteLine("\n" + "Wild animals have no owners!");
                    }

                }

                else if (activity is "back")
                {
                    Animals();
                    CallAnimal();
                }
                else if (activity is "quit")
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }


        }


    }
}
