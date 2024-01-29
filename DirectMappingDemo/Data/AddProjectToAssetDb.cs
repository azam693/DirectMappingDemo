using CommunityToolkit.Diagnostics;

namespace DirectMappingDemo.Data;

public sealed class AddProjectToAssetDb
{
    public string AssetId { get; private set; }
    public string ProjectUri { get; private set; }
    public bool IsSourceProject { get; private set; }

    public AddProjectToAssetDb(
        string assetId,
        string projectUri,
        bool isSourceProject)
    {
        Guard.IsNullOrWhiteSpace(assetId);
        Guard.IsNullOrWhiteSpace(projectUri);

        AssetId = assetId;
        ProjectUri = projectUri;
        IsSourceProject = isSourceProject;
    }
}
