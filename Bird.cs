using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Bird : Animal
    {
        public string Species { get; set; }

        public Bird(string name, int age, string habitat, string species)
            : base(name, age, habitat)
        {
            Species = species;
        }

        // overriding the common methods
        public override void Eat()
        {
            Console.WriteLine($"{Name}, the {Species}, is pecking at seeds");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Species: {Species}");
        }

        // overrding the abstract method
        public override void Move()
        {
            Console.WriteLine($"{Name} is flying in the sky");
        }

        // specific behaviours
        public void BuildNest()
        {
            Console.WriteLine($"{Name} is building the nest");
        }

    }
}
