public class Department : Administration 
{
    public new string Name { get; set; }
    public Department(string name, Teacher headofadministration) 
    : base(name, headofadministration)
    {
        Name = name;
    }
    
    public List<Teacher> teachers = new List<Teacher>();
    public override void Add_Teacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public override void Remove_Teacher(Teacher teacher)
    {
        teachers.Remove(teacher);
    }

    public List<Student> students = new List<Student>();
    public override void Add_Student(Student student)
    {
        students.Add(student);
    }
    public override void Remove_Student(Student student)
    {
        students.Remove(student);
    }
    public new List<Employees> employees = new List<Employees>();
    public override void Add_Employee(Employees employee)
    {
        employees.Add(employee);
    }
    public override void Remove_Employee(Employees employee)
    {
        employees.Remove(employee);
    }

    public List<Administration> administration = new List<Administration> (); 
    public void Add_Administration(string name, Teacher boss)
    {
        administration.Add(new Administration(name, boss));
    }
    public void Remove_Administration(string name, Teacher boss)
    {
        administration.Remove(new Administration(name, boss));
    }

    public override double TotalSalary(){
        double Count = 0;
        foreach (var employee in employees)
        {
            Count += employee.Salary;
        }
        foreach (var teacher in teachers)
        {
            Count += teacher.Salary;
        }
        Count += HeadOfAdministration.Salary;
        return Count;
    }
    public void DepartmentProfile(){
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"The Administration {Name} Boss:{HeadOfAdministration.FirstName} {HeadOfAdministration.LastName}/{HeadOfAdministration.YearOfBirth}");
        Console.WriteLine("teachers list:");
        foreach (var teacher in teachers )
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName}/{teacher.YearOfBirth}");
        }
        Console.WriteLine("students list:");
        foreach (var student in students )
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{student.FirstName} {student.LastName}/{student.YearOfBirth}");
        }
        Console.WriteLine("employees list:");
        foreach (var employee in employees)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{employee.FirstName} {employee.LastName}/{employee.YearOfBirth}");
        }
    }
    
}