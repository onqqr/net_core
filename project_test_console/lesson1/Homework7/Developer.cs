namespace project_test_console.lesson1.Homework7;

public class Developer : Employee 
{
    public Developer(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus() 
    {
        return salary * 0.1;
    }
}