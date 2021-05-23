using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_software_project
{
    public class Animal
    {
        public string species;

        public string status;
        public int weight;
        public string name;

        public Animal(string species, string status, int weight, string name)

        {

            this.species = species;
            this.status = status;
            this.weight = weight;
            this.name = name;


        }

       public void Givename()
        {
            Console.Write("Give name: \n> ");
            string name = Console.ReadLine();
            this.name = name;
        }

    }
} 
        
