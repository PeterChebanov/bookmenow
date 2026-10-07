namespace BookIt.CoreApi.Application.Health;

public sealed class LivenessService : ILivenessService
{
    public LivenessResponse GetLiveness() => new(Status: "ok");
}