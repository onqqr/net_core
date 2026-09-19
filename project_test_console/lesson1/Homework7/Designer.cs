namespace project_test_console.lesson1.Homework7;

public class Designer : Employee 
{
    public Designer(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus()
    {
        return salary * 0.12;
    }
}