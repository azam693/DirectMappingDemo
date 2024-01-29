using CommunityToolkit.Diagnostics;

namespace DirectMappingDemo.Domain;

public sealed class Asset
{
    public string AssetId { get; private set; }
    public string ProjectUri { get; private set; }
    public bool IsSourceProject { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    
    public Asset(
        string assetId,
        string projectUri,
        bool isSourceProject)
    {
        Guard.IsNullOrWhiteSpace(assetId);

        if (!IsValidUri(projectUri))
        {
            throw new ArgumentException($"Incorrect uri {nameof(projectUri)}");
        }

        AssetId = assetId;
        ProjectUri = projectUri;
        IsSourceProject = isSourceProject;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public void SetProjectUrl(string uri)
    {
        if (!IsValidUri(uri))
        {
            throw new ArgumentException($"Incorrect uri {nameof(uri)}");
        }

        ProjectUri = uri;
        UpdatedAt = DateTime.UtcNow;
    }

    private bool IsValidUri(string uri)
    {
        // Validation

        return true;
    }
}
