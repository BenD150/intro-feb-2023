// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evens = numbers.Where(n => n % 2 == 0);

numbers.Add(12);

foreach(var even in evens)
{
    Console.WriteLine(even);
}