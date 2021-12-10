string name;
int age;

Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
if (int.TryParse(Console.ReadLine(), out age))
{
    switch (name.ToLower())
    {
        case "":
            Console.WriteLine("You didn't enter your name.");
            break;
        case "bob" or "sue":
            Console.Write($"Hello professor {name}.");
            break;
        default:
            if (age < 21)
            {
                Console.WriteLine($"Hello {name}. You have to wait for {21 - age} years to start this class.");
            }
            else
            {
                Console.WriteLine($"Hello {name}. Welcome to the class.");
            }
            break;
    }
}
else
{
    Console.WriteLine("Number is in wrong format.");
}
