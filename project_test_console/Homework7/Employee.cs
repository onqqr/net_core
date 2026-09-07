namespace project_test_console;

public class Employee {
    protected string name;
    protected double salary;

    public Employee(string name, double salary) {
        this.name = name;
        this.salary = salary;
    }

    public void GetInfo() {
        Console.WriteLine($"Name: {name} \nSalary: {salary}");
    }

    public virtual double CalculateBonus() {
        return salary;
    }
}