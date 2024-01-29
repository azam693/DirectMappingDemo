using DirectMappingDemo.Application;

namespace DirectMappingDemo.Service;

internal sealed class AddProjectsToAssetEndpoint
{
    public async Task Handle(AddProjectsToAssetRequestDto addProjectsToAssetRequestDto)
    {
        var addProjectToAssetCommand = new AddProjectsToAssetCommand();

        var request = addProjectsToAssetRequestDto.ToRequest();
        await addProjectToAssetCommand.HandleAsync(request);
    }
}
