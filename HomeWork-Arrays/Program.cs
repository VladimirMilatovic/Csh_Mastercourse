
string[] names = new string[] { "Tim", "Bob", "Sue" };
bool exit = false;

while (exit == false)
{
    Console.WriteLine("Chose number from 1 to 3");
    int number;
    if (int.TryParse(Console.ReadLine(), out number))
    {
        if (number < 1 || number > 3)
        {
            Console.WriteLine("Number is out of range.");
        }
        else
        {
            Console.WriteLine($"Your name is {names[number - 1]}");
            exit = true;
        }
    }
    else
    {
        Console.WriteLine("Enter valid number value.");
    }
}
