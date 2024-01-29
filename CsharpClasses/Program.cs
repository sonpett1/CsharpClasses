namespace CsharpClasses;

class Program
{
    static void Main(string[] args)
    {
        // My collection of Pets
        List<Pets> petList = new List<Pets>();
        
        // Making pets
        Bunny myBunny1 = new Bunny("Bobo");
        Bunny myBunny2 = new Bunny("Ellie");
        Dog myDog1 = new Dog("Freia");
        Dog myDog2 = new Dog("Luna", "loud breathing sounds", "always hungry");
        Fish myFish1 = new Fish("Stor Laksen", "mrrglrrglrrr", "jump");
        Fish myFish2 = new Fish("Børret");
        
        // Adding pets to list
        petList.Add(myBunny1);
        petList.Add(myBunny2);
        petList.Add(myDog1);
        petList.Add(myDog2);
        petList.Add(myFish1);
        petList.Add(myFish2);
        
        // Looping through
        foreach (Pets pet in petList)
        {
            Console.WriteLine($"My {pet.Description} {pet.GetName()}");
            Console.WriteLine($"Noise: {pet.GetNoise()}");
            Console.WriteLine($"Trick: {pet.GetTrick()} \n");
        }
    }
}