public class Student:People
{
    private static int id=1;
    public int SID  { get; set; }
    public List<string> Courses { get; set;}
    public List<double> Grades { get; set;}

    public Student(string FirstName,string LastName,int YearOfBirth, int SId)
    : base(FirstName,LastName, YearOfBirth)
    {
        this.SID = SId;
        SID = id++;
        Courses = new List<string>();
        Grades = new List<double>();
    }
    public override void Add_course(string course){
        Courses.Add(course);
    }

    public override void Remove_course(string course){
        Courses.Remove(course);
    }

    public void Add_grades(double gr){
        Grades.Add(gr);
    }

    public void Remove_grade(double gr){
        Grades.Remove(gr);
    }
    public double Avg()
    {
        if (Grades.Count==0){
            return 0.0;	
        }
        return Grades.Average();
    }
    public override void Print(){
        Console.WriteLine($"Student {FirstName} {LastName} with ID {SID} Courses:");
        foreach(var course in Courses){
            Console.WriteLine(course);
            }
        Console.WriteLine($"Student {FirstName} {LastName} with ID {SID} Grades:");
        foreach(var grade in Grades){
            Console.WriteLine(grade);
        }
    }
}