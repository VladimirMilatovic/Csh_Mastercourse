do
{
    Console.Clear();
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Hello professor {name}");
    }
    else
    {
        Console.WriteLine($"Hello student {name}");
    }
    Console.WriteLine("To continue pres enter. To Exit type exit");

} while (Console.ReadLine().ToLower() != "exit");

string exit = "";
while (exit.ToLower() != "exit")
{
    Console.Clear();
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Hello professor {name}");
    }
    else
    {
        Console.WriteLine($"Hello student {name}");
    }
    Console.WriteLine("To continue pres enter. To Exit type exit");
    exit= Console.ReadLine();
}