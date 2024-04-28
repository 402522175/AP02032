namespace s16;

class Program
{
    static void Main(string[] args)
    {
        Teacher HeadBoss = new Teacher("Dr.Davood","Yonesian",1959,167,50);
        University university=new University("IUST","Iran",HeadBoss);
        
        Teacher HeadOfCE=new Teacher("Dr.Naser","Mozayyani",1968,234,40);
        Department CE =new Department("Computer",HeadOfCE);
        Teacher CE_T1=new Teacher("Dr.Sauleh","Etemadi",1979,258,30);
        Teacher CE_T2=new Teacher("Dr.Vesal","Hakami",1994,209,30);
        Teacher CE_T3=new Teacher("Dr.Marzieh","Davoodabadi",1985,208,30);
        CE.Add_Teacher(CE_T1);
        CE.Add_Teacher(CE_T2);
        CE.Add_Teacher(CE_T3);
        Student CE_S1=new Student("Matin","Nouri",2005,4025201);
        Student CE_S2=new Student("Saman","KhajeAmiri",2005,4025202);
        Student CE_S3=new Student("MohamadReza","Yousefi",2004,4025203);
        CE.Add_Student(CE_S1);
        CE.Add_Student(CE_S2);
        CE.Add_Student(CE_S3);
        Employees CE_E1=new Employees("Mr.Ali","Yavari",1945,151,18);
        Employees CE_E2=new Employees("Mr.Hasan","Nayebi",1950,152,18);
        Employees CE_E3=new Employees("Mr.Hoseein","Hoseini",1955,164,18);
        CE.Add_Employee(CE_E1);
        CE.Add_Employee(CE_E2);
        CE.Add_Employee(CE_E3);
        StudentGroup CE_SG1=new StudentGroup("Anjoman Elmi",CE_S3);
        StudentGroup CE_SG2=new StudentGroup("Daftar Farhangi",CE_S2);
        CE.Add_StudentGroup(CE_SG1);
        CE.Add_StudentGroup(CE_SG2);
        
        Teacher HeadOfMcE=new Teacher("Dr.Esmail","Khanmirza",1968,234,40);
        Department McE =new Department("Mechanical",HeadOfMcE);
        Teacher McE_T1=new Teacher("Dr.Sasan","Asiayi",1979,258,30);
        Teacher McE_T2=new Teacher("Dr.Borhan","Beigzade",1994,209,30);
        Teacher McE_T3=new Teacher("Dr.Mohamad","HAghpanahi",1992,208,30);
        McE.Add_Teacher(McE_T1);
        McE.Add_Teacher(McE_T2);
        McE.Add_Teacher(McE_T3);
        Student McE_S1=new Student("Zahra","Ahmadi",2005,4025901);
        Student McE_S2=new Student("Ali","Mohamadi",2005,4025902);
        Student McE_S3=new Student("Fatemeh","Akbari",2005,4025903);
        McE.Add_Student(McE_S1);
        McE.Add_Student(McE_S2);
        McE.Add_Student(McE_S3);
        Employees McE_E1=new Employees("Ms.Mahboobe","Safari",1945,151,18);
        Employees McE_E2=new Employees("Mr.Saeed","Rasooli",1950,152,18);
        Employees McE_E3=new Employees("Mr.Parviz","Kavian",1955,164,18);
        McE.Add_Employee(McE_E1);
        McE.Add_Employee(McE_E2);
        McE.Add_Employee(McE_E3);
        StudentGroup McE_SG1=new StudentGroup("Anjoman Elmi",McE_S3);
        StudentGroup McE_SG2=new StudentGroup("Daftar Farhangi",McE_S2);
        McE.Add_StudentGroup(McE_SG1);
        McE.Add_StudentGroup(McE_SG2);
        
        Teacher HeadOfEE=new Teacher("Dr.Mohammad","Azim karami",1955,234,40);
        Department EE =new Department("Electrical",HeadOfEE);
        Teacher EE_T1=new Teacher("Dr.Karim","Mohammadi",1940,258,30);
        Teacher EE_T2=new Teacher("Dr.Hedarali","Shayanfar",1945,209,30);
        Teacher EE_T3=new Teacher("Dr.Sadegh","Jamali",1940,208,30);
        EE.Add_Teacher(EE_T1);
        EE.Add_Teacher(EE_T2);
        EE.Add_Teacher(EE_T3);
        Student EE_S1=new Student("Ali","Ahmadi",2005,4025001);
        Student EE_S2=new Student("Fatemeh","Akbari",2005,4025002);
        Student EE_S3=new Student("Zahra","Mohamadi",2005,4025003);
        EE.Add_Student(EE_S1);
        EE.Add_Student(EE_S2);
        EE.Add_Student(EE_S3);
        Employees EE_E1=new Employees("Mr.Majid","Bagheri",1945,151,18);
        Employees EE_E2=new Employees("Mr.Ali","Moosavi",1950,152,18);
        Employees EE_E3=new Employees("Mr.Mohamadtaghi","Alayi",1942,164,18);
        EE.Add_Employee(EE_E1);
        EE.Add_Employee(EE_E2);
        EE.Add_Employee(EE_E3);
        StudentGroup EE_SG1=new StudentGroup("Anjoman Elmi",EE_S1);
        StudentGroup EE_SG2=new StudentGroup("Daftar Farhangi",EE_S2);
        EE.Add_StudentGroup(EE_SG1);
        EE.Add_StudentGroup(EE_SG2);

        Teacher AD_Head1=new Teacher("Dr.Asghar","HabibNejad",1940,2567,40);
        Administration AD1=new Administration("Educational Assistant",AD_Head1);
        Employees ademployee1=new Employees("Ms.Pooran","Khalili",1940,1598,18);
        Employees ademployee2=new Employees("Ms.Fahimeh","Rahimi",1960,1597,18);
        Employees ademployee3=new Employees("Mr.Seyyed MohammadReza","Mosavi",1952,1596,18);
        AD1.Add_Employee(ademployee1);
        AD1.Add_Employee(ademployee2);
        AD1.Add_Employee(ademployee3);
        Teacher AD_Head2=new Teacher("Dr.Alireza","Hemmati",1955,3097,40);
        Administration AD2=new Administration("Student Vice-Chancellor",AD_Head2);
        Employees ademployee4=new Employees("Ms.Ameneh","Mehrab Beyghi",1940,1595,18);
        Employees ademployee5=new Employees("Ms.Tooba","Kermanshai",1941,1594,18);
        Employees ademployee6=new Employees("Ms.Seyyedeh Zahra","Hadian",1950,1593,18);
        AD2.Add_Employee(ademployee4);
        AD2.Add_Employee(ademployee5);
        AD2.Add_Employee(ademployee6);
        Teacher AD_Head3=new Teacher("Dr.Mohammad","Vahedi",1943,2592,40);
        Administration AD3=new Administration("Cultural Department",AD_Head3);
        Employees ademployee7=new Employees("Mr.Hasan","Ziaeefard",1945,1592,18);
        Employees ademployee8=new Employees("Mr.Farhad","Ahmadi",1946,1591,18);
        Employees ademployee9=new Employees("Mr.Amir","Mirzaee",1950,1590,18);
        AD3.Add_Employee(ademployee7);
        AD3.Add_Employee(ademployee8);
        AD3.Add_Employee(ademployee9);

        university.AddAdministration("Educational Assistant",AD_Head1);
        university.AddAdministration("Student Vice-Chancellor",AD_Head2);
        university.AddAdministration("Cultural Department",AD_Head3);
        university.AddDepartment(CE);
        university.AddDepartment(EE);
        university.AddDepartment(McE);
        university.University_Profile();
    }
}
