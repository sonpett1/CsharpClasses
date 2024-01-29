namespace CsharpClasses;

public class Fish : Pets
{
    public Fish(string name, string noise = "blows bubbles", string trick = "blub") : base(name, noise, trick)
    {
        Description = "fish";
    }

}