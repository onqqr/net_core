namespace project_test_console.lesson1.Homework7;

public class Manager : Employee 
{
    public Manager(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus() 
    {
        return salary * 0.15;
    }
}