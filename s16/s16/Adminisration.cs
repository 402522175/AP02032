public class Administration : InterAdminisration
{
    public string Name { get; set; }
    public Teacher HeadOfAdministration {get; set;}
    public Administration(string name, Teacher headofadministration)
    {
        Name = name;
        HeadOfAdministration = headofadministration;
    }
    public List<Employees> employees = new List<Employees>();

    public virtual void Add_Employee(Employees employee)
    {
        employees.Add(employee);
    }
    public virtual void Remove_Employee(Employees employee)
    {
        employees.Remove(employee);
    }
    public virtual double TotalSalary()
    {
        double Count = 0;
        foreach (var employee in employees)
        {
            Count += employee.Salary;
            Count += HeadOfAdministration.Salary;
        }
        return Count;
    }
    public void ListNameEmployees()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"The Administration {Name} Boss:{HeadOfAdministration.FirstName} {HeadOfAdministration.LastName}/{HeadOfAdministration.YearOfBirth}");
        Console.ResetColor();
        Console.WriteLine("employees list:");
        foreach (var employee in employees)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{employee.FirstName} {employee.LastName}/{employee.YearOfBirth}");
        }
    }
    public virtual void Add_Teacher(Teacher teacher){}
    public virtual void Remove_Teacher(Teacher teacher){}
    public virtual void Add_Student(Student student){}
    public virtual void Remove_Student(Student student){}
    public virtual void Add_StudentGroup(StudentGroup group){}
    public virtual void Remove_StudentGroup(StudentGroup group){}

}