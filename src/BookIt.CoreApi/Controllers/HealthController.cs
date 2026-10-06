using Microsoft.AspNetCore.Mvc;

namespace BookIt.CoreApi.Controllers;

[ApiController]
[Route("health")]
public sealed class HealthController : ControllerBase
{
    [HttpGet("live")]
    public LivenessResponse GetLiveness() => new(Status: "ok");

}

public sealed record LivenessResponse(string Status);