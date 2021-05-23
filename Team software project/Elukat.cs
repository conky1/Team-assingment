using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_software_project
{
    class Elukat
    {
        public string species;
        public string status;
        public string name;
        public int weight;

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
            }
            else if(species is "Tiger")
            {
                this.species = species;
            }
            else if (species is "Bear")
            {
                this.species = species;
            }
            else if (species is "Cat")
            {
                this.species = species;
            }
            else if (species is "Dog")
            {
                this.species = species;
            }
            else if (species is "Bird")
            {
                this.species = species;
            }
            else
            {
                Console.WriteLine("Invalid command!\n");
                AnimalSpecies();
            }
        }

        public void Feed()
        {
            this.weight = 1;

        }

        public string Name
        {
            get { return this.name; }

        }

        public string Species
        {
            get { return this.species; }
        }

        public int Weight
        {
            get { return this.weight; }

        }

    }
}
