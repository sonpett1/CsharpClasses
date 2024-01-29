namespace CsharpClasses;

class Bunny : Pets
{
    public Bunny(string name, string noise = "...", string trick = "flop") : base(name, noise, trick)
    {
        Description = "bunny";
    }
}