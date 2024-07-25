


Employee employee1 = new Employee("Milovan", "Mihajlovic", 30, 1);
employee1.DescribeMyself();


Employee employee2 = new Employee("Ivana", "Popovic", 35, 65);
employee2.DescribeMyself();


public class Person
{
    //properties
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int BrojGodina { get; set; }

    // konstruktor
    public Person(string ime, string prezime, int brojGodina)
    {
        Ime = ime;
        Prezime = prezime;
        BrojGodina = brojGodina;
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    
    public Employee(string ime, string prezime, int brojGodina, int employeeId)
        //: base(ime, prezime, brojGodina)
    {
        EmployeeId = employeeId;
    }

    public void DescribeMyself()
    {
        Console.WriteLine($"Moje ime je {Ime} {Prezime}, imam {BrojGodina} godina i zaposleni sam sa rednim brojem {EmployeeId}.");
    }
}



