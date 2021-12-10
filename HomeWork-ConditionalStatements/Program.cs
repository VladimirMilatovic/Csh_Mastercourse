Console.WriteLine("Enter your name: ");

string name = Console.ReadLine();

if(name.ToLower() == "tim" || name.ToLower() == "timothy")
{
    Console.WriteLine("Hello profesor.");
}
else
{
    Console.WriteLine("Hello student.");
}

switch (name.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("Hello profesor.");
        break;
    default:
        Console.WriteLine("Hello student.");
        break;
}
