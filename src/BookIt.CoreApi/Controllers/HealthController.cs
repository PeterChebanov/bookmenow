using Microsoft.AspNetCore.Mvc;
using BookIt.CoreApi.Application.Health;

namespace BookIt.CoreApi.Controllers;

[ApiController]
[Route("health")]
public sealed class HealthController(ILivenessService liveness) : ControllerBase
{
    [HttpGet("live")]
    public LivenessResponse GetLiveness() => liveness.GetLiveness();

}
