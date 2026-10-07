using BookIt.CoreApi.Application.Health;

using BookIt.CoreApi.Controllers;

namespace BookIt.CoreApi.UnitTests.Controllers;

public sealed class HealthControllerTests
{
    [Fact]
    public void GetLiveness_ReturnsOkStatus()
    {
        var controller = new HealthController(new LivenessService());

        var result = controller.GetLiveness();

        Assert.Equal(new LivenessResponse(Status: "ok"), result);
    }

}
