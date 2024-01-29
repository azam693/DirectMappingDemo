namespace DirectMappingDemo.Data;

public sealed record AddProjectToAssetDbRecord2(
    string AssetId,
    string ProjectUri,
    bool IsSourceProject);
