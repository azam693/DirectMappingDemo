using CommunityToolkit.Diagnostics;
using DirectMappingDemo.Application.Common;
using DirectMappingDemo.Data;

namespace DirectMappingDemo.Application;

// Application layer
public sealed class AddProjectsToAssetRequest
{
    private const string DefaultProjectUri = "http://test.ru";

    public Correlation Correlation { get; private set; }
    public string AssetId { get; private set; }
    public string[] ProjectUris { get; private set; }

    public AddProjectsToAssetRequest(
        Correlation correlation,
        int assetId,
        string projectUrisText)
    {
        Guard.IsNotNull(correlation);
        Guard.IsGreaterThan(assetId, 0);

        AssetId = assetId.ToString();
        ProjectUris = projectUrisText.Split(',');
    }
    
    public AddProjectToAssetDb ToAddProjectToAssetDb()
    {
        string projectUri = ProjectUris is null || ProjectUris.Length == 0
            ? DefaultProjectUri
            : ProjectUris[0];

        return new AddProjectToAssetDb(
            AssetId,
            projectUri,
            false);
    }
}
