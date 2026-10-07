namespace BookIt.CoreApi.Application.Health;

public interface ILivenessService
{
    LivenessResponse GetLiveness();
}
