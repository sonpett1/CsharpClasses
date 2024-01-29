namespace CsharpClasses;

public class Dog : Pets
{
    public Dog(string name, string noise = "WOOF", string trick = "chases tail") : base(name, noise, trick)
    {
        Description = "dog";
    }
}