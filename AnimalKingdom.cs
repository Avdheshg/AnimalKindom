using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKindom
{
    public class AnimalKingdom
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void SimulateAction()
        {
            foreach (Animal animal in animals)
            {
                animal.DisplayDetails();
                animal.Eat();
                animal.Sleep();
                animal.Move();
                Console.WriteLine();
            }
        }

        public void DisplayAllAnimals()
        {
            Console.WriteLine("Displaying all animals in the Kingdom");
            foreach (Animal animal in animals)
            {
                animal.DisplayDetails();
                Console.WriteLine();
            }
        }

    }
}
