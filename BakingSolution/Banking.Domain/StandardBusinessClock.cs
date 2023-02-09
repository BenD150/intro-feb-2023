using System.Reflection.Metadata.Ecma335;

namespace Banking.Domain;

public class StandardBusinessClock : IProvideTheBusinessClock
{
    return DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 16;
}
