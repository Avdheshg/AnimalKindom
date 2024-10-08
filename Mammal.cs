using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Mammal : Animal
    {
        public string Type { get; set; }

        public Mammal(string name, int age, string habitat, string type)
            : base (name, age, habitat)
        {
            Type = type;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}, the {Type}, is chewing the food");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Type: {Type}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is walking on land");
        }

        public void Roar()
        {
            Console.WriteLine($"{Name} is roaring");
        }
    }
}
