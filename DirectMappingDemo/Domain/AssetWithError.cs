using ErrorOr;

namespace DirectMappingDemo.Domain;

public sealed class AssetWithError
{
    public string AssetId { get; private set; }
    public string ProjectUri { get; private set; }
    public bool IsSourceProject { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    private AssetWithError(
        string assetId,
        string projectUri,
        bool isSourceProject)
    {
        AssetId = assetId;
        ProjectUri = projectUri;
        IsSourceProject = isSourceProject;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public static ErrorOr<AssetWithError> Create(
        string assetId,
        string projectUri,
        bool isSourceProject)
    {
        if (string.IsNullOrWhiteSpace(assetId))
        {
            return Error.Validation(description: $"Empty {nameof(assetId)}");
        }

        if (IsValidUri(projectUri))
        {
            return Error.Validation(description: $"Invalid Uri of {nameof(projectUri)}");
        }

        return new AssetWithError(assetId, projectUri,isSourceProject);
    }

    public ErrorOr<Success> SetProjectUrl(string uri)
    {
        if (!IsValidUri(uri))
        {
            return Error.Validation(description: $"Invalid Uri of {nameof(uri)}");
        }

        ProjectUri = uri;
        UpdatedAt = DateTime.UtcNow;

        return Result.Success;
    }

    private static bool IsValidUri(string uri)
    {
        // Validation

        return true;
    }
}
