using Finger;


// Using the System namespace, Console class, WriteLine method to print out a line
// Shift+Alt+F formats code for you!
Console.Write("What is your status: ");
string? status = Console.ReadLine();

//Type identifier = new 
// myStatus is an instance of StatusMessage
if (status != null)
{
    StatusMessage myStatus = new StatusMessage(status, DateTimeOffset.Now);
    Console.WriteLine($"You said your status was {myStatus.Status} at {myStatus.When:T}");
}
else 
{
    Console.WriteLine("Sorry, cannot have a null status");
}