
string name=string.Empty;
int? age = null;
bool isAlive;
string phoneNumber;

Console.WriteLine("Enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Enter your age:");
int.TryParse(Console.ReadLine(), out int tmpage);
age = tmpage;

Console.WriteLine("Are you alive? Y/N");
isAlive = Console.ReadLine().ToUpper() == "Y";

Console.WriteLine("Enter your phone number:");
phoneNumber = Console.ReadLine();

Console.WriteLine($"Name {name}, Age: {age}, IsAlive: {isAlive}, Phone number: {phoneNumber}");
