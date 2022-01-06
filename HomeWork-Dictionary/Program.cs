Dictionary<string, string> employees = new Dictionary<string, string>();
employees["1"] = "Tim Corey";
employees["2"] = "Sue Storm";
employees.Add("3", "Bob Dylan");
employees.Add("4", "Freddie Mercury");



Console.WriteLine("Enter employee ID to get details: ");
string id = Console.ReadLine();
Console.WriteLine($"Employee with ID {id} is {employees[id]}");
