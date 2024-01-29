using CommunityToolkit.Diagnostics;

namespace DirectMappingDemo.Domain;

public sealed class Asset2
{
    private static readonly string[] _deniedMetadataNames = new string[]
    {
        "Test"
    };

    public string AssetId { get; private set; }
    public ProjectUri ProjectUri { get; private set; }
    public List<Metadata> Metadatas { get; private set; }
    public bool IsSourceProject { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    
    public Asset2(
        string assetId,
        ProjectUri projectUri,
        bool isSourceProject)
    {
        Guard.IsNull(projectUri);
        Guard.IsNullOrWhiteSpace(assetId);

        AssetId = assetId;
        ProjectUri = projectUri;
        IsSourceProject = isSourceProject;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public void SetProjectUrl(ProjectUri projectUri)
    {
        ProjectUri = projectUri;
        UpdatedAt = DateTime.UtcNow;
    }

    public void AddMetadata(Metadata metadata)
    {
        Guard.IsNull(metadata);

        if (_deniedMetadataNames.Contains(metadata.Name))
        {
            throw new ArgumentException($"The metadata name {metadata.Name} is denied");
        }

        Metadatas.Add(metadata);
    }

    public void RemoveMetadata(Metadata metadata)
    {
        Metadatas.Remove(metadata);
    }
}
