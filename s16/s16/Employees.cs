public class Employees:People
{
    private static int id=1;
    public int EID  { get; set; }
    public double Salary {get; set; }

    public Employees(string FirstName,string LastName,int YearOfBirth, int EID,double salary)
    : base(FirstName,LastName, YearOfBirth)
    {
        EID = id++;
        Salary = salary;
        if (salary<0){
            try{
                throw new ArgumentException("The Salary must be more than 0!");
            }
            catch(Exception e){
                Console.WriteLine($"{e.Message}");
            }
        }
    }

    //public void Print_profile(){
    //    Console.BackgroundColor = ConsoleColor.Red;
    //    Console.WriteLine($"Employee {FirstName} {LastName} / {YearOfBirth}");
    //}
}         