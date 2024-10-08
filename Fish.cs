using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class Fish : Animal
    {
        public string WaterType { get; set; }

        public Fish(string name, int age, string habitat, string waterType) 
            : base (name, age, habitat)
        {
            WaterType = waterType;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is gulping down some small marine life");
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"WaterType: {WaterType}");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is swimming in water");
        }

        public void BlowBubbles()
        {
            Console.WriteLine($"{Name} is blowing bubbles");
        }

    }
}
