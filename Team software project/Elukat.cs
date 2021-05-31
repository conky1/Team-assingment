using System;

namespace Team_software_project
{
    class Elukat
    {
        public string species { get; private set; }
        public string status { get; private set; }
        public string name { get; private set; }
        public int weight { get; private set; }
        public string sound { get; private set; }

        public void Givename()
        {
            Console.Write("\nGive name: \n> ");
            string name = Console.ReadLine();
            this.name = name;
        }

        public void AnimalSpecies()
        {
            Console.Write("Which animal do you want to see ? \n> ");
            string species = Console.ReadLine();
            if (species is "Wolf")
            {
                this.species = species;
                this.status = "wild";
                this.sound = "owooo";              

            }
            else if(species is "Tiger")
            {
                this.species = species;
                this.status = "wild";
                this.sound = "roar"; 
            }
            else if (species is "Bear")
            {
                this.species = species;
                this.status = "wild";
                this.sound = "roar"; 
            }
            else if (species is "Cat")
            {
                this.species = species;
                this.status = "tame";
                this.sound = "meow";
            }
            else if (species is "Dog")
            {
                this.species = species;
                this.sound = "woof";
                this.status = "tame";
            }
            else if (species is "Bird")
            {
                this.species = species;
                this.status = "wild";
                this.sound = "tweet-tweet"; 
          
            }
            else
            {
                Console.WriteLine("Invalid command!\n");
                AnimalSpecies();
            }
        }

        public void Feed()
        {   if (status == "tame")
            {
                this.weight = 1;
            }
            else 
                Hunt(); 

        }

        public void Hunt()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 10);
            this.weight = result <= 6 ? 1 : 0;
        }
        
