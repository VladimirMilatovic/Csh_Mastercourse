

Console.WriteLine("Enter the list of users. comma-separated.");
string data=Console.ReadLine();

string[] list =data.Split(',');

for (int i = 0; i < list.Count(); i++)
{
    Console.WriteLine($"Hello {list[i]}");
}

List<string> list2 = new List<string>();
string input;
do
{
    Console.WriteLine("Enter user first name: ");
    input = Console.ReadLine();

    if(input != "")
    {
        list2.Add(input);
    }

} while (input!="");

foreach (string firstName in list2)
{
    Console.WriteLine($"Hello {firstName}");
}