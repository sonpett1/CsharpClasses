namespace CsharpClasses;

public class Pets
{
    // FIELDS
    public string Description { get; init; } = "A pet of unknown type";
    private string Name { get; set; }
    private string Noise { get; set; } = "No noise set";
    private string Trick { get; set; } = "No trick set";
    
    // CONSTRUCTORS
    public Pets(string name)
    {
        this.Name = name;
    }
    
    public Pets(string name, string noise, string trick)
    {
        this.Name = name;
        this.Trick = trick;
        this.Noise = noise;
    }
    
    // METHODS
    // Setting Name / Noise / Trick
    public void SetName(string name)
    {
        Name = name;
    }
    
    public void SetNoise(string noise)
    {
        Noise = noise;
    }

    public void SetTrick(string trick)
    {
        Trick = trick;
    }
    
    // prints Name / Noise / Trick
    public string GetName()
    {
        return Name;
    }

    public string GetNoise()
    {
        return Noise;
    }

    public string GetTrick()
    {
        return Trick;
    }
}
