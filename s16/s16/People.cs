public class People : InterPeople
{
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public int YearOfBirth { get; set;}

    public People(string FirstName, string LastName, int YearOfBirth)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.YearOfBirth = YearOfBirth;
    }

    public virtual void Print()
    {
        Console.WriteLine($"{FirstName},{LastName},{YearOfBirth}");
    }
    public virtual void Add_course(string Courses){
        
    }
    public virtual void Remove_course(string Courses){
        
    }
}