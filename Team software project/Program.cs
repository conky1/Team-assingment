using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           
            
           /* Console.Write("Which animal do you want to see? \n> ");
            string animal = Console.ReadLine();*/

            Elukat elukka = new Elukat();
            elukka.AnimalSpecies();
            int nameCount = 0;
            int ComeHere = 0;
            
            while (true)
            {

                Console.Write("\nWhat do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]\n> ");
                string activity = Console.ReadLine();
                if (activity is "ComeHere")
                {
                   
                    if (ComeHere > 0)
                    {
                        Console.WriteLine("The animal is already with you!");
                    }
                    else
                    {
                        Console.WriteLine("\n" + elukka.species + " came to the owner");
                    }
                    ComeHere++;

                }

                else if(activity is "GiveName")
                {
                    /*Console.Write("Give a name ");
                    string petName = Console.ReadLine();
                    Elukat name = new Elukat() { name = petName };*/
                    elukka.Givename();
                    nameCount++;
                }

                else if(activity is "Eat")
                {
                    elukka.Feed();
                    if (nameCount >= 1)
                    {
                        Console.WriteLine("\n" + elukka.name + " gained weight " + elukka.weight + " kg");
                    }
                    else
                    {
                        Console.WriteLine("\n" + elukka.species + " gained weight " + elukka.weight + " kg");

                    }
                    
                }

                else if(activity is "back")
                {
                    Animals();
                    CallAnimal();
                }
                else if(activity is "quit")
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
