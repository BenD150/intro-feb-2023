namespace Banking.Domain;

public class SystemTime
{
    public DateTime GetCurrent()
    {
        return DateTime.Now;   
    }
}
