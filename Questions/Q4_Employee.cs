namespace CSharpAssignment3.Questions;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string department, double salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }

    public void GiveRaise(double percentage)
    {
        double raiseAmount = Salary * (percentage / 100);
        Salary += raiseAmount;
        Console.WriteLine(Name + " got a " + percentage + "% raise. New salary: " + Salary);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine();
    }
}

public static class Q4_Employee
{
    public static void Run()
    {
        Console.WriteLine("Q4: Employee Class");
        Console.WriteLine();

        Employee emp1 = new Employee("Usman Tijiani", "Engineering", 350000);
        Employee emp2 = new Employee("Aisha Bello", "Marketing", 280000);
        Employee emp3 = new Employee("Emeka Okonkwo", "Finance", 420000);

        Console.WriteLine("--- Before Raises ---");
        emp1.DisplayInfo();
        emp2.DisplayInfo();
        emp3.DisplayInfo();

        emp1.GiveRaise(15);
        emp2.GiveRaise(10);
        emp3.GiveRaise(20);

        Console.WriteLine();
        Console.WriteLine("--- After Raises ---");
        emp1.DisplayInfo();
        emp2.DisplayInfo();
        emp3.DisplayInfo();
    }
}
