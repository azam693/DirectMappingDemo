using Xunit;

namespace DirectMappingDemo.Domain.Tests;

public sealed class AssetWithErrorTest
{
    private AssetWithError _asset;

    public AssetWithErrorTest()
    {
        var assetOrError = AssetWithError.Create(
            "1",
            "http://test.ru",
            false);
        Assert.False(assetOrError.IsError);

        _asset = assetOrError.Value;
    }

    [Fact]
    public void Asset_SetProject_Success()
    {
        var result = _asset.SetProjectUrl("http://update_url.ru");

        Assert.False(result.IsError);
    }

    [Fact]
    public void Asset_SetProject_Error()
    {
        var result = _asset.SetProjectUrl("<Incorrect uri>");

        Assert.True(result.IsError);
        Assert.Equal(ErrorOr.ErrorType.Validation, result.FirstError.Type);
    }
}
