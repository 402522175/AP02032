public class Teacher:People
{
    private static int id=1;
    public int TID  { get; set; }
    public double Salary {get; set; }
    public List<string> Courses { get; set;}

    public Teacher(string FirstName,string LastName,int YearOfBirth, int TID,double salary)
    : base(FirstName,LastName, YearOfBirth)
    {
        TID = id++;
        Salary = salary;
        Courses = new List<string>();
        if (salary<0){
            try{
                throw new ArgumentException("The Salary must be more than 0!");
            }
            catch(Exception e){
                Console.WriteLine($"{e.Message}");
            }
        }
    }
    public override void Add_course(string course){
        Courses.Add(course);
    }

    public override void Remove_course(string course){
        Courses.Remove(course);
    }

    public override void Print(){
        Console.WriteLine($"Teacher {FirstName} {LastName} with ID {TID} Courses:");
        foreach(var course in Courses){
            Console.WriteLine(course);
        }
    }
    //public void Print_profile(){
    //    Console.BackgroundColor = ConsoleColor.Yellow;
    //    Console.WriteLine($"Teacher {FirstName} {LastName} / {YearOfBirth}");
    //}
}         