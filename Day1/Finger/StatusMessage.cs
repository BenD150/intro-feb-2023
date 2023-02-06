namespace Finger
{
// Essentially just a class 
public record StatusMessage(Guid Id, string Status, DateTimeOffset When);
}