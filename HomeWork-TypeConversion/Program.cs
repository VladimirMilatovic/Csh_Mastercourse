Console.Write("Enter your age: ");
string ageAsString = Console.ReadLine();

int age;
int.TryParse(ageAsString, out age);

Console.WriteLine($"Your age before 25 years was: {age-25}");
