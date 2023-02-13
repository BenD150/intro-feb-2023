namespace LearningResourcesApi.Services;

public class SystemTime : ISystemTime // Implementation
{
    public DateTimeOffset GetCurrent() => DateTimeOffset.Now;
}
public interface ISystemTime  // Job Description
{
    DateTimeOffset GetCurrent();
}