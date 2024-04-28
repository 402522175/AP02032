interface InterPeople{
    public void Print();
    public void Add_course(string Courses);
    public void Remove_course(string Courses);
}

interface InterAdminisration{
    public void ListNameEmployees();
    public void Add_Teacher(Teacher teacher);
    public void Remove_Teacher(Teacher teacher);
    public void Add_Student(Student student);
    public void Remove_Student(Student student);
    public void Add_Employee(Employees Employee);
    public void Remove_Employee(Employees Employee);
    public void Add_StudentGroup(StudentGroup group);
    public void Remove_StudentGroup(StudentGroup group);
    public double TotalSalary();
}