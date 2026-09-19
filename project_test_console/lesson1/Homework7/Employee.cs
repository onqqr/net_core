namespace project_test_console.lesson1.Homework7;

public class Employee 
{
    protected string name;
    protected double salary;

    public Employee(string name, double salary) 
    {
        this.name = name;
        this.salary = salary;
    }

    public void GetInfo() 
    {
        Console.WriteLine($"Name: {name} \nSalary: {salary}");
    }

    public virtual double CalculateBonus() 
    {
        return salary;
    }
}