// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine($"What is your favorite subject?");
var answer = Console.ReadLine();

switch (answer)
{
    case "Math":
        Console.WriteLine("You are problem solver");
        break;
    case "English":
        Console.WriteLine("You are literary genius");
        break;
    case "Science":
        Console.WriteLine("You are Mad");
        break;
    case "History":
        Console.WriteLine("You live in the past");
        break;
    default:
        Console.WriteLine("Are you sure of that");
        break;



}
