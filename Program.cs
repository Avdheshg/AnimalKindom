
namespace AnimalKindom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AnimalKingdom animalKingdom = new AnimalKingdom();

            Bird eagle = new Bird("Eagle", 5, "Mountains", "Golden Eagle");
            Mammal lion = new Mammal("Lion", 8, "Savannah", "Big Cat");
            Fish shark = new Fish("Shark", 12, "Ocean", "Salt water");

            animalKingdom.AddAnimal(eagle);
            animalKingdom.AddAnimal(lion);
            animalKingdom.AddAnimal(shark);

            // Simulate the actions of all Animals
            Console.WriteLine("Siulating animal behaviours...");
            animalKingdom.SimulateAction();

            animalKingdom.DisplayAllAnimals();

            Console.ReadLine();

        }

    }

}


