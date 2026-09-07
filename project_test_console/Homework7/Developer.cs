namespace project_test_console;

public class Developer : Employee {
    public Developer(string name, double salary)
        : base(name, salary) {}

    public override double CalculateBonus() {
        return salary * 0.1;
    }
}