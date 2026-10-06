using System.Net.Http.Json;
using BookIt.CoreApi.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;

namespace BookIt.CoreApi.IntegrationTests.Health;

public sealed class HealthEndpointTestsi(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task GetHealthLive_ReturnOkJson()
    {
        var response = await _client.GetAsync("/health/live");

        var body = await response.Content.ReadFromJsonAsync<LivenessResponse>();

        Assert.NotNull(body);
        Assert.Equal("ok", body.Status);
    }
}
