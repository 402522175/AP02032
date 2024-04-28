
public class StudentGroup
{
    public string Name{ get; set; }
    public Student Leader{ get; set; }
    public StudentGroup(string name, Student leader){
        Name = name;
        Leader = leader;
    }
    public List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void RemoveStudent(Student student)
    {
        students.Remove(student);
    }
    public void ListNameStudents()
    {
        Console.WriteLine("Students in the group:");
        
        foreach (var student in students)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{student.FirstName} {student.LastName}/{student.YearOfBirth}");
        }
    }
}
