using Xunit;

namespace DirectMappingDemo.Domain.Tests;

public sealed class AssetTest
{
    private Asset2 _asset = new Asset2(
        "1",
        new ProjectUri("http://test.ru"), 
        false);

    [Fact]
    public void Asset_SetProject_Success()
    {
        string uri = "http://update_url.ru";
        _asset.SetProjectUrl(new ProjectUri(uri));

        Assert.Equal(_asset.ProjectUri.Uri, uri);
    }

    [Fact]
    public void Asset_SetProject_Error()
    {
        string uri = "<Incorrect uri>";
        _asset.SetProjectUrl(new ProjectUri(uri));

        Assert.Throws<ArgumentException>(() => _asset.SetProjectUrl(new ProjectUri(uri)));
    }
}
