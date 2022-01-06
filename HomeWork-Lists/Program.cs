
string newStudent;
List<string> students=new List<string>();
do
{
    Console.WriteLine("Enter new student to the class. Empty name for exit.");
    newStudent = Console.ReadLine();
    if (newStudent != "")
    {
        students.Add(newStudent);
    }
}while(newStudent != "");
Console.WriteLine($"Total count of students are {students.Count}");