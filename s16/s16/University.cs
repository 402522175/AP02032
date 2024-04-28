public class University
{
    public string Name { get; set; }
    public string Country { get; set; }
    public Teacher HeadOfUniversity { get; set; }
    public University(string Name, string Country, Teacher HeadOfUniversity){
        this.Name = Name;
        this.Country = Country;
        this.HeadOfUniversity = HeadOfUniversity;
    }
    public List<Department> departments = new List<Department> ();
    public void AddDepartment(Department department){
        departments.Add(department);
    }
    public void RemoveDepartment(Department department){
        departments.Remove(department);
    }
    public List<Administration> administrations = new List<Administration> (); 
    
    public void AddAdministration(string name, Teacher teacher){
        administrations.Add(new Administration(name, teacher));
    }
    public void RemoveAdministration(string name, Teacher teacher){
        administrations.Remove(new Administration(name, teacher));
    }
    public void University_Profile(){
        Console.WriteLine($"\nThe {Name} is one of the {Country} universities ");
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"\nand the head of the university is {HeadOfUniversity.FirstName} {HeadOfUniversity.LastName}");
        Console.ResetColor();
       
        Console.WriteLine("Departments Name:");
        foreach (var department in departments )
        {
            Console.BackgroundColor = ConsoleColor.Green;  
            Console.WriteLine($"\n{department.Name}\n");
            Console.ResetColor();

            Console.WriteLine("Member list:");
            foreach (var student in department.students){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nStudent {student.FirstName} {student.LastName}/{student.YearOfBirth} from {department.Name} department\n");
                Console.ResetColor();
            }
            
            foreach (var teacher in department.teachers){
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nTeacher {teacher.FirstName} {teacher.LastName}/{teacher.YearOfBirth} from {department.Name} department\n");
                Console.ResetColor();
            }
            
            foreach (var employee in department.employees){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nEmployee {employee.FirstName} {employee.LastName}/{employee.YearOfBirth} from {department.Name} department\n");
                Console.ResetColor();
            }
        }
        Console.WriteLine("Administrations Name:");
        foreach (var administration in administrations){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{administration.Name}\n");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"\n{administration.HeadOfAdministration.FirstName} {administration.HeadOfAdministration.LastName}/{administration.HeadOfAdministration.YearOfBirth} The head of {administration.Name} Administration ");
            Console.ResetColor ();
            
            foreach(var employee in administration.employees){
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nEmployee {employee.FirstName} {employee.LastName}/{employee.YearOfBirth} from {administration.Name} administration\n");
                Console.ResetColor();
            }
        }

    
    }
}