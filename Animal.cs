using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }

        public Animal(string name, int age, string habitat)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
        }

        // Common methods for all animals
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Animal: {Name}, Age: {Age}, Habitat: {Habitat}");
        }

        // abstract method to be overridden in derived classes as per their behaviours
        public abstract void Move();


    }
}
