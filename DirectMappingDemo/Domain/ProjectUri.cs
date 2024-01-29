namespace DirectMappingDemo.Domain;

public sealed record ProjectUri
{
    public string Uri { get; init; }

    public ProjectUri(string uri)
    {
        if (!IsValidUri(uri))
        {
            throw new ArgumentException($"Incorrect uri {nameof(uri)}");
        }

        Uri = uri;
    }

    private bool IsValidUri(string uri)
    {
        // Validation

        return true;
    }
}
