using DirectMappingDemo.Data;

namespace DirectMappingDemo.Application;

public sealed class AddProjectsToAssetCommand
{
    public AddProjectsToAssetCommand()
    {
        // Init dependencies
    }

    public async Task<bool> HandleAsync(AddProjectsToAssetRequest addProjectsToAssetRequest)
    {
        // Some logic

        var addProjectToAssetDb = addProjectsToAssetRequest.ToAddProjectToAssetDb();

        // Call DB layer

        return true;
    }
}
