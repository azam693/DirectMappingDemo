using DirectMappingDemo.Application;
using DirectMappingDemo.Application.Common;

namespace DirectMappingDemo.Service;

// Service layer, gRPC model
public sealed record AddProjectsToAssetRequestDto(
    string CorrelationId,
    string RequestId,
    string UserId,
    int AssetId,
    string ProjectUrisText)
{
    public AddProjectsToAssetRequest ToRequest()
    {
        var correlation = new Correlation(
            CorrelationId,
            RequestId,
            UserId);

        return new AddProjectsToAssetRequest(
            correlation,
            AssetId,
            ProjectUrisText);
    }
};
