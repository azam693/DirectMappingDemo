namespace DirectMappingDemo.Domain;

public sealed class Metadata
{
    public string Name { get; private set; }

    public Metadata(string name)
    {
        Name = name;
    }
}
