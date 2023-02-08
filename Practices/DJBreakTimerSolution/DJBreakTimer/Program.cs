

// Iteration 1 
Console.Write("How long is the break?\n\n");
var breakDouble = double.Parse(Console.ReadLine()); ;
Console.Write("How long is the song?\n\n");
var songLength = TimeSpan.Parse(Console.ReadLine());
var totalMinutes = songLength.TotalMinutes;


var endBreakTime = DateTimeOffset.Now.AddMinutes(breakDouble);
Console.Write($"At the end of the break, it will be {endBreakTime}\n\n");

Console.Write($"The user should start the song at {endBreakTime.AddSeconds(totalMinutes * -1)}\n\n");



// Iteration 2
var timeRemaining = breakDouble;
while (timeRemaining > 0)
{
    Console.Write($"There are {timeRemaining} minutes left in the break\n");
    Thread.Sleep(60000);
    timeRemaining -= 1;
}



